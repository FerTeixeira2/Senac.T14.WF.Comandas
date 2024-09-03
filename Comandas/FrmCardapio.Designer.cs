namespace Comandas
{
    partial class FrmCardapio
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
            txtPesquisar = new ReaLTaiizor.Controls.ForeverTextBox();
            dgvCardapio = new DataGridView();
            btnEditar = new ReaLTaiizor.Controls.ForeverButton();
            btnExcluir = new ReaLTaiizor.Controls.ForeverButton();
            btnNovoItem = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnVoltar = new ReaLTaiizor.Controls.ForeverButton();
            fileSystemWatcher1 = new FileSystemWatcher();
            foreverForm1.SuspendLayout();
            foreverGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            foreverForm1.Text = "Cardápio";
            foreverForm1.TextColor = Color.FromArgb(234, 234, 234);
            foreverForm1.TextLight = Color.SeaGreen;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.Black;
            foreverGroupBox1.ArrowColorH = Color.Black;
            foreverGroupBox1.BackColor = Color.White;
            foreverGroupBox1.BaseColor = Color.DimGray;
            foreverGroupBox1.Controls.Add(txtPesquisar);
            foreverGroupBox1.Controls.Add(dgvCardapio);
            foreverGroupBox1.Controls.Add(btnEditar);
            foreverGroupBox1.Controls.Add(btnExcluir);
            foreverGroupBox1.Controls.Add(btnNovoItem);
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
            // txtPesquisar
            // 
            txtPesquisar.BackColor = Color.Transparent;
            txtPesquisar.BaseColor = Color.FromArgb(45, 47, 49);
            txtPesquisar.BorderColor = Color.FromArgb(35, 168, 109);
            txtPesquisar.FocusOnHover = false;
            txtPesquisar.ForeColor = Color.FromArgb(192, 192, 192);
            txtPesquisar.Location = new Point(321, 22);
            txtPesquisar.MaxLength = 32767;
            txtPesquisar.Multiline = false;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.ReadOnly = false;
            txtPesquisar.Size = new Size(313, 38);
            txtPesquisar.TabIndex = 5;
            txtPesquisar.Text = "Digite aqui para pesquisar";
            txtPesquisar.TextAlign = HorizontalAlignment.Left;
            txtPesquisar.UseSystemPasswordChar = false;
            // 
            // dgvCardapio
            // 
            dgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCardapio.Location = new Point(22, 66);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.RowHeadersWidth = 62;
            dgvCardapio.Size = new Size(735, 250);
            dgvCardapio.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BaseColor = Color.Teal;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(551, 326);
            btnEditar.Name = "btnEditar";
            btnEditar.Rounded = false;
            btnEditar.Size = new Size(83, 46);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextColor = Color.FromArgb(243, 243, 243);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.BaseColor = Color.DarkRed;
            btnExcluir.Font = new Font("Segoe UI", 12F);
            btnExcluir.Location = new Point(662, 326);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Rounded = false;
            btnExcluir.Size = new Size(83, 46);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextColor = Color.FromArgb(243, 243, 243);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovoItem
            // 
            btnNovoItem.BackColor = Color.Transparent;
            btnNovoItem.BaseColor = Color.FromArgb(35, 168, 109);
            btnNovoItem.Font = new Font("Segoe UI", 12F);
            btnNovoItem.Location = new Point(22, 13);
            btnNovoItem.Name = "btnNovoItem";
            btnNovoItem.Rounded = false;
            btnNovoItem.Size = new Size(257, 47);
            btnNovoItem.TabIndex = 1;
            btnNovoItem.Text = "+ Novo Item Cardápio";
            btnNovoItem.TextColor = Color.FromArgb(243, 243, 243);
            btnNovoItem.Click += btnNovoItem_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BaseColor = Color.Red;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(680, 13);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Rounded = false;
            btnVoltar.Size = new Size(77, 40);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.FromArgb(243, 243, 243);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(foreverForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            TransparencyKey = Color.Fuchsia;
            foreverForm1.ResumeLayout(false);
            foreverGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private FileSystemWatcher fileSystemWatcher1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ForeverButton btnVoltar;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnNovoItem;
        private ReaLTaiizor.Controls.ForeverButton btnExcluir;
        private DataGridView dgvCardapio;
        private ReaLTaiizor.Controls.ForeverButton btnEditar;
        private ReaLTaiizor.Controls.ForeverTextBox txtPesquisar;
    }
}