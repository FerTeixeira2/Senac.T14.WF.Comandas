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
            formUsuario.Size = new Size(800, 450);
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
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BaseColor = Color.Red;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(668, 17);
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
            ClientSize = new Size(800, 450);
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
    }
}