using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public MenuItem(int id, string title, string description, decimal price)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Id + ". " + this.Title + " (" + this.Description + ") - " + this.Price;
        }
    }
   
}
