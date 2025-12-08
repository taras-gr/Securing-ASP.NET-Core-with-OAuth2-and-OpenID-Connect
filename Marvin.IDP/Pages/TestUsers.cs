// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Marvin.IDP;

public static class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {                
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "26931604-54CF-42D5-99C7-4F705CB3AB9B",
                    Username = "David",
                    Password = "password",

                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "David"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                    }
                },
                new TestUser
                {
                    SubjectId = "9446A682-10DC-4A4A-8D56-A1817EB4554F",
                    Username = "Emma",
                    Password = "password",

                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "Emma"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                    }
                },            
            };
        }
    }
}