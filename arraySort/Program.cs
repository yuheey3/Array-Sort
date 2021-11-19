/*
 Date:Nov.18.2021
 Name: Yuki Waka
 */
using System;
using System.Collections.Generic;

namespace arraySort
{
    class Program
    {
        static void Main(string[] args)

        {
            //create array list and add hardcoded data

            List<Item> listOfItem = new List<Item>();  
            listOfItem.Add(new Item("Selfie Stick", 98, 29));
            listOfItem.Add(new Item("iPhone Case", 90, 15));
            listOfItem.Add(new Item("Fire TV Stick", 48, 49));
            listOfItem.Add(new Item("Wyze Cam", 48, 25));
            listOfItem.Add(new Item("Water Filter", 56, 49));
            listOfItem.Add(new Item("Blue Light Blocking Glasses", 90, 16));
            listOfItem.Add(new Item("Ice Make", 47, 119));
            listOfItem.Add(new Item("Video Doorbell", 47, 199));
            listOfItem.Add(new Item("AA Batteries", 64, 12));
            listOfItem.Add(new Item("Disinfecting Wipes", 37, 12));
            listOfItem.Add(new Item("Baseball Cards", 73, 16));
            listOfItem.Add(new Item("Winter Gloves", 32, 112));
            listOfItem.Add(new Item("Microphone", 44, 22));
            listOfItem.Add(new Item("Pet Kennel", 5, 24));
            listOfItem.Add(new Item("Jenga Classic Game", 100, 7));
            listOfItem.Add(new Item("Ink Cartridges", 88, 45));
            listOfItem.Add(new Item("Instant Pot", 98, 59));
            listOfItem.Add(new Item("Hoze Nozzle",74 , 26));
            listOfItem.Add(new Item("Gift Card",45 ,25));
            listOfItem.Add(new Item("Keyboard", 82, 19));

            string space = " ";

            Console.WriteLine("***************************** Original Array*****************************\n");
            Console.WriteLine(space.PadRight(15) + "TITLE".PadRight(16) + "POPULARITY".PadRight(23) + "PRICE\n");


            foreach (var item in listOfItem)
            {
                Console.WriteLine(item.GetTitle().PadRight(35) + ((item.GetPopularity()).ToString()).PadRight(20) + item.GetPrice());
            }

            //sort the item with popularity and price  
            ItemComparer compare = new ItemComparer();
            compare.compareByFields = ItemComparer.sortBy.popularity;

            listOfItem.Sort(compare);

            Console.WriteLine("\n\n****************After Sorted by Popularity and then price****************\n");
            Console.WriteLine(space.PadRight(15) + "TITLE".PadRight(16) + "POPULARITY".PadRight(23) + "PRICE\n");

            foreach (var item in listOfItem)
            {
                Console.WriteLine(item.GetTitle().PadRight(35) + ((item.GetPopularity()).ToString()).PadRight(20) + item.GetPrice());
            }
         
        }

    }
}