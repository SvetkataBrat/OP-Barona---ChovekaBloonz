using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisiness_Layer
{
    public class Auto
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string brand { get; set; }

        public double price { get; set; }

        public int horsepower { get; set; }

        [ForeignKey]
        public int salonID { get; set; }

        [ForeignKey]
        public int customerID { get; set; }

        private Auto()
        {

        }

        public Auto(int id, string brand, double price, int horsepower, int salonID, int customerID)
        {
            this.id = id;
            this.brand = brand;
            this.price = price;
            this.horsepower = horsepower;
            this.salonID = salonID;
            this.customerID = customerID;
        }
    }
}
