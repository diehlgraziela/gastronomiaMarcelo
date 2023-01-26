﻿using BancoDeDados.Contexto;
using BancoDeDados.Controller.Model;
using BancoDeDados.Models;
using BancoDeDados.Servicos;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BancoDeDados.Controller.Telas
{
    public partial class GerenciarEmpresas : FormBase
    {
        public GerenciarEmpresas()
        {
            InitializeComponent();
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private bool ValidaCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeEmpresa.Text))
            {
                MessageBox.Show("Preencha o nome da empresa!");
            }
            else if (string.IsNullOrWhiteSpace(textBoxCNPJ.Text) || textBoxCNPJ.Text.Length != 16)
            {
                MessageBox.Show("Preencha o cnpj corretamente");
            }
            else
                return true;

            return false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Servico.ValidarEmail().IsMatch(textBoxEmail.Text) != true)
            {
                MessageBox.Show("Email Inválido!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxEmail.Focus();
                return;
            }

            if (!ValidaCampos())
                return;

            if (listViewFunc.ExisteLinhaSelecionada(listViewEmpresa))
            {// atualizar
                var empresaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Empresa>(listViewEmpresa);

                empresaSelecionada.NomeEmpresa = textBoxNomeEmpresa.Text;
                empresaSelecionada.CNPJ = textBoxCNPJ.Text;

                empresaSelecionada.Bairro = textBoxBairro.Text;
                empresaSelecionada.Cidade = textBoxCidade.Text;
                empresaSelecionada.Complemento = textBoxComplemento.Text;
                empresaSelecionada.EnderecoNumero = textBoxNumero.Text;
                empresaSelecionada.CustoKwh = _servico.FormataDinheiro(textBoxCustoKwh.Text);
                empresaSelecionada.Email = textBoxEmail.Text;
                empresaSelecionada.Logo = ImageToByte(pictureBoxLogo.Image);

                empresaSelecionada.Celular = textBoxCelular.Text;
                _banco.Atualizar<Empresa>(empresaSelecionada);
                listViewFunc.PreencheListView<Empresa, Empresa>(listViewEmpresa,
                new string[]
                {
                    "Id",
                    "NomeEmpresa",
                    "CNPJ",
                });
            }
            else
            { // cadastrar
                var empresa = new Empresa()
                {
                    NomeEmpresa = textBoxNomeEmpresa.Text,
                    CNPJ = textBoxFunc.FormataCNPJ(textBoxCNPJ.Text),
                    Rua = textBoxRua.Text,
                    Telefone = textBoxTelefone.Text,    
                    Bairro = textBoxBairro.Text,
                    Cidade = textBoxCidade.Text,
                    Complemento = textBoxComplemento.Text,
                    EnderecoNumero = textBoxNumero.Text,
                    Email = textBoxEmail.Text,
                    Logo = ImageToByte(pictureBoxLogo.Image),
                    Celular = textBoxCelular.Text
                };

                _banco.Cadastrar<Empresa>(empresa);
                listViewFunc.PreencheListView<Empresa, Empresa>(listViewEmpresa,
                new string[]
                {
                    "Id",
                    "NomeEmpresa",
                    "CNPJ",
                });
            }

        }
        private void btnAnexarLogo_Click(object sender, EventArgs e)
        {
            pictureBoxFunc.PreenchePictureBox(pictureBoxLogo);
        }

        private void listViewEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFunc.ExisteLinhaSelecionada(listViewEmpresa))
            {
                var empresaSelecionada = listViewFunc.RetornaItemLinhaSelecionada<Empresa>(listViewEmpresa);
                btnDeletar.Enabled = true;
                PreencheCampos(empresaSelecionada);
            }
            else
            {
                Limpar();
                btnDeletar.Enabled = false;
            }
        }
        private void RetornaImagemParaPictureBox(byte [] image,PictureBox pictureBox)
        {
            if (image == null)
                return;
            int ArraySize = image.GetUpperBound(0);
            if (ArraySize <= 0)
                return;
            MemoryStream ms = new MemoryStream(image, 0, ArraySize);
            pictureBox.Image = Image.FromStream(ms);
        }
        private void PreencheCampos(Empresa empresaSelecionada)
        {
            if (empresaSelecionada == null)
                return;
            textBoxNomeEmpresa.Text = empresaSelecionada.NomeEmpresa;
            textBoxCNPJ.Text = empresaSelecionada.CNPJ.ToString();
            textBoxCustoKwh.Text = _servico.FormataValor(empresaSelecionada.CustoKwh);
            textBoxBairro.Text = empresaSelecionada.Bairro;
            textBoxCidade.Text = empresaSelecionada.Cidade;
            textBoxComplemento.Text = empresaSelecionada.Complemento;
            textBoxNumero.Text = empresaSelecionada.EnderecoNumero;

            textBoxEmail.Text = empresaSelecionada.Email;
            RetornaImagemParaPictureBox(empresaSelecionada.Logo, pictureBoxLogo);
            if(empresaSelecionada.Celular != null)
                textBoxCelular.Text = empresaSelecionada.Celular.ToString();
        }
        private void GerenciarEmpresas_Load(object sender, EventArgs e)
        {
            Limpar();
            listViewFunc.PreencheListView<Empresa, Empresa>(listViewEmpresa,
                new string[]
                {
                    "Id",
                    "NomeEmpresa",
                    "CNPJ",
                });
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listViewFunc.ConfirmaDeletarItemDoList(listViewEmpresa))
            {
                var empresa = listViewFunc.RetornaItemLinhaSelecionada<Empresa>(listViewEmpresa);

                _banco.Deletar<Empresa>(empresa);
                Limpar();
            }
        }

        private void Limpar()
        { 
            textBoxNomeEmpresa.Text = "";
            textBoxCNPJ.Text    = "";
            textBoxBairro.Text  = "";
            textBoxCidade.Text  = "";
            textBoxComplemento.Text = "";
            textBoxNumero.Text  = "";
            textBoxEmail.Text   = "";
            pictureBoxLogo.Image = null;               
            textBoxCelular.Text  = "";

            listViewFunc.DesSelecionionaListView(listViewEmpresa);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void textBoxCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxFunc.FormatoTextBoxDinheiro(sender, e);
        }

        private void GerenciarEmpresas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_contexto.Login != null)
            {
                var usuarioLogado = _contexto.Login.Id;
                _contexto.Login = _banco.RetornarLista<UsuarioLogin>(usuarioLogado).First();
            }
        }
    }
}
