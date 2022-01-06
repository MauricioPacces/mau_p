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
    public class ApartamentoBanco
    {

        public bool incluir(Apartamento apartamentoincluir)
        {

            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "INSERT INTO Apartamentos (IdBloco, Numero, Andar) VALUES (" + apartamentoincluir.IdBloco + ", '" + apartamentoincluir.numero + "', '" + apartamentoincluir.andar + "')";
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
                        comm.CommandText = "DELETE FROM Apartamentos WHERE Id = " + Id;
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
        public Apartamento consultar(int Id)
        {
            string path = Directory.GetCurrentDirectory();
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
            {
                connection.Open();

                using (SQLiteCommand selectCMD = connection.CreateCommand())
                {
                    selectCMD.CommandText = "SELECT * FROM Apartamentos Where Id=" + Id;
                    selectCMD.CommandType = CommandType.Text;
                    SQLiteDataReader myReader = selectCMD.ExecuteReader();
                    Apartamento apartamento = new Apartamento();
                    while (myReader.Read())
                    {
                        apartamento.Id = Convert.ToInt32(myReader["Id"]);
                        apartamento.IdBloco = Convert.ToInt32(myReader["IdBloco"]);
                        apartamento.numero = Convert.ToString(myReader["Numero"]);
                        apartamento.andar = Convert.ToString(myReader["Andar"]);
                        //Console.WriteLine(myReader["FoodName"] + " " + myReader["FoodType"]);
                    }
                    return apartamento;
                }
            }
        }

        public List<Apartamento> consultarTodos()
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
                    Apartamento apartamento = new Apartamento();
                    List<Apartamento> APs = new List<Apartamento>();
                    while (myReader.Read())
                    {
                        //while ()
                        //{
                            apartamento.Id = Convert.ToInt32(myReader["Id"]);
                            apartamento.IdBloco = Convert.ToInt32(myReader["IdBloco"]);
                            apartamento.numero = Convert.ToString(myReader["Numero"]);
                            apartamento.andar = Convert.ToString(myReader["Andar"]);
                        APs.Add(apartamento);

                        //}
                        //Console.WriteLine(myReader["FoodName"] + " " + myReader["FoodType"]);
                    }
                    return APs;
                }
            }
        }
        public bool atualiza(Apartamento AP)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                using (var conn = new System.Data.SQLite.SQLiteConnection(@"Data Source=" + path + @"\BancoCondominios.db"))
                {
                    conn.Open();

                    using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        comm.CommandText = "UPDATE Apartamentos SET IdBloco= " + AP.IdBloco + ", Numero=" + AP.numero + ", Andar=" + AP.andar + " WHERE Id=" + AP.Id;
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
