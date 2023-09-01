using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer>
    {
        public Customer Create(Customer obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Read()
        {
            throw new NotImplementedException();
        }

        public Customer Read(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
