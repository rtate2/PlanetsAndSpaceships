using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //add planets to end of the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //create another list with the last two planets
            List<string> lastTwoPlanets = new List<string> { "Uranus", "Neptune"};

            //combine the two lists
            planetList.AddRange(lastTwoPlanets);

            //insert planets in the proper index, in the correct order
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //add the last planet to the list
            planetList.Add("Pluto");

            //slicing the list in order to extract the rocky planets into a new list
            List<string> rockyPlanets = new List<string>();
                rockyPlanets.AddRange(planetList.GetRange(0, 4));

            //remove last planet from list
            planetList.Remove("Pluto");

            //create a dictionary
            Dictionary<string, string> spaceCraft = new Dictionary<string, string>();
            //adding to dictionary
            spaceCraft.Add("Mercury", "Mariner 10, Messenger");
            spaceCraft.Add("Venus","Messenger, Mariner 10, Mariner 1, Mariner 2");
            spaceCraft.Add("Mars", "Mariner 4");
            spaceCraft.Add("Jupiter", "Pioneer 10");
            spaceCraft.Add("Saturn", "Voyager 1");
            spaceCraft.Add("Uranus", "Voyager 2");
            spaceCraft.Add("Neptune", "Voyager 2");
            spaceCraft.Add("Pluto", "New Horizons");

            //interating through the planets list and then adding conditional to display the planet name with matching dictionary
            foreach (var planet in planetList)
            {
                if (spaceCraft.ContainsKey(planet))
                    Console.WriteLine($"{planet}: {spaceCraft[planet]}");
            }
        }
    }
}
