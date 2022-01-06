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
    public class MoradorBanco
    {
        public bool incluir(Morador MoradorIncluir)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "INSERT INTO Moradores (Nome, IdApartamento, Nascimento, Telefone, CPF, Email) VALUES ('" + MoradorIncluir.Nome + "', " + MoradorIncluir.IdApartamento + ", " + MoradorIncluir.Nascimento + ", " + MoradorIncluir.telefone + ", " + MoradorIncluir.CPF + ", " + MoradorIncluir.Email + ")";
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
                        comm.CommandText = "DELETE FROM Moradores WHERE Id = " + Id;
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
        

        public Morador consultar(int Id)
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
                    Morador morador = new Morador();
                    while (myReader.Read())
                    {
                        morador.Id = Convert.ToInt32(myReader["Id"]);
                        morador.Nome = Convert.ToString(myReader["Nome"]);
                        morador.telefone = Convert.ToString(myReader["telefone"]);
                        morador.Nascimento = Convert.ToString(myReader["Nascimento"]);
                        morador.Email = Convert.ToString(myReader["Email"]);
                        morador.CPF = Convert.ToString(myReader["CPF"]);
                        morador.IdApartamento = Convert.ToInt32(myReader["IdApartamento"]);
                        //Console.WriteLine(myReader["FoodName"] + " " + myReader["FoodType"]);
                    }
                    return morador;
                }
            }
        }

        public List<Morador> consultarTodos()
        {
            string path = Directory.GetCurrentDirectory();
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
            {
                connection.Open();

                using (SQLiteCommand selectCMD = connection.CreateCommand())
                {
                    selectCMD.CommandText = "SELECT * FROM Bloco ";
                    selectCMD.CommandType = CommandType.Text;
                    SQLiteDataReader myReader = selectCMD.ExecuteReader();
                    Morador morador = new Morador();
                    List<Morador> moradores = new List<Morador>();
                    while (myReader.Read())
                    {
                        morador.Id = Convert.ToInt32(myReader["Id"]);
                        morador.Nome = Convert.ToString(myReader["Nome"]);
                        morador.telefone = Convert.ToString(myReader["telefone"]);
                        morador.Nascimento = Convert.ToString(myReader["Nascimento"]);
                        morador.Email = Convert.ToString(myReader["Email"]);
                        morador.CPF = Convert.ToString(myReader["CPF"]);
                        morador.IdApartamento = Convert.ToInt32(myReader["IdApartamento"]);
                        moradores.Add(morador);
                        //Console.WriteLine(myReader["FoodName"] + " " + myReader["FoodType"]);
                    }
                    return moradores;
                }
            }
        }
        public bool atualiza(Morador AP)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "UPDATE Condominios SET Nome='" + AP.Nome + "', IdApartamento=" + AP.IdApartamento + "Telefone='" + AP.telefone + "' CPF='" + AP.CPF + "Email='" + AP.Email + "''WHERE Id=" + AP.Id;
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

        //public List<Morador> consultaTodos()
        //{

       //q }
    }
}
