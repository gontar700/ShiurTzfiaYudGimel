using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Book
    {
        // הגדרת תכונות
        private string name;    // שם הספר
        private string writer;  // שם הסופר
        private int pages;      // מספר עמודים
        private double price;   // מחיר הספר

        // פעולה בונה 
        public Book(string name, string writer, int pages, double price)
        {
            this.name = name;
            this.writer = writer;
            this.pages = pages;
            this.price = price;
        }
        // פעולות מאחזרות
        public string GetName()
        {
            return this.name;
        }

        public string GetWriter()
        {
            return this.writer;
        }

        public int GetPages()
        {
            return this.pages;
        }

        public double GetPrice()
        {
            return this.price;
        }

        // פעולות קובעות
        public void SetPrice(double price)
        {
            this.price = price;
        }

        // פעולות חישוביות
        public void ChangePrice(double precent)
        {
            this.price += this.price * precent / 100;
        }

        // פעולה לתיאור העצם
        public override string ToString()
        {
            string desc = "";
            desc = "name:" + this.name + "\n";
            desc += "writer:" + this.writer + "\n";
            desc += "pages:" + this.pages + "\n";
            desc += "price:" + this.price + "\n";
            return desc;
        }
    }
}
