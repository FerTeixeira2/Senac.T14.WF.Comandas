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
            btnCancelar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnExcluir = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnNovo = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnSalvar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnVoltar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            formUsuario.SuspendLayout();
            gpxUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // formUsuario
            // 
            formUsuario.BackColor = Color.White;
            formUsuario.BaseColor = Color.FromArgb(60, 70, 73);
            formUsuario.BorderColor = Color.DodgerBlue;
            formUsuario.Controls.Add(gpxUsuario);
            formUsuario.Dock = DockStyle.Fill;
            formUsuario.Font = new Font("Segoe UI", 12F);
            formUsuario.ForeverColor = Color.FromArgb(35, 168, 109);
            formUsuario.HeaderColor = Color.FromArgb(45, 47, 49);
            formUsuario.HeaderMaximize = false;
            formUsuario.HeaderTextFont = new Font("Segoe UI", 12F);
            formUsuario.Image = null;
            formUsuario.Location = new Point(0, 0);
            formUsuario.MinimumSize = new Size(210, 50);
            formUsuario.Name = "formUsuario";
            formUsuario.Padding = new Padding(1, 51, 1, 1);
            formUsuario.Sizable = true;
            formUsuario.Size = new Size(808, 451);
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
            gpxUsuario.Controls.Add(btnCancelar);
            gpxUsuario.Controls.Add(btnExcluir);
            gpxUsuario.Controls.Add(btnNovo);
            gpxUsuario.Controls.Add(btnSalvar);
            gpxUsuario.Controls.Add(btnVoltar);
            gpxUsuario.Font = new Font("Segoe UI", 10F);
            gpxUsuario.Location = new Point(12, 72);
            gpxUsuario.Name = "gpxUsuario";
            gpxUsuario.ShowArrow = true;
            gpxUsuario.ShowText = true;
            gpxUsuario.Size = new Size(765, 350);
            gpxUsuario.TabIndex = 0;
            gpxUsuario.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BaseColor = Color.DarkCyan;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(576, 122);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Rounded = false;
            btnCancelar.Size = new Size(139, 89);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.BaseColor = Color.DarkCyan;
            btnExcluir.Font = new Font("Segoe UI", 12F);
            btnExcluir.Location = new Point(398, 122);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Rounded = false;
            btnExcluir.Size = new Size(138, 89);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.BaseColor = Color.DarkCyan;
            btnNovo.Font = new Font("Segoe UI", 12F);
            btnNovo.Location = new Point(32, 122);
            btnNovo.Name = "btnNovo";
            btnNovo.Rounded = false;
            btnNovo.Size = new Size(155, 87);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.TextColor = Color.FromArgb(243, 243, 243);
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BaseColor = Color.DarkCyan;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(215, 122);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Rounded = false;
            btnSalvar.Size = new Size(145, 89);
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
            btnVoltar.Location = new Point(667, 16);
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
            ClientSize = new Size(808, 451);
            Controls.Add(formUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuario";
            TransparencyKey = Color.Fuchsia;
            formUsuario.ResumeLayout(false);
            gpxUsuario.ResumeLayout(false);
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
    }
}