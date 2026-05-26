using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ServicehubHubClas;
using System.Data;

namespace ServiceHubClass
{
    public class Categoria
    {
        //Atributos (Campos)
        private int id;
        private string? nome;
        private string? sigla;

        //Getters e Setters (Propriedades)
        public int Id { get => id; set => id = value; }
        public string? Nome { get => nome; set => nome = value; }
        public string? Sigla { get => sigla; set => sigla = value; }

        //Construtores 
        public Categoria()
        {
            Id = 0;
        }
        public Categoria(string? nome, string? sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }

        public Categoria(int id, string? nome, string? sigla)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
        }

        //Métodos (Funções) - inserir, atualizar, listar, obterPorId(id), excluir(id)
        public void Inserir()
        {
            var cmd = Banco.Abrir();//Abre conexão com banco de dados
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;//Passa o tipo como Procedure
                cmd.CommandText = "sp_categoria_insert";//Passa o nome da Procedure do banco de dados 
                cmd.Parameters.AddWithValue("spnome", Nome);//Passa os parametros para a procedure do banco de dados
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();


            }
        }
        public static Categoria ObterPorId(int id)
        {
            Categoria cat = new Categoria();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;//Passa o tipo como Texto
            cmd.CommandText = $"select * from categorias where id = {id}";//Passa o texto esperado (comando sql)
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cat = new Categoria(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));//Cria um objeto do tipo Categoria passando como parametro o DataReader com suas respectivas posições
            }
            dr.Close();//Fecha o DataReader
            cmd.Connection.Close();//Fecha Conexão com o banco de dados
            return cat;
        }

    }
}
