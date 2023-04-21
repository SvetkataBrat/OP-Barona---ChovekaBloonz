using Buisiness_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    internal class CustomerContext : IDb<Customer, int>
    {
        public void Create(Customer item)
        {
            
        }

        public void Delete(int key)
        {
            
        }

        public Customer Read(int key, bool useNavigationalProperties = false)
        {
            
        }

        public IEnumerable<Customer> ReadAll(bool useNavigationalProperties = false)
        {
            
        }

        public void Update(Customer item, bool useNavigationalProperties = false)
        {
            
        }
    }
}
