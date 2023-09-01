using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ShipmentRepo : Repo, IRepo<Shipment>
    {
        public Shipment Create(Shipment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shipment> Read()
        {
            throw new NotImplementedException();
        }

        public Shipment Read(int id)
        {
            throw new NotImplementedException();
        }

        public Shipment Update(Shipment obj)
        {
            throw new NotImplementedException();
        }
    }
}
