﻿namespace BancoDeDados
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.btnLogar = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.mTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxManterLogin = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBoxEmpresas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.LightGreen;
            this.btnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.Black;
            this.btnLogar.Location = new System.Drawing.Point(210, 195);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 0;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(13, 82);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(272, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // mTextBoxSenha
            // 
            this.mTextBoxSenha.Location = new System.Drawing.Point(13, 117);
            this.mTextBoxSenha.Name = "mTextBoxSenha";
            this.mTextBoxSenha.PasswordChar = '*';
            this.mTextBoxSenha.Size = new System.Drawing.Size(272, 20);
            this.mTextBoxSenha.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(107, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 36);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Login";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadastrarUsuario,
            this.cadastroEmpresaToolStripMenuItem});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(50, 20);
            this.menuItem.Text = "Menu";
            // 
            // menuItemCadastrarUsuario
            // 
            this.menuItemCadastrarUsuario.Name = "menuItemCadastrarUsuario";
            this.menuItemCadastrarUsuario.Size = new System.Drawing.Size(180, 22);
            this.menuItemCadastrarUsuario.Text = "Cadastrar Usuário";
            this.menuItemCadastrarUsuario.Click += new System.EventHandler(this.menuItemCadastrarUsuario_Click);
            // 
            // cadastroEmpresaToolStripMenuItem
            // 
            this.cadastroEmpresaToolStripMenuItem.Name = "cadastroEmpresaToolStripMenuItem";
            this.cadastroEmpresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroEmpresaToolStripMenuItem.Text = "Cadastrar Empresa";
            this.cadastroEmpresaToolStripMenuItem.Click += new System.EventHandler(this.cadastroEmpresaToolStripMenuItem_Click);
            // 
            // checkBoxManterLogin
            // 
            this.checkBoxManterLogin.AutoSize = true;
            this.checkBoxManterLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxManterLogin.Location = new System.Drawing.Point(13, 199);
            this.checkBoxManterLogin.Name = "checkBoxManterLogin";
            this.checkBoxManterLogin.Size = new System.Drawing.Size(88, 18);
            this.checkBoxManterLogin.TabIndex = 6;
            this.checkBoxManterLogin.Text = "Manter Login";
            this.checkBoxManterLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(124, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboBoxEmpresas
            // 
            this.comboBoxEmpresas.FormattingEnabled = true;
            this.comboBoxEmpresas.Location = new System.Drawing.Point(68, 156);
            this.comboBoxEmpresas.Name = "comboBoxEmpresas";
            this.comboBoxEmpresas.Size = new System.Drawing.Size(217, 21);
            this.comboBoxEmpresas.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empresa";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(303, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmpresas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkBoxManterLogin);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mTextBoxSenha);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.MaskedTextBox mTextBoxSenha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrarUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxManterLogin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBoxEmpresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cadastroEmpresaToolStripMenuItem;
    }
}