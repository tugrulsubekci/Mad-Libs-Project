// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
      This program is my first project with C# 
      21.05.2022 and 14:26
      Author: tugrulsubekci
      */


// Let the user know that the program is starting:
Console.WriteLine("Mad Libs is starting!");

// Give the Mad Lib a title:
string title = "PROJECT MAD LIBS";

// Print the title
Console.WriteLine(title);


// Define user input and variables:
Console.Write("Enter a name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter a color:");
string color = Console.ReadLine();

Console.WriteLine("Enter a feeling:");
string feeling = Console.ReadLine();

Console.WriteLine("Enter a texture:");
string texture = Console.ReadLine();

Console.WriteLine("Enter a action(verb):");
string action = Console.ReadLine();

Console.WriteLine("Enter a person(noun):");
string person = Console.ReadLine();

Console.WriteLine("Enter a thing(noun):");
string thing = Console.ReadLine();

Console.WriteLine("Enter an animal");
string animal = Console.ReadLine();

Console.WriteLine("Enter a food");
string food = Console.ReadLine();

Console.WriteLine("Enter a fruit:");
string fruit = Console.ReadLine();

Console.WriteLine("Enter a superhero:");
string hero = Console.ReadLine();

Console.WriteLine("Enter a  country:");
string country = Console.ReadLine();

Console.WriteLine("Enter a dessert:");
string dessert = Console.ReadLine();

Console.WriteLine("Enter a year");
string year = Console.ReadLine();


// The template for the story:
string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {texture} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {person}, which made all the {fruit}s very {color}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {thing}s ruled the world.";


// Print the story:
Console.WriteLine(story);
