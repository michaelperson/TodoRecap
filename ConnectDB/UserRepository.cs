using ConnectDB.Interfaces;
using ConnectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    internal class UserRepository : IRepository<UserEntity, int>
    {
        public bool Create(UserEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetOne()
        {
            throw new NotImplementedException();
        }

        public bool Update(UserEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
