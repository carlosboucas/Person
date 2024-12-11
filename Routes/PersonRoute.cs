﻿using Person.Models;

namespace Person.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app)
        {
            app.MapGet(pattern: "person", () => new PersonModel(name:"Rodrigo"));
        }
    }
}
