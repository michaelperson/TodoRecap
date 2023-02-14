using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDB.Models;
using Microsoft.Data.SqlClient;

namespace ConnectDB.Mappers
{
    internal static class Mapper
    {
        internal static ToDoEntity MapEntity(this ToDoEntity e, SqlDataReader reader)
         {

            e.Id = Convert.ToInt32(reader["Id"]);
            e.Title = reader["Title"].ToString()!;
            e.Done = (bool)reader["Done"];
            return e;


        }

        internal static UserEntity MapEntity(this UserEntity e, SqlDataReader reader)
        {
            e.Id = Convert.ToInt32(reader["Id"]);
            e.Name = reader["Name"].ToString()!; 
            return e;
        }
    }
}
