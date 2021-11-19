/*
 Date:Nov.18.2021
 Name: Yuki Waka
 */

using System.Collections.Generic;


namespace arraySort
{
    public class Item  //Item Class
    {
        private string title;
        private int popularity;
        private int price;
  

        public Item(string title, int popularity, int price) //Constructor
        {
            this.title = title;
            this.popularity = popularity;
            this.price = price;
        }

        public string GetTitle()
        {
            return title;
        }

        public void Settitle(string title)
        {
            this.title = title;
        }

        public int GetPopularity()
        {
            return popularity;
        }

        public void Setpopularity(int popularity)
        {
            this.popularity = popularity;
        }

        public int GetPrice()
        {
            return price;
        }
        public void Setpricee(int price)
        {
            this.price = price;
        }
    }
    public class ItemComparer : IComparer<Item> //Class Item Comparer
    {

        public enum sortBy { popularity } //enum

    
        public sortBy compareByFields;
        public int Compare(Item x, Item y) //compare two items
        {

            if (y.GetPopularity() == x.GetPopularity()) //if two item's popularity is the same 
            {
                return x.GetPrice().CompareTo(y.GetPrice()); //return the price is cheaper(lower)
            }
            else
            {
                return y.GetPopularity().CompareTo(x.GetPopularity()); //return item which popularity is higher 
            }

        }    
    }
}
