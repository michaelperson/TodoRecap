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
        internal static ToDoEntity MapEntity(this SqlDataReader reader)
         {  
            return  new ToDoEntity()
            {
                Id = Convert.ToInt32(reader["Id"]),
                Title = reader["Title"].ToString()!,
                Done = (bool)reader["Done"]
            };



        }
    }
}
