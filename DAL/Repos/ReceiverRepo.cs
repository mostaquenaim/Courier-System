using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReceiverRepo : Repo, IRepo<Receiver>
    {
        public Receiver Create(Receiver obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Receiver> Read()
        {
            throw new NotImplementedException();
        }

        public Receiver Read(int id)
        {
            throw new NotImplementedException();
        }

        public Receiver Update(Receiver obj)
        {
            throw new NotImplementedException();
        }
    }
}
