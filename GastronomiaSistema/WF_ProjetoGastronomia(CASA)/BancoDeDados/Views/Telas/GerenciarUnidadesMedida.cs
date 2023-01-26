﻿using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarUnidadeMedida : FormBase 
    {
        public GerenciarUnidadeMedida()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listView1))
            {
                btnDeletar.Enabled = true;
                var itemSelecionado = listViewFunc.RetornaItemLinhaSelecionada<UnidadeMedida>(listView1);

                textBoxNomeUnidadeMedida.Text = itemSelecionado.Descricao.ToString();
                textBoxSigla.Text = itemSelecionado.Sigla.ToString();
            }   
            else
            {
                btnDeletar.Enabled = false;
            }
        }
        private void CarregarLista()
        {
            var lista = _banco.RetornarLista<UnidadeMedida>();
            listView1.Items.Clear();
            foreach (var linha in lista)
            {
                var listItem = new ListViewItem(
                        new String[]
                        {
                            linha.Descricao,
                            linha.Sigla
                        }

                );
                listItem.Tag = linha.Id;
                listView1.Items.Add(listItem);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var nomeUnidadeMedida = textBoxNomeUnidadeMedida.Text;
            var siglaUnidadeMedida = textBoxSigla.Text;
            bool existeItemSelecionado = listViewFunc.ExisteLinhaSelecionada(listView1);
            if (existeItemSelecionado)
            {
                var ItemSelecionado = listViewFunc.RetornaItemLinhaSelecionada<UnidadeMedida>(listView1);
                ItemSelecionado.Empresa = _contexto.Login.Empresa;
                ItemSelecionado.EmpresaId = _contexto.Login.EmpresaId;
                ItemSelecionado.Descricao = nomeUnidadeMedida;
                ItemSelecionado.Sigla = siglaUnidadeMedida;
                _banco.Atualizar<UnidadeMedida>(ItemSelecionado);
                CarregarLista();
                MessageBox.Show("Atualizado Com sucesso!"); 
                LimparTela();
            }else
            if (ExisteUnidadeMedida(nomeUnidadeMedida) && !existeItemSelecionado)
            {
                MessageBox.Show("Unidade de Medida já existe!");
                return;
            }
            else
            {
                var ItemSelecionado = new UnidadeMedida()
                {
                    Descricao = nomeUnidadeMedida,
                    Sigla     = siglaUnidadeMedida,
                    Empresa   = _contexto.Login.Empresa,
                    EmpresaId = _contexto.Login.EmpresaId
                };
                _banco.Cadastrar<UnidadeMedida>(ItemSelecionado);
                CarregarLista();
                MessageBox.Show("Cadastrado com sucesso!");
                LimparTela();
            }

        }
        private bool ExisteUnidadeMedida(string unidadeMedida)
        {
            return _contexto.UnidadesMedida.Where(e => e.Descricao == unidadeMedida).Any();
        }
        private void LimparTela()
        {
            textBoxNomeUnidadeMedida.Text = "";
            textBoxSigla.Text = "";
            btnDeletar.Enabled = false;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listViewFunc.ConfirmaDeletarItemDoList(listView1))
            {
                var itemSelecionado = listViewFunc.RetornaItemLinhaSelecionada<UnidadeMedida>(listView1);
                _banco.Deletar<UnidadeMedida>(itemSelecionado);
                CarregarLista();
                LimparTela();
            }
        }

        private void GerenciarUnidadeMedida_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }
    }
}
