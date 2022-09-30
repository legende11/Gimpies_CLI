using System;
using System.Collections.Generic;
using System.Linq;
using GimpiesApi;
using Newtonsoft.Json;

public class Gimpies_Module : ICarterModule
{
    /**
     * how to use in an API environment
     * Always split the response by " - "
     * as the fist part is  a status code and the second part is the response or debugging text
     */
    /**
     * Success Codes
     * 200 - Login succesful
     * 201 - User registered
     * 202 - Order succesful
     */
    /**
     * error codes
     * 400 - Wrong password
     * 401 - User already exists
     * 402 - User not found
     * 403 - Order not found
     * 404 - Path not found
     * 405 - Not enough stock
     * 501 - Server error
     */
    private static Dictionary<String, String> LoginDictionary= new Dictionary<String, String>();
    // a few lambda expressions later
    // generate a uuidv4 for customer login cache
    private readonly Func<String> uuidv4 = () => Guid.NewGuid().ToString();
    // Get key by value
    private readonly Func<string, string> getKey = value => LoginDictionary.FirstOrDefault(x => x.Value == value).Key; 
    private database db = new database();

    private String ProductToString(List<database.products.Product> products)
    {
        String s = JsonConvert.SerializeObject(products);
        return s;
    }
    private String OrdersToString(List<database.OrderDB.order> orders)
    {
        return JsonConvert.SerializeObject(orders);
    }
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        //general stuff
        app.MapGet("/", () => "Gimpies API v1");
        app.MapGet("/api/v1", () => "App is located at /");
        // login
        app.MapGet("/login/{username}/{password}", (String username, String password) =>
        {
            if (password == null)
            {
                return "404 - Path not found";
            }
            if (database.UserDatabase.GetUser(username).id.Equals(new database.UserDatabase.user().id))
            {
                return "402 - User not found";
            }
            if (database.UserDatabase.GetUser(username).password != password)
            {
                return "400 - Incorrect password supplied";
            }
            if (username != null && LoginDictionary.ContainsKey(username))
            {
                return "200 - " + LoginDictionary[username]; // just grab it from the map if it exists (user logged in since last reboot)
            }
            String uuid = uuidv4();
            LoginDictionary.Add(username, uuid); // remember token so the dictionary doesn't have to get spammed when logging in.
            return "200 - " + uuid; // why grab the uuid out of the map when we have it as a variable
        });


        app.MapGet("register/{username}/{password}", (String username, String password) =>
        {
            if (database.UserDatabase.GetUser(username).id.Equals(new database.UserDatabase.user().id))
            {
                database.UserDatabase.newUser(username, password);
                return "201 " + "-" + " New user made";
            }
            return "401 - User already exists";

        });
        //product paths.
        // return the products as a json format that JS can read
        app.MapGet("products/products", () => ProductToString(database.products.GetProducts()));
        // generate a order and remove the stock.
        app.MapGet("products/order/{userID}/{productID}/{amount}", new Func<string, int, int, string>((string userID, int productID, int amount) =>
        {
            if (userID == null)
            {
                return "402 - User not found";
            }
            if (getKey(userID) == null) 
            {
                return "402 - User not found";
            }

            if (productID == null)
            {
                return "404 - Path not found";
            }
            if (amount == null)
            {
                return "404 - Path not found";
            }

            if (amount < 0)
            {
                return "501 - Server error";
            }

            if (!database.products.UpdateProduct(productID, amount))
            {
                return "405 - Not enough stock";
            };
            database.products.UpdateAmountPurchased(productID, amount);
            string key = getKey(userID);
            int uid = database.UserDatabase.GetUser(key).id;
            return database.OrderDB.NewOrder(productID, uid, amount) ? ProductToString(database.products.GetProducts()) : "501 - Couldn't place order";

        }));
        // get the orders of a specific user
        app.MapGet("orders/get/{userid}", (String userid) =>
        {
            if (userid == null)
            {
                return "404 - Path not found";
            }
            if (getKey(userid) == null)
            {
                return "402 - User not found";
            }
            string username = getKey(userid);
            int id = database.UserDatabase.GetUser(username).id;
            
            return OrdersToString(database.OrderDB.GetOrders(id));
        });
    }
}