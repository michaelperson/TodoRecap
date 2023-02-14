using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.Models
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal static UserEntity MapEntity(SqlDataReader dr)
        {
            return new UserEntity()
            {
                Id = (int)dr["IdUser"],
                Name = (string)dr["Nom"],
            };
        }

    }
}
