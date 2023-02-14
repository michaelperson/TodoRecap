using ConnectDB.Interfaces;
using ConnectDB.Mappers;
using ConnectDB.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ConnectDB
{
    public class TodoRepository : IRepository<ToDoEntity,int>
    {
        private readonly string _cnstr;
        public TodoRepository(string cnstr )
        {
            _cnstr = cnstr;
        }
        public List<ToDoEntity> GetAll()
        {
            List<ToDoEntity> listeDeToDo = new List<ToDoEntity>();
            string query = "Select Id, Title, Done from ToDo";
            //1- Connexion
            using (SqlConnection sqlConnection = new SqlConnection(_cnstr))
            {
                try
                {
                    sqlConnection.Open();
                    //2- Commande
                    //2.1 initialisation
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    //2.2 Ajout du query
                    cmd.CommandText = query;

                    //3- Exécuter la commande
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listeDeToDo.Add(reader.MapEntity());
                    }

                    //4 - fermeture 
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(ex.Message);
                }
            }
            return listeDeToDo;
        }
        public ToDoEntity GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(ToDoEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(ToDoEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}