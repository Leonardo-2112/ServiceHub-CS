using ServicehubHubClas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceHubClass
{
    public class Produto
    {
        //Getters e Setters
        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[] Imagem { get; set; }
        public DateTime DataCad { get; set; }
        public bool Descontinuado { get; set; }

        //Construtores
        public Produto()
        {

        }
        //Construtor Procedure para Insert
        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }

        //Construtor Procedure para Update
        public Produto(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }

        //Construtor Completo
        public Produto(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[] imagem, DateTime dataCad, bool descontinuado)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
            Descontinuado = descontinuado;
        }

        //Métodos (Inserir, BuscarPorId(id), ObterLista(texto=""), Atualizar)
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;//Define o tipo do comando SQL como Procedure
            cmd.CommandText = "sp_produto_insert";//Passa qual procedure do banco de dados será chamada         

            //Passa Valores para a Procedure
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);    
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;//Define o tipo do comando SQL como Procedure
            cmd.CommandText = "sp_produto_update";//Passa qual procedure do banco de dados será chamada         

            //Passa Valores para a Procedure
            cmd.Parameters.AddWithValue("spids", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }
            cmd.Connection.Close();
            return atualizado;
        }

        public static Produto ObterPorId(int id)
        {
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;//Define o tipo do comando SQL como Texto
            cmd.CommandText = $"select * from produtos where id {id}";//Passa comando sql para executar no banco de dados
            var dr = cmd.ExecuteReader();//Lê e armazena na variavel oq retornou da consulta SQL
            if (dr.Read()) //dr.Read retorna verdadeiro caso tenha linhas afetadas
            {
                //Instancia objeto passando parametros para o construtor
                
                produto = new (dr.GetInt32(0), 
                    dr.GetString(1), 
                    dr.GetString(2), 
                    dr.GetDouble(3), 
                    dr.GetString(4), 
                    Categoria.ObterPorId(dr.GetInt32(5)), //(na posição 5 precisamos do id da categoria, chamamos o método ObterPorId que retorna um objeto do tipo Categoria que é esperado pelo construtor)
                    dr.GetDouble(6), 
                    dr.GetDouble(7), 
                    (byte[])dr.GetValue(8),
                    dr.GetDateTime(9), 
                    dr.GetBoolean(10));
            }
            return produto;

        }

        public static List<Produto> ObterLista()
        {
            List<Produto> produtos = new();//vazio
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;//Define o tipo do comando SQL como Texto
            cmd.CommandText = $"select * from produtos order by descricao";//Passa comando sql para executar no banco de dados
            var dr = cmd.ExecuteReader();//Lê e armazena na variavel oq retornou da consulta SQL
            while (dr.Read()) //dr.Read retorna verdadeiro caso tenha linhas afetadas
            {
                //Instancia objeto passando parametros para o construtor
                produtos.Add(new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)), //(na posição 5 precisamos do id da categoria, chamamos o método ObterPorId que retorna um objeto do tipo Categoria que é esperado pelo construtor)
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9),
                    dr.GetBoolean(10)
                    )
                );

            }
            dr.Close();
            cmd.Connection.Close();
            return produtos;

        }

    }
}
