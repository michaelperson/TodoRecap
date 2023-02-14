using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.Models
{
    public class ToDoEntity
    {
        
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Title { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public bool Done { get; set; }


        internal static ToDoEntity MapEntity(SqlDataReader reader)
        {
            return new ToDoEntity()
            {
                Id = Convert.ToInt32(reader["Id"]),
                Title = reader["Title"].ToString()!,
                Done = (bool)reader["Done"]
            };
        }

        internal  List<SqlParameter> MapTable()
        {
             List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("Id", this.Id));
            list.Add(new SqlParameter("Title", this.Title));
            list.Add(new SqlParameter("Done", this.Done));
            return list;
        }

    }
}
