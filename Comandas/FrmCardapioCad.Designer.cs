namespace Comandas
{
    partial class FrmCardapioCad
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
            foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnSalvar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnCancelar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            chkPreparo = new ReaLTaiizor.Controls.MaterialCheckBox();
            txtPreco = new ReaLTaiizor.Controls.ForeverTextBox();
            txtDescricao = new ReaLTaiizor.Controls.ForeverTextBox();
            txtTitulo = new ReaLTaiizor.Controls.ForeverTextBox();
            btnVoltar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            txtId = new ReaLTaiizor.Controls.ForeverTextBox();
            foreverForm1.SuspendLayout();
            foreverGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // foreverForm1
            // 
            foreverForm1.BackColor = Color.White;
            foreverForm1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverForm1.BorderColor = Color.DodgerBlue;
            foreverForm1.Controls.Add(foreverGroupBox1);
            foreverForm1.Dock = DockStyle.Fill;
            foreverForm1.Font = new Font("Segoe UI", 12F);
            foreverForm1.ForeverColor = Color.FromArgb(35, 168, 109);
            foreverForm1.HeaderColor = Color.FromArgb(45, 47, 49);
            foreverForm1.HeaderMaximize = false;
            foreverForm1.HeaderTextFont = new Font("Segoe UI", 12F);
            foreverForm1.Image = null;
            foreverForm1.Location = new Point(0, 0);
            foreverForm1.MinimumSize = new Size(210, 50);
            foreverForm1.Name = "foreverForm1";
            foreverForm1.Padding = new Padding(1, 51, 1, 1);
            foreverForm1.Sizable = true;
            foreverForm1.Size = new Size(800, 450);
            foreverForm1.TabIndex = 0;
            foreverForm1.Text = "Acrescentar";
            foreverForm1.TextColor = Color.FromArgb(234, 234, 234);
            foreverForm1.TextLight = Color.SeaGreen;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Black;
            foreverGroupBox1.ArrowColorH = Color.Black;
            foreverGroupBox1.BackColor = Color.White;
            foreverGroupBox1.BaseColor = Color.DimGray;
            foreverGroupBox1.Controls.Add(txtId);
            foreverGroupBox1.Controls.Add(btnSalvar);
            foreverGroupBox1.Controls.Add(btnCancelar);
            foreverGroupBox1.Controls.Add(foxLabel3);
            foreverGroupBox1.Controls.Add(foxLabel2);
            foreverGroupBox1.Controls.Add(foxLabel1);
            foreverGroupBox1.Controls.Add(chkPreparo);
            foreverGroupBox1.Controls.Add(txtPreco);
            foreverGroupBox1.Controls.Add(txtDescricao);
            foreverGroupBox1.Controls.Add(txtTitulo);
            foreverGroupBox1.Controls.Add(btnVoltar);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(12, 54);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(776, 392);
            foreverGroupBox1.TabIndex = 0;
            foreverGroupBox1.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BaseColor = Color.Teal;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(620, 301);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Rounded = false;
            btnSalvar.Size = new Size(104, 54);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.FromArgb(243, 243, 243);
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BaseColor = Color.DarkRed;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(471, 301);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Rounded = false;
            btnCancelar.Size = new Size(104, 54);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.FromArgb(243, 243, 243);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // foxLabel3
            // 
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel3.ForeColor = Color.White;
            foxLabel3.Location = new Point(47, 241);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(116, 33);
            foxLabel3.TabIndex = 12;
            foxLabel3.Text = "Preço";
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(47, 142);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(116, 33);
            foxLabel2.TabIndex = 11;
            foxLabel2.Text = "Descrição";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.White;
            foxLabel1.Location = new Point(47, 40);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(116, 33);
            foxLabel1.TabIndex = 10;
            foxLabel1.Text = "Título";
            // 
            // chkPreparo
            // 
            chkPreparo.AutoSize = true;
            chkPreparo.BackColor = Color.DimGray;
            chkPreparo.Depth = 0;
            chkPreparo.Location = new Point(47, 337);
            chkPreparo.Margin = new Padding(0);
            chkPreparo.MouseLocation = new Point(-1, -1);
            chkPreparo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkPreparo.Name = "chkPreparo";
            chkPreparo.ReadOnly = false;
            chkPreparo.Ripple = true;
            chkPreparo.Size = new Size(149, 37);
            chkPreparo.TabIndex = 7;
            chkPreparo.Text = "Possui preparo?";
            chkPreparo.UseAccentColor = false;
            chkPreparo.UseVisualStyleBackColor = false;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.Transparent;
            txtPreco.BaseColor = Color.FromArgb(45, 47, 49);
            txtPreco.BorderColor = Color.FromArgb(35, 168, 109);
            txtPreco.FocusOnHover = false;
            txtPreco.ForeColor = Color.FromArgb(192, 192, 192);
            txtPreco.Location = new Point(47, 280);
            txtPreco.MaxLength = 32767;
            txtPreco.Multiline = false;
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = false;
            txtPreco.Size = new Size(187, 38);
            txtPreco.TabIndex = 3;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.UseSystemPasswordChar = false;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.Transparent;
            txtDescricao.BaseColor = Color.FromArgb(45, 47, 49);
            txtDescricao.BorderColor = Color.FromArgb(35, 168, 109);
            txtDescricao.FocusOnHover = false;
            txtDescricao.ForeColor = Color.FromArgb(192, 192, 192);
            txtDescricao.Location = new Point(47, 181);
            txtDescricao.MaxLength = 32767;
            txtDescricao.Multiline = false;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = false;
            txtDescricao.Size = new Size(686, 38);
            txtDescricao.TabIndex = 2;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.BaseColor = Color.FromArgb(45, 47, 49);
            txtTitulo.BorderColor = Color.FromArgb(35, 168, 109);
            txtTitulo.FocusOnHover = false;
            txtTitulo.ForeColor = Color.FromArgb(192, 192, 192);
            txtTitulo.Location = new Point(47, 79);
            txtTitulo.MaxLength = 32767;
            txtTitulo.Multiline = false;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = false;
            txtTitulo.Size = new Size(686, 38);
            txtTitulo.TabIndex = 1;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BaseColor = Color.Red;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(689, 14);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Rounded = false;
            btnVoltar.Size = new Size(73, 42);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.FromArgb(243, 243, 243);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Transparent;
            txtId.BaseColor = Color.FromArgb(45, 47, 49);
            txtId.BorderColor = Color.FromArgb(35, 168, 109);
            txtId.FocusOnHover = false;
            txtId.ForeColor = Color.FromArgb(192, 192, 192);
            txtId.Location = new Point(335, 18);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.ReadOnly = false;
            txtId.Size = new Size(62, 38);
            txtId.TabIndex = 15;
            txtId.Text = "1";
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.UseSystemPasswordChar = false;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(foreverForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapioCad";
            TransparencyKey = Color.Fuchsia;
            foreverForm1.ResumeLayout(false);
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnVoltar;
        private ReaLTaiizor.Controls.ForeverTextBox txtPreco;
        private ReaLTaiizor.Controls.ForeverTextBox txtDescricao;
        private ReaLTaiizor.Controls.ForeverTextBox txtTitulo;
        private ReaLTaiizor.Controls.MaterialCheckBox chkPreparo;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnCancelar;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnSalvar;
        private ReaLTaiizor.Controls.ForeverTextBox txtId;
    }
}