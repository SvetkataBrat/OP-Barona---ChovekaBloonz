using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Address { get; set; }

        private Customer()
        {

        }

        public Customer(int id_, string firstName_, string lastName_, string address_)
        {
            Id = id_;
            FirstName = firstName_;
            LastName = lastName_;
            Address = address_;
        }
    }
}
