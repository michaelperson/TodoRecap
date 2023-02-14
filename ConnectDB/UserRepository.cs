using ConnectDB.Interfaces;
using ConnectDB.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public class UserRepository : IRepository<UserEntity, int>
    {
        private readonly string _cnstr;
        public UserRepository(string connectionString)
        {
            _cnstr= connectionString;
        }

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
            List<UserEntity> listeDeUsers = new List<UserEntity>();
            string query = "SELECT [IdUser]   ,[Nom]  FROM [dbo].[Users]";
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
                        listeDeUsers.Add(UserEntity.MapEntity(reader));
                    }

                    //4 - fermeture 
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(ex.Message);
                }
            }
            return listeDeUsers;
        }

        public UserEntity GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
