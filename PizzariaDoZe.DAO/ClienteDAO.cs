using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }



        public Cliente(string nome, string cpf, string email, string telefone, int id = 0) 
        {
            ID = id;
            Nome = nome; 
            CPF = cpf; 
            Email = email; 
            Telefone = telefone;
        }

    }
    internal class ClienteDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ClienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }


    }
}
