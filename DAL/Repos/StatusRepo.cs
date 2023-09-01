using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StatusRepo : Repo, IRepo<Status>
    {
        public Status Create(Status obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Status> Read()
        {
            throw new NotImplementedException();
        }

        public Status Read(int id)
        {
            throw new NotImplementedException();
        }

        public Status Update(Status obj)
        {
            throw new NotImplementedException();
        }
    }
}
