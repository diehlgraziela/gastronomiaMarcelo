﻿namespace BancoDeDados.Views.Telas
{
    partial class GerenciarPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletaar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.listViewReceitas = new System.Windows.Forms.ListView();
            this.headerNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrecoUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataEntregaRealizada = new System.Windows.Forms.DateTimePicker();
            this.dataParaEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnDeletarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValorVendaTotal = new System.Windows.Forms.TextBox();
            this.textBoxLucroTotal = new System.Windows.Forms.TextBox();
            this.textBoxCustoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewPedidos = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletaar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.listViewReceitas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataEntregaRealizada);
            this.groupBox1.Controls.Add(this.dataParaEntrega);
            this.groupBox1.Controls.Add(this.btnDeletarPedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // btnDeletaar
            // 
            this.btnDeletaar.BackColor = System.Drawing.Color.Salmon;
            this.btnDeletaar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletaar.Location = new System.Drawing.Point(23, 391);
            this.btnDeletaar.Name = "btnDeletaar";
            this.btnDeletaar.Size = new System.Drawing.Size(195, 23);
            this.btnDeletaar.TabIndex = 66;
            this.btnDeletaar.Text = "Deletar Pedido";
            this.btnDeletaar.UseVisualStyleBackColor = false;
            this.btnDeletaar.Click += new System.EventHandler(this.btnDeletaar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(498, 392);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 23);
            this.btnCadastrar.TabIndex = 65;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // listViewReceitas
            // 
            this.listViewReceitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerNome,
            this.headerPrecoUnidade,
            this.columnHeader5});
            this.listViewReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewReceitas.FullRowSelect = true;
            this.listViewReceitas.HideSelection = false;
            this.listViewReceitas.Location = new System.Drawing.Point(23, 251);
            this.listViewReceitas.Name = "listViewReceitas";
            this.listViewReceitas.Size = new System.Drawing.Size(436, 134);
            this.listViewReceitas.TabIndex = 31;
            this.listViewReceitas.UseCompatibleStateImageBehavior = false;
            this.listViewReceitas.View = System.Windows.Forms.View.Details;
            this.listViewReceitas.SelectedIndexChanged += new System.EventHandler(this.listViewReceitas_SelectedIndexChanged);
            // 
            // headerNome
            // 
            this.headerNome.Text = "Nome";
            this.headerNome.Width = 185;
            // 
            // headerPrecoUnidade
            // 
            this.headerPrecoUnidade.Text = "Preço de Venda";
            this.headerPrecoUnidade.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lucro";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(498, 335);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(239, 21);
            this.comboBoxCliente.TabIndex = 63;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Data Entrega Realizada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Data Para Entrega";
            // 
            // dataEntregaRealizada
            // 
            this.dataEntregaRealizada.Enabled = false;
            this.dataEntregaRealizada.Location = new System.Drawing.Point(498, 282);
            this.dataEntregaRealizada.Name = "dataEntregaRealizada";
            this.dataEntregaRealizada.Size = new System.Drawing.Size(239, 20);
            this.dataEntregaRealizada.TabIndex = 60;
            // 
            // dataParaEntrega
            // 
            this.dataParaEntrega.Location = new System.Drawing.Point(498, 226);
            this.dataParaEntrega.Name = "dataParaEntrega";
            this.dataParaEntrega.Size = new System.Drawing.Size(239, 20);
            this.dataParaEntrega.TabIndex = 59;
            // 
            // btnDeletarPedido
            // 
            this.btnDeletarPedido.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDeletarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarPedido.Location = new System.Drawing.Point(498, 362);
            this.btnDeletarPedido.Name = "btnDeletarPedido";
            this.btnDeletarPedido.Size = new System.Drawing.Size(239, 23);
            this.btnDeletarPedido.TabIndex = 33;
            this.btnDeletarPedido.Text = "Remover Receita do Pedido";
            this.btnDeletarPedido.UseVisualStyleBackColor = false;
            this.btnDeletarPedido.Click += new System.EventHandler(this.btnDeletarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Receitas do Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxValorVendaTotal);
            this.groupBox2.Controls.Add(this.textBoxLucroTotal);
            this.groupBox2.Controls.Add(this.textBoxCustoTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listViewPedidos);
            this.groupBox2.Controls.Add(this.btnAdicionarReceita);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 188);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Valor de venda total";
            // 
            // textBoxValorVendaTotal
            // 
            this.textBoxValorVendaTotal.Enabled = false;
            this.textBoxValorVendaTotal.Location = new System.Drawing.Point(554, 128);
            this.textBoxValorVendaTotal.Name = "textBoxValorVendaTotal";
            this.textBoxValorVendaTotal.Size = new System.Drawing.Size(171, 21);
            this.textBoxValorVendaTotal.TabIndex = 38;
            // 
            // textBoxLucroTotal
            // 
            this.textBoxLucroTotal.Enabled = false;
            this.textBoxLucroTotal.Location = new System.Drawing.Point(554, 56);
            this.textBoxLucroTotal.Name = "textBoxLucroTotal";
            this.textBoxLucroTotal.Size = new System.Drawing.Size(171, 21);
            this.textBoxLucroTotal.TabIndex = 37;
            // 
            // textBoxCustoTotal
            // 
            this.textBoxCustoTotal.Enabled = false;
            this.textBoxCustoTotal.Location = new System.Drawing.Point(554, 20);
            this.textBoxCustoTotal.Name = "textBoxCustoTotal";
            this.textBoxCustoTotal.Size = new System.Drawing.Size(171, 21);
            this.textBoxCustoTotal.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Lucro Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Custo Total";
            // 
            // listViewPedidos
            // 
            this.listViewPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPedidos.FullRowSelect = true;
            this.listViewPedidos.HideSelection = false;
            this.listViewPedidos.Location = new System.Drawing.Point(6, 20);
            this.listViewPedidos.Name = "listViewPedidos";
            this.listViewPedidos.Size = new System.Drawing.Size(441, 162);
            this.listViewPedidos.TabIndex = 33;
            this.listViewPedidos.UseCompatibleStateImageBehavior = false;
            this.listViewPedidos.View = System.Windows.Forms.View.Details;
            this.listViewPedidos.SelectedIndexChanged += new System.EventHandler(this.listViewPedidos_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chave Pedido";
            this.columnHeader4.Width = 185;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cliente";
            this.columnHeader6.Width = 147;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Valor de Venda";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 99;
            // 
            // btnAdicionarReceita
            // 
            this.btnAdicionarReceita.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdicionarReceita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarReceita.Location = new System.Drawing.Point(492, 159);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(233, 23);
            this.btnAdicionarReceita.TabIndex = 32;
            this.btnAdicionarReceita.Text = "Adicionar Receita Selecionada";
            this.btnAdicionarReceita.UseVisualStyleBackColor = false;
            this.btnAdicionarReceita.Click += new System.EventHandler(this.btnAdicionarReceita_Click);
            // 
            // GerenciarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "GerenciarPedidos";
            this.Text = "Gerenciar Pedidos";
            this.Load += new System.EventHandler(this.GerenciarPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdicionarReceita;
        private System.Windows.Forms.ListView listViewReceitas;
        private System.Windows.Forms.ColumnHeader headerNome;
        private System.Windows.Forms.ColumnHeader headerPrecoUnidade;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataEntregaRealizada;
        private System.Windows.Forms.DateTimePicker dataParaEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ListView listViewPedidos;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValorVendaTotal;
        private System.Windows.Forms.TextBox textBoxLucroTotal;
        private System.Windows.Forms.TextBox textBoxCustoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeletaar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}