using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Pedido
    {
        public Pedido(int id = 0, int IdCliente = 0, int IdFuncionario = 0, string status = "", bool entrega = false, bool pago = false, decimal valorTotal = 0, List<Pizza> listaPizzas = null!, List<Produto> listaProdutos = null!)
        {
            this.ID = id;
            this.IDCliente = IdCliente;
            this.IDFuncionario = IdFuncionario;
            this.Status = status;
            this.Entrega = entrega;
            this.Pago = pago;
            this.ListaPizzas = listaPizzas;
            this.ListaProdutos = listaProdutos;
            this.ValorTotal = valorTotal;
            this.DataPedido = DateTime.Now;
        }
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public int IDFuncionario { get; set; }
        public string Status { get; set; }
        public bool Entrega { get; set; }
        public bool Pago { get; set; }
        public List<Pizza> ListaPizzas { get; set; }
        public List<Produto> ListaProdutos { get; set; }
        public decimal ValorTotal { get; private set; }
        public DateTime DataPedido { get; set; }

        internal void AtribuirValorTotal(decimal valor) => this.ValorTotal = valor;
        
    } 
    public class PedidoDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }

        public PedidoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            conexao.Open();
            ConverterObjetoParaSql(pedido, comando);
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
                string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
                //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
                comando.CommandText = @"INSERT INTO tb_pedidos (cliente_id, funcionario_id, status, entrega, pago, valor_total, data_pedido) VALUES (@cliente_id, @funcionario_id, @status, @entrega, @pago, @total, @data_pedido);" + auxSQL_ID;
                //executa o comando no banco de dados e captura o ID gerado
                var IdPedidoGerado = comando.ExecuteScalar();
                // realiza um loop para pegar todos os ingredientes selecionados

                foreach (Pizza pizza in pedido.ListaPizzas)
                {
                    // salvar os ingredientes do sabor
                    comando.CommandText = @"INSERT INTO lista_pizzas(pedido_id, pizza_id) VALUES (" + pedido.ID + "," + pizza.ID + ")";
                    //Executa o script na conexão
                    _ = comando.ExecuteNonQuery();
                }
                foreach (Produto produto in pedido.ListaProdutos)
                {
                    // salvar os ingredientes do sabor
                    comando.CommandText = @"INSERT INTO lista_produtos(pedido_id, produto_id) VALUES (" + pedido.ID + "," + produto.ID + ")";
                    //Executa o script na conexão
                    _ = comando.ExecuteNonQuery();
                }

                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();

                return Convert.ToInt32(IdPedidoGerado);
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();

                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }
        public DataTable Buscar(Pedido pedido)
        {
            var auxSqlFiltro = "";

            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
            conexao.Open();
            if (pedido.ID > 0)
            {
                auxSqlFiltro = "WHERE pe.id_pedido = " + pedido.ID + " ";
            }
            comando.CommandText = @" " + 
                                    "SELECT pe.id_pedido AS ID, " +
                                    "cc.nome_cliente AS Cliente, " +
                                    "f.nome_funcionario AS Funcionario, " +
                                    "pe.valor_total AS 'Valor Total', " +
                                    "pe.status AS Status, " +
                                    "pe.entrega AS Entregar, " +
                                    "pe.pago AS Pago, " +
                                    "pe.data_pedido AS 'Realizado em:' " +
                                    //     "(SELECT GROUP_CONCAT(s.descricao_sabor SEPARATOR ', ')" +
                                    //     "FROM tb_sabores s, sabores_pizza sp, tb_pizza pz " +
                                    //     "WHERE s.id_sabor = sp.sabores_id AND pz.id_pizza = sp.pizza_id ) AS Sabores," +
                                    //     "(select group_concat(CONCAT(p.descricao_produto,' ', p.medida_unitaria, ' ml/g') separator ', ')" +
                                    //     "FROM cad_produtos AS p " +
                                    //     "INNER JOIN tb_pedidos pe on lp.pedido_id = pe.id_pedido " +
                                    //      auxSqlFiltro + ") AS Produtos " +
                                    "FROM tb_pedidos pe " +
                                    "INNER JOIN lista_produtos lp on p.id_produto = lp.produto_id " +
                                    "INNER JOIN tb_clientes cc on cc.id_cliente = pe.cliente_id " +
                                    "INNER JOIN tb_enderecos AS e ON e.id_endereco = cc.endereco_id " +
                                    "INNER JOIN cad_cidades AS c ON c.id_cidade = e.cidade_id " +
                                    "INNER JOIN cad_uf AS u ON u.id_uf = c.uf_id " +
                                    "INNER JOIN cad_paises AS p ON p.id_pais = u.pais_id " +
                                    "INNER JOIN tb_funcionarios f  on f.id_funcionario = pe.funcionario_id " +
                                    auxSqlFiltro + 
                                    "ORDER BY pe.data_pedido desc;";

            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
        public DataTable BuscarProdutosPorPedido(Pedido pedido)
        {
            var auxSqlFiltro = "";

            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
            conexao.Open();
            if (pedido.ID > 0)
            {
                auxSqlFiltro = "WHERE pe.id_pedido = " + pedido.ID + " ";
            }
            comando.CommandText = @" " +
                                    "SELECT CONCAT(p.descricao_produto, ' ' p.medida_unitaria) " +
                                    "FROM cad_produtos AS p " +
                                    "INNER JOIN lista_produtos lp on p.id_produto = lp.produto_id " +
                                    "INNER JOIN tb_pedidos pe on lp.pedido_id = pe.id_pedido " +
                                    auxSqlFiltro +
                                    "ORDER BY p.descricao_produto;";

            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public DataTable BuscarPizzasPorPedido(Pedido pedido)
        {
            var auxSqlFiltro = "";

            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
            conexao.Open();
            if (pedido.ID > 0)
            {
                auxSqlFiltro = "WHERE pe.id_pedido = " + pedido.ID + " ";
            }
            comando.CommandText = @" " +
                                    "SELECT pz.id_pizza AS ID, (select group_concat(s.descricao_sabor SEPARATOR ', ')" +
                                    "FROM tb_sabores s, sabores_pizza sp, tb_pizza pz " +
                                    "WHERE s.id_sabor = sp.sabores_id AND pz.id_pizza = sp.pizza_id ) AS Sabores, " +
                                    "valor AS Valor, tipo AS 'Tipo Produto',medida_unitaria AS ML " +
                                    "FROM tb_pizza pz " +
                                    "INNER JOIN lista_pizzas lp on pz.id_pizza = lp.pizza_id " +
                                    "INNER JOIN tb_pedidos pe on lp.pedido_id = pe.id_pedido " +
                                    auxSqlFiltro +
                                    "ORDER BY pe.data_pedido desc;";

            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
        public void Editar(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão

            ConverterObjetoParaSql(pedido, comando);
            var IdPedido = comando.CreateParameter(); IdPedido.ParameterName = "@id_pedido"; 
            IdPedido.Value = pedido.ID; comando.Parameters.Add(IdPedido);

            conexao.Open();

            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //realiza o UPDATE
                comando.CommandText = @"UPDATE tb_pedidos SET cliente_id = @cliente_id, funcionario_id = @funcionario_id, " +
                "status = @status, entrega = @entrega, pago = @pago, valor_total = @total, data_pedido = @data_pedido WHERE id_pedido = @id_pedido;";
                //executa o comando no banco de dados e captura o ID gerado
                _ = comando.ExecuteNonQuery();
                //limpa todos os ingredientes do sabor
                comando.CommandText = @"DELETE FROM lista_pizzas WHERE pedido_id = " + pedido.ID + ";";
                comando.CommandText = @"DELETE FROM lista_produtos WHERE pedido_id = " + pedido.ID + ";";
                _ = comando.ExecuteNonQuery();
                // realiza um loop para adicionar os ingredientes do sabor
                foreach (Pizza pizza in pedido.ListaPizzas)
                {
                    // salvar os ingredientes do sabor
                    comando.CommandText = @"INSERT INTO lista_pizzas(pedido_id, pizza_id) VALUES (" + pedido.ID + "," + pizza.ID + ")";
                    //Executa o script na conexão
                    _ = comando.ExecuteNonQuery();
                }
                foreach (Produto produto in pedido.ListaProdutos)
                {
                    // salvar os ingredientes do sabor
                    comando.CommandText = @"INSERT INTO lista_produtos(pedido_id, produto_id) VALUES (" + pedido.ID + "," + produto.ID + ")";
                    //Executa o script na conexão
                    _ = comando.ExecuteNonQuery();
                }
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            ConverterObjetoParaSql(pedido, comando);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                comando.CommandText = @"DELETE FROM cad_pagamentos WHERE pedido_id = @id;";
                _ = comando.ExecuteNonQuery();

                comando.CommandText = @"DELETE FROM lista_produtos WHERE pedido_id = @id;";
                _ = comando.ExecuteNonQuery();

                comando.CommandText = @"DELETE FROM lista_pizzas WHERE pedido_id = @id;";
                _ = comando.ExecuteNonQuery();

                comando.CommandText = @"DELETE FROM tb_pedidos WHERE id_pedido = @id;";
                _ = comando.ExecuteNonQuery();
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }

        private void ConverterObjetoParaSql(Pedido pedido, DbCommand comando)
        {
            var Id = comando.CreateParameter(); Id.ParameterName = "@cliente_id"; Id.Value = pedido.ID; comando.Parameters.Add(Id);
            var IdCliente = comando.CreateParameter(); IdCliente.ParameterName = "@cliente_id"; IdCliente.Value = pedido.IDCliente; comando.Parameters.Add(IdCliente);
            var IdFuncionario = comando.CreateParameter(); IdFuncionario.ParameterName = "@funcionario_id"; IdFuncionario.Value = pedido.IDFuncionario; comando.Parameters.Add(IdFuncionario);
            var Status = comando.CreateParameter(); Status.ParameterName = "@status"; Status.Value = pedido.Status; comando.Parameters.Add(Status);
            var Entrega = comando.CreateParameter(); Entrega.ParameterName = "@entrega"; Entrega.Value = pedido.Entrega; comando.Parameters.Add(Entrega);
            var Pago = comando.CreateParameter(); Pago.ParameterName = "@entrega"; Pago.Value = pedido.Pago; comando.Parameters.Add(Pago);
            var ValorTotal = comando.CreateParameter(); ValorTotal.ParameterName = "@valor_total"; ValorTotal.Value = pedido.ValorTotal; comando.Parameters.Add(ValorTotal);
            var DataPedido = comando.CreateParameter(); DataPedido.ParameterName = "@data_pedido"; DataPedido.Value = pedido.DataPedido; comando.Parameters.Add(DataPedido);
        }
        // private Pedido ConverterSqlParaObjeto(DbDataReader leitor)
        // {
        //     var pedido = new Pedido();
        //     pedido.ID = int.Parse(leitor["id_pedido"].ToString()!);
        //     pedido.IDCliente = int.Parse(leitor["cliente_id"].ToString()!);
        //     pedido.IDFuncionario = int.Parse(leitor["funcionario_id"].ToString()!);
        //     pedido.Status = leitor["status"].ToString()!;
        //     pedido.Entrega = bool.Parse(leitor["entrega"].ToString()!);
        //     pedido.Pago = bool.Parse(leitor["pago"].ToString()!);
        //     pedido.DataPedido = Convert.ToDateTime(leitor["data_pedido"].ToString()!);
        //     pedido.AtribuirValorTotal(decimal.Parse(leitor["valor_total"].ToString()!));

        //     return pedido;
        // }
    }
}
