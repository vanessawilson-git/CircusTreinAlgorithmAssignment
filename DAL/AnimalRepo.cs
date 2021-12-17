using System;
using System.Collections.Generic;
using DTOAndInterfaces;
using DTOAndInterfaces.Interfaces;
using Logic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace DAL
{
    public class AnimalRepo : IAnimalRepo
    { 
        IMySQLConnection connClass;
        
        //Again due to dependecy injection, my code will talk to an interface eventhough they will get an actuall connection class
        public AnimalRepo(IMySQLConnection connectionClass)
        {
            connClass = connectionClass;
        }

        public void CreateAnimal(AnimalDTO animal)
        {
            string query = "INSERT INTO animals(AnimalName, Diet, Size, UserId) VALUES (@Name, @Diet, @Size, @UserId );"; //    
            using (connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, connClass.GetConnection()))
                {
                    //This makes sure noone can mess with the query. This basically says when you see this @Thing you mean the Dto.thing
                    sqlCommand.Parameters.AddWithValue("@Name", animal.Name);
                    sqlCommand.Parameters.AddWithValue("@Diet", animal.Diet);
                    sqlCommand.Parameters.AddWithValue("@Size", animal.Size);
                    sqlCommand.Parameters.AddWithValue("@userid", animal.OwnerId);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }


        public void UpdateAnimal(AnimalDTO animal)
        {
            string query = "UPDATE animals SET AnimalName = @Name, Diet = @Diet, Size = @Size WHERE AnimalId = @AnimalId;";
            using (connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, connClass.GetConnection()))
                {
                    //This makes sure noone can mess with the query. This basically says when you see this @Thing you mean the Dto.thing
                    sqlCommand.Parameters.AddWithValue("@Name", animal.Name);
                    sqlCommand.Parameters.AddWithValue("@Diet", animal.Diet);
                    sqlCommand.Parameters.AddWithValue("@Size", animal.Size);
                    sqlCommand.Parameters.AddWithValue("@AnimalId", animal.Id);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAnimal(int animalId)
        {
            string query = "DELETE FROM animals WHERE AnimalId = @AnimalId;";
            using (connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, connClass.GetConnection()))
                {
                    //This makes sure noone can mess with the query. This basically says when you see this @Thing you mean the Dto.thing
                    sqlCommand.Parameters.AddWithValue("@AnimalId", animalId);
                   
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public List<AnimalDTO> GetAnimalsByUserId(int accountId)
        {
            List<AnimalDTO> animalList = new List<AnimalDTO>();
             
            string query = "SELECT * FROM circustreindb.animals WHERE UserId = @UserId;";
            using(connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, connClass.GetConnection()))
                {
                    //This makes sure noone can mess with the query. This basically says when you see this @Thing you mean the Dto.thing
                    sqlCommand.Parameters.AddWithValue("@UserId", accountId);
                    
                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        AnimalDTO animal = new AnimalDTO()
                        {
                            Name = (string) reader["AnimalName"],
                            Diet = (int) reader["Diet"],
                            Size = (int) reader["Size"],
                            Id = (int) reader["AnimalId"],
                            OwnerId = (int) reader["UserId"]
                        };
                        animalList.Add(animal);
                    }
                }
            }

            return animalList;
        }

        public AnimalDTO GetAnimalId(int animalId)
        {
            AnimalDTO animal = new AnimalDTO();
            string query = "SELECT * FROM animals WHERE AnimalId = @AnimalId;";
            using (connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, connClass.GetConnection()))
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", animalId);

                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        animal.Name = (string) reader["AnimalName"];
                        animal.Diet = (int) reader["Diet"];
                        animal.Size = (int) reader["Size"];
                        animal.Id = (int) reader["AnimalId"];
                        animal.OwnerId = (int) reader["UserId"];

                    }
                }
            }

            return animal;
        }
    }
}


