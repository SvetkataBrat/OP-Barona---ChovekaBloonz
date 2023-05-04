using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisiness_Layer
{
    public class AutoSalon
    {
        [Key]
        public int SalonId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        public List<Auto> Cars { get; set; }

        private AutoSalon() 
        {
            Cars = new List<Auto>();
        }

        public AutoSalon(int id, string name, string adress)
        {
            id = SalonId;
            Name = name;
            Adress = adress;
        }
    }
}
