﻿using PizzariaDoZe.Ingredientes;
using PizzariaDoZe.Sabores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            ListaFuncionarios funcionarios = new ListaFuncionarios();
            funcionarios.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            ListaClientes clientes = new ListaClientes();
            clientes.Show();
        }

        private void buttonIngredientes_Click(object sender, EventArgs e)
        {
            ListaIngredientes ingredientes = new ListaIngredientes();
            ingredientes.Show();
        }

        private void buttonSabores_Click(object sender, EventArgs e)
        {
            ListaSabores sabores = new ListaSabores();
            sabores.Show();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            ListaProdutos produtos = new ListaProdutos();
            produtos.Show();
        }

        private void buttonValores_Click(object sender, EventArgs e)
        {
            ListaValores valores = new ListaValores();
            valores.Show();
        }


        private void buttonEnderecos_Click(object sender, EventArgs e)
        {
            Enderecos enderecos = new Enderecos();
            enderecos.Show();
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            ListaPedidos pedidos = new ListaPedidos(); 
            pedidos.Show();
        }
        private void buttonSair_Click(object sender, EventArgs e) => Application.Exit();
    }
}
