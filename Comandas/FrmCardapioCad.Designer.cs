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
            btnVoltar = new ReaLTaiizor.Controls.ForeverButtonSticky();
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
            foreverGroupBox1.Controls.Add(btnVoltar);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(12, 67);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(759, 348);
            foreverGroupBox1.TabIndex = 0;
            foreverGroupBox1.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BaseColor = Color.Red;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(658, 21);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Rounded = false;
            btnVoltar.Size = new Size(73, 42);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.FromArgb(243, 243, 243);
            btnVoltar.Click += btnVoltar_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnVoltar;
    }
}