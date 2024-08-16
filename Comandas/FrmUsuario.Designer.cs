namespace Comandas
{
    partial class FrmUsuario
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
            formUsuario = new ReaLTaiizor.Forms.ForeverForm();
            gpxUsuario = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnEditar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            dgvUsuarios = new DataGridView();
            gpx = new ReaLTaiizor.Controls.ForeverGroupBox();
            labelSenha = new ReaLTaiizor.Controls.ForeverLabel();
            txtSenha = new ReaLTaiizor.Controls.ForeverTextBox();
            labelEmail = new ReaLTaiizor.Controls.ForeverLabel();
            labelNome = new ReaLTaiizor.Controls.ForeverLabel();
            labelId = new ReaLTaiizor.Controls.ForeverLabel();
            txtEmail = new ReaLTaiizor.Controls.ForeverTextBox();
            txtNome = new ReaLTaiizor.Controls.ForeverTextBox();
            txtId = new ReaLTaiizor.Controls.ForeverTextBox();
            btnCancelar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnExcluir = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnNovo = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnSalvar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnVoltar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            formUsuario.SuspendLayout();
            gpxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gpx.SuspendLayout();
            SuspendLayout();
            // 
            // formUsuario
            // 
            formUsuario.BackColor = Color.White;
            formUsuario.BaseColor = Color.FromArgb(60, 70, 73);
            formUsuario.BorderColor = Color.DodgerBlue;
            formUsuario.Controls.Add(gpxUsuario);
            formUsuario.Controls.Add(btnVoltar);
            formUsuario.Dock = DockStyle.Fill;
            formUsuario.Font = new Font("Segoe UI", 12F);
            formUsuario.ForeverColor = Color.Lime;
            formUsuario.HeaderColor = Color.FromArgb(45, 47, 49);
            formUsuario.HeaderMaximize = false;
            formUsuario.HeaderTextFont = new Font("Segoe UI", 12F);
            formUsuario.Image = null;
            formUsuario.Location = new Point(0, 0);
            formUsuario.MinimumSize = new Size(210, 50);
            formUsuario.Name = "formUsuario";
            formUsuario.Padding = new Padding(1, 51, 1, 1);
            formUsuario.Sizable = true;
            formUsuario.Size = new Size(808, 526);
            formUsuario.TabIndex = 0;
            formUsuario.Text = "Usuário";
            formUsuario.TextColor = Color.FromArgb(234, 234, 234);
            formUsuario.TextLight = Color.SeaGreen;
            // 
            // gpxUsuario
            // 
            gpxUsuario.ArrowColorF = Color.Black;
            gpxUsuario.ArrowColorH = Color.Black;
            gpxUsuario.BackColor = Color.White;
            gpxUsuario.BaseColor = Color.DimGray;
            gpxUsuario.Controls.Add(btnEditar);
            gpxUsuario.Controls.Add(dgvUsuarios);
            gpxUsuario.Controls.Add(gpx);
            gpxUsuario.Controls.Add(btnCancelar);
            gpxUsuario.Controls.Add(btnExcluir);
            gpxUsuario.Controls.Add(btnNovo);
            gpxUsuario.Controls.Add(btnSalvar);
            gpxUsuario.Font = new Font("Segoe UI", 10F);
            gpxUsuario.Location = new Point(12, 49);
            gpxUsuario.Name = "gpxUsuario";
            gpxUsuario.ShowArrow = true;
            gpxUsuario.ShowText = true;
            gpxUsuario.Size = new Size(784, 465);
            gpxUsuario.TabIndex = 0;
            gpxUsuario.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BaseColor = Color.Teal;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(190, 228);
            btnEditar.Name = "btnEditar";
            btnEditar.Rounded = false;
            btnEditar.Size = new Size(113, 44);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.TextColor = Color.FromArgb(243, 243, 243);
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.DarkGray;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.GridColor = Color.LightSlateGray;
            dgvUsuarios.Location = new Point(36, 278);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(707, 160);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // gpx
            // 
            gpx.ArrowColorF = Color.FromArgb(60, 70, 73);
            gpx.ArrowColorH = Color.FromArgb(60, 70, 73);
            gpx.BackColor = Color.Transparent;
            gpx.BaseColor = Color.FromArgb(60, 70, 73);
            gpx.Controls.Add(labelSenha);
            gpx.Controls.Add(txtSenha);
            gpx.Controls.Add(labelEmail);
            gpx.Controls.Add(labelNome);
            gpx.Controls.Add(labelId);
            gpx.Controls.Add(txtEmail);
            gpx.Controls.Add(txtNome);
            gpx.Controls.Add(txtId);
            gpx.Font = new Font("Segoe UI", 10F);
            gpx.Location = new Point(15, 0);
            gpx.Name = "gpx";
            gpx.ShowArrow = true;
            gpx.ShowText = true;
            gpx.Size = new Size(749, 228);
            gpx.TabIndex = 5;
            gpx.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.BackColor = Color.Transparent;
            labelSenha.Font = new Font("Segoe UI", 8F);
            labelSenha.ForeColor = Color.LightGray;
            labelSenha.Location = new Point(23, 183);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(53, 21);
            labelSenha.TabIndex = 7;
            labelSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Transparent;
            txtSenha.BaseColor = Color.FromArgb(45, 47, 49);
            txtSenha.BorderColor = Color.FromArgb(35, 168, 109);
            txtSenha.FocusOnHover = false;
            txtSenha.ForeColor = Color.FromArgb(192, 192, 192);
            txtSenha.Location = new Point(99, 173);
            txtSenha.MaxLength = 32767;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = false;
            txtSenha.Size = new Size(629, 38);
            txtSenha.TabIndex = 6;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 8F);
            labelEmail.ForeColor = Color.LightGray;
            labelEmail.Location = new Point(21, 134);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 21);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "E-Mail";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Segoe UI", 8F);
            labelNome.ForeColor = Color.LightGray;
            labelNome.Location = new Point(21, 81);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 21);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.BackColor = Color.Transparent;
            labelId.Font = new Font("Segoe UI", 8F);
            labelId.ForeColor = Color.LightGray;
            labelId.Location = new Point(35, 30);
            labelId.Name = "labelId";
            labelId.Size = new Size(25, 21);
            labelId.TabIndex = 3;
            labelId.Text = "ID";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Transparent;
            txtEmail.BaseColor = Color.FromArgb(45, 47, 49);
            txtEmail.BorderColor = Color.FromArgb(35, 168, 109);
            txtEmail.FocusOnHover = false;
            txtEmail.ForeColor = Color.FromArgb(192, 192, 192);
            txtEmail.Location = new Point(99, 124);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = false;
            txtEmail.Size = new Size(629, 38);
            txtEmail.TabIndex = 2;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Transparent;
            txtNome.BaseColor = Color.FromArgb(45, 47, 49);
            txtNome.BorderColor = Color.FromArgb(35, 168, 109);
            txtNome.FocusOnHover = false;
            txtNome.ForeColor = Color.FromArgb(192, 192, 192);
            txtNome.Location = new Point(99, 71);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = false;
            txtNome.Size = new Size(629, 38);
            txtNome.TabIndex = 1;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Transparent;
            txtId.BaseColor = Color.FromArgb(45, 47, 49);
            txtId.BorderColor = Color.FromArgb(35, 168, 109);
            txtId.Enabled = false;
            txtId.FocusOnHover = false;
            txtId.ForeColor = Color.FromArgb(192, 192, 192);
            txtId.Location = new Point(99, 20);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.ReadOnly = false;
            txtId.Size = new Size(629, 38);
            txtId.TabIndex = 0;
            txtId.Text = "1";
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BaseColor = Color.Teal;
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(615, 228);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Rounded = false;
            btnCancelar.Size = new Size(107, 44);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.FromArgb(243, 243, 243);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.BaseColor = Color.Teal;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 12F);
            btnExcluir.Location = new Point(475, 228);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Rounded = false;
            btnExcluir.Size = new Size(105, 44);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextColor = Color.FromArgb(243, 243, 243);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.BaseColor = Color.Teal;
            btnNovo.Font = new Font("Segoe UI", 12F);
            btnNovo.Location = new Point(40, 228);
            btnNovo.Name = "btnNovo";
            btnNovo.Rounded = false;
            btnNovo.Size = new Size(116, 44);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.TextColor = Color.FromArgb(243, 243, 243);
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BaseColor = Color.Teal;
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(341, 228);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Rounded = false;
            btnSalvar.Size = new Size(97, 44);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.FromArgb(243, 243, 243);
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BaseColor = Color.Red;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(700, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Rounded = false;
            btnVoltar.Size = new Size(76, 31);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.FromArgb(243, 243, 243);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 526);
            Controls.Add(formUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuario";
            TransparencyKey = Color.Fuchsia;
            Load += FrmUsuario_Load;
            formUsuario.ResumeLayout(false);
            gpxUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gpx.ResumeLayout(false);
            gpx.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm formUsuario;
        private ReaLTaiizor.Controls.ForeverGroupBox gpxUsuario;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnVoltar;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnCancelar;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnExcluir;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnNovo;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnSalvar;
        private ReaLTaiizor.Controls.ForeverGroupBox gpx;
        private ReaLTaiizor.Controls.ForeverTextBox txtEmail;
        private ReaLTaiizor.Controls.ForeverTextBox txtNome;
        private ReaLTaiizor.Controls.ForeverTextBox txtId;
        private ReaLTaiizor.Controls.ForeverLabel labelEmail;
        private ReaLTaiizor.Controls.ForeverLabel labelNome;
        private ReaLTaiizor.Controls.ForeverLabel labelId;
        private ReaLTaiizor.Controls.ForeverLabel labelSenha;
        private ReaLTaiizor.Controls.ForeverTextBox txtSenha;
        private DataGridView dgvUsuarios;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnEditar;
    }
}