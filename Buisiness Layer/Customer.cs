using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisiness_Layer
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        public List<Auto> Cars { get; set; }

        private Customer()
        {
            this.Cars = new List<Auto>();
        }
        
        public Customer(string fName_, string lName_, int age_, params Auto[] cars_)
        {
            this.FirstName = fName_;
            this.LastName = lName_;
            this.Age = age_;
            this.Cars = cars_.ToList();
        }
    }
}
