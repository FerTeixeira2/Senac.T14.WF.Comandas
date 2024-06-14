namespace Comandas
{
    partial class FrmPedidoCozinha
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
            formPedido = new ReaLTaiizor.Forms.ForeverForm();
            gpxPedido = new ReaLTaiizor.Controls.ForeverGroupBox();
            btnVoltar = new ReaLTaiizor.Controls.ForeverButtonSticky();
            formPedido.SuspendLayout();
            gpxPedido.SuspendLayout();
            SuspendLayout();
            // 
            // formPedido
            // 
            formPedido.BackColor = Color.White;
            formPedido.BaseColor = Color.FromArgb(60, 70, 73);
            formPedido.BorderColor = Color.DodgerBlue;
            formPedido.Controls.Add(gpxPedido);
            formPedido.Dock = DockStyle.Fill;
            formPedido.Font = new Font("Segoe UI", 12F);
            formPedido.ForeverColor = Color.FromArgb(35, 168, 109);
            formPedido.HeaderColor = Color.FromArgb(45, 47, 49);
            formPedido.HeaderMaximize = false;
            formPedido.HeaderTextFont = new Font("Segoe UI", 12F);
            formPedido.Image = null;
            formPedido.Location = new Point(0, 0);
            formPedido.MinimumSize = new Size(210, 50);
            formPedido.Name = "formPedido";
            formPedido.Padding = new Padding(1, 51, 1, 1);
            formPedido.Sizable = true;
            formPedido.Size = new Size(800, 450);
            formPedido.TabIndex = 0;
            formPedido.Text = "Pedido";
            formPedido.TextColor = Color.FromArgb(234, 234, 234);
            formPedido.TextLight = Color.SeaGreen;
            // 
            // gpxPedido
            // 
            gpxPedido.ArrowColorF = Color.Black;
            gpxPedido.ArrowColorH = Color.Black;
            gpxPedido.BackColor = Color.White;
            gpxPedido.BaseColor = Color.DimGray;
            gpxPedido.Controls.Add(btnVoltar);
            gpxPedido.Font = new Font("Segoe UI", 10F);
            gpxPedido.Location = new Point(12, 63);
            gpxPedido.Name = "gpxPedido";
            gpxPedido.ShowArrow = true;
            gpxPedido.ShowText = true;
            gpxPedido.Size = new Size(758, 357);
            gpxPedido.TabIndex = 0;
            gpxPedido.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BaseColor = Color.Red;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(666, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Rounded = false;
            btnVoltar.Size = new Size(73, 40);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.FromArgb(243, 243, 243);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmPedidoCozinha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPedidoCozinha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPedidoCozinha";
            TransparencyKey = Color.Fuchsia;
            formPedido.ResumeLayout(false);
            gpxPedido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm formPedido;
        private ReaLTaiizor.Controls.ForeverGroupBox gpxPedido;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnVoltar;
    }
}