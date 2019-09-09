using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAL
{
    public class DALUsuario
    {
        private string connectionString = "";

        public DALUsuario()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PubsConnectionString"].ConnectionString;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Usuario> Select(string usuario)
        {
            // Variavel para armazenar um livro
            Modelo.Usuario aUsuario;
            // Cria Lista Vazia
            List<Modelo.Usuario> aListUsuario = new List<Modelo.Usuario>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Usuario Where Usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario",usuario);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aUsuario = new Modelo.Usuario(
                        Convert.ToInt16(dr["idusuario"].ToString()),
                        dr["usuario"].ToString(),
                        dr["senha"].ToString(),
                         Convert.ToInt16(dr["idusuarioperfil"].ToString())
                        );
                    // Adiciona o livro lido à lista
                    aListUsuario.Add(aUsuario);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListUsuario;
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Usuario obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE idusuario = @idusuario", conn);
            cmd.Parameters.AddWithValue("@idusuario", obj.idusuario);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Usuario obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (usuario, senha, idusuarioperfil) VALUES(@usuario, @senha, @idusuarioperfil)", conn);
           /// cmd.Parameters.AddWithValue("@idusuario", obj.idusuario);
            cmd.Parameters.AddWithValue("@usuario", obj.usuario);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@idusuarioperfil", obj.idusuarioperfil);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Usuario obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Usuario SET usuario = @usuario, senha = @senha, idusuarioperfil = @idusuarioperfil WHERE idusuario = @idusuario", conn);
            cmd.Parameters.AddWithValue("@idusuario", obj.idusuario);
            cmd.Parameters.AddWithValue("@usuario", obj.usuario);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@idusuarioperfil", obj.idusuarioperfil);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
    }
}