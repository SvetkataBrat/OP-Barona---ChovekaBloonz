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

        ColetoContext dbContext;
        public CustomerContext(ColetoContext dbContext_)
        {
            this.dbContext = dbContext_;
        }

        public void Create(Customer item)
        {
            try
            {
                dbContext.Customers.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Customer customerFromDb = Read(key);
                dbContext.Customers.Remove(customerFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer Read(int key)
        {
            try
            {
                return dbContext.Customers.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Customer> ReadAll()
        {
            try
            {
                return dbContext.Customers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Customer item)
        {
            try
            {
                dbContext.Customers.Update(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
