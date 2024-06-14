namespace Comandas
{
    partial class FrmComanda
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
            formComanda = new ReaLTaiizor.Forms.ForeverForm();
            groupBoxComanda = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnVoltar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            formComanda.SuspendLayout();
            groupBoxComanda.SuspendLayout();
            SuspendLayout();
            // 
            // formComanda
            // 
            formComanda.BackColor = Color.White;
            formComanda.BaseColor = Color.FromArgb(60, 70, 73);
            formComanda.BorderColor = Color.DodgerBlue;
            formComanda.Controls.Add(groupBoxComanda);
            formComanda.Dock = DockStyle.Fill;
            formComanda.Font = new Font("Segoe UI", 12F);
            formComanda.ForeverColor = Color.FromArgb(35, 168, 109);
            formComanda.HeaderColor = Color.FromArgb(45, 47, 49);
            formComanda.HeaderMaximize = false;
            formComanda.HeaderTextFont = new Font("Segoe UI", 12F);
            formComanda.Image = null;
            formComanda.Location = new Point(0, 0);
            formComanda.MinimumSize = new Size(210, 50);
            formComanda.Name = "formComanda";
            formComanda.Padding = new Padding(1, 51, 1, 1);
            formComanda.Sizable = true;
            formComanda.Size = new Size(800, 450);
            formComanda.TabIndex = 0;
            formComanda.Text = "Comanda";
            formComanda.TextColor = Color.FromArgb(234, 234, 234);
            formComanda.TextLight = Color.SeaGreen;
            // 
            // groupBoxComanda
            // 
            groupBoxComanda.ArrowColorF = Color.Black;
            groupBoxComanda.ArrowColorH = Color.Black;
            groupBoxComanda.BackColor = Color.White;
            groupBoxComanda.BaseColor = Color.DimGray;
            groupBoxComanda.Controls.Add(btnVoltar);
            groupBoxComanda.Font = new Font("Segoe UI", 10F);
            groupBoxComanda.Location = new Point(12, 63);
            groupBoxComanda.Name = "groupBoxComanda";
            groupBoxComanda.ShowArrow = true;
            groupBoxComanda.ShowText = true;
            groupBoxComanda.Size = new Size(776, 345);
            groupBoxComanda.TabIndex = 0;
            groupBoxComanda.TextColor = Color.FromArgb(35, 168, 109);
            groupBoxComanda.Click += groupBoxComanda_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BaseColor = Color.Red;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(683, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Rounded = false;
            btnVoltar.Size = new Size(75, 40);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.FromArgb(243, 243, 243);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formComanda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComanda";
            TransparencyKey = Color.Fuchsia;
            formComanda.ResumeLayout(false);
            groupBoxComanda.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm formComanda;
        private ReaLTaiizor.Controls.ForeverGroupBox groupBoxComanda;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnVoltar;
    }
}