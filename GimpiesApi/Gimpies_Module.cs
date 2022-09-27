using System;
using System.Collections.Generic;
using GimpiesApi;

public class HomeModule : ICarterModule
{
    /**
     * how to use in an API environment
     * Always split the response by " - "
     * as the fist part is ALWAYS a status code and the second part is the response or debugging text
     */
    /**
     * Success Codes
     * 200 Login succesful
     * 201 User registered
     *
     * 
     * error codes
     * 400 - Wrong password
     * 401 - User already exists
     * 402 - User not found
     * 
     */
    private Dictionary<String, String> LoginDictionary= new Dictionary<String, String>();
    private Func<String> uuidv4 = () => Guid.NewGuid().ToString();
    private database db = new database();

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        //general stuff
        app.MapGet("/", () => "Gimpies API v1");
        app.MapGet("/api/v1", () => "App is located at /");
        // login
        app.MapGet("/login/{username}/{password}", (String username, String password) =>
        {
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
    }
}