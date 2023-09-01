using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ShipperRepo : Repo, IRepo<Shipper>
    {
        public Shipper Create(Shipper obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shipper> Read()
        {
            throw new NotImplementedException();
        }

        public Shipper Read(int id)
        {
            throw new NotImplementedException();
        }

        public Shipper Update(Shipper obj)
        {
            throw new NotImplementedException();
        }
    }
}
