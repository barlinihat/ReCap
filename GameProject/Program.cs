// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using GameProject;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer { Id = 1, BirthYear = 1997, FirstName = "Robert", LastName = "Marie", IdentityNumver = 12345 });


