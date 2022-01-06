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
    public class CondominioBanco
    {
        public bool incluir(Condominios Condominiosincluir)
        {

            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "INSERT INTO Condominios (Nome, Telefone, EmailSindico) VALUES ('" + Condominiosincluir.Nome + ", " + Condominiosincluir.Telefone + ", " + Condominiosincluir.EmailSindico + ")";
                        comm.ExecuteNonQuery();
                    }

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
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
                        comm.CommandText = "DELETE FROM Condominios WHERE Id = " + Id;
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
        public Condominios consultar(int id)
        {
            string path = Directory.GetCurrentDirectory();
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
            {
                connection.Open();

                using (SQLiteCommand selectCMD = connection.CreateCommand())
                {
                    selectCMD.CommandText = "SELECT * FROM Bloco Where Id=" + id;
                    selectCMD.CommandType = CommandType.Text;
                    SQLiteDataReader myReader = selectCMD.ExecuteReader();
                    Condominios condominios = new Condominios();
                    while (myReader.Read())
                    {
                        condominios.Id = Convert.ToInt32(myReader["Id"]);
                        condominios.Nome = Convert.ToString(myReader["Nome"]);
                        condominios.Telefone = Convert.ToString(myReader["telefone"]);
                        condominios.EmailSindico = Convert.ToString(myReader["EmailSindico"]);
                        //Console.WriteLine(myReader["FoodName"] + " " + myReader["FoodType"]);
                    }
                    return condominios;
                }
            }
        }

        public List<Condominios> consultarTodos()
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
                    Condominios condominio = new Condominios();
                    List<Condominios> condominios = new List<Condominios>();
                    while (myReader.Read())
                    {
                        condominio.Id = Convert.ToInt32(myReader["Id"]);
                        condominio.Nome = Convert.ToString(myReader["Nome"]);
                        condominio.Telefone = Convert.ToString(myReader["telefone"]);
                        condominio.EmailSindico = Convert.ToString(myReader["EmailSindico"]);
                        condominios.Add(condominio);
                        //Console.WriteLine(myReader["FoodName"] + " " + myReader["FoodType"]);
                    }
                    return condominios;
                }
            }
        }
        public bool atualiza(Condominios AP)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "UPDATE Condominios SET Nome='" + AP.Nome + "', EmailSindico'" + AP.EmailSindico + "', telefone= '" + AP.EmailSindico + "' WHERE Id=" + AP.Id;
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
