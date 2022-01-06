using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class BlocoBanco
    {
        public bool incluir(Bloco Bloconcluir)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "INSERT INTO Bloco (Nome, IdCondominio) VALUES ('" + Bloconcluir.Nome + "', " + Bloconcluir.IdCondominios + ")";
                        comm.ExecuteNonQuery();
                    }

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool excluir(int Id)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "DELETE FROM Bloco WHERE Id = "+ Id;
                        comm.ExecuteNonQuery();
                    }

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public Bloco consultar(int Id)
        {
            string path = Directory.GetCurrentDirectory();
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
            {
                connection.Open();

                using (SQLiteCommand selectCMD = connection.CreateCommand())
                {
                    selectCMD.CommandText = "SELECT * FROM Bloco Where Id=" + Id;
                    selectCMD.CommandType = CommandType.Text;
                    SQLiteDataReader myReader = selectCMD.ExecuteReader();
                    Bloco bloco = new Bloco();
                    while (myReader.Read())
                    {
                        bloco.Nome = Convert.ToString(myReader["Nome"]);
                        bloco.IdCondominios = Convert.ToInt32(myReader["IdCondominio"]);
                        bloco.Id = Convert.ToInt32(myReader["Id"]);
                        //Console.WriteLine(myReader["FoodName"] + " " + myReader["FoodType"]);
                    }
                    return bloco;
                }
            }
        }

        public List<Bloco> consultarTodos()
        {
            string path = Directory.GetCurrentDirectory();
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
            {
                connection.Open();

                using (SQLiteCommand selectCMD = connection.CreateCommand())
                {
                    selectCMD.CommandText = "SELECT * FROM Bloco";
                    selectCMD.CommandType = CommandType.Text;
                    SQLiteDataReader myReader = selectCMD.ExecuteReader();
                    Bloco bloco = new Bloco();
                    List<Bloco> blocos = new List<Bloco>();
                    while (myReader.Read())
                    {
                        bloco.Nome = Convert.ToString(myReader["Nome"]);
                        bloco.IdCondominios = Convert.ToInt32(myReader["IdCondominio"]);
                        bloco.Id = Convert.ToInt32(myReader["Id"]);
                        blocos.Add(bloco);
                    }
                    return blocos;
                }
            }
        }

        public bool atualiza(Bloco AP)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "UPDATE Bloco SET IdCondominio='" + AP.IdCondominios + "', Nome='" + AP.Nome + "' WHERE Id=" + AP.Id;
                        comm.ExecuteNonQuery();
                    }

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
