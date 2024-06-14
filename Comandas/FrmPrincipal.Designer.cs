namespace Comandas
{
    partial class FrmPrincipal
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
            gpxPrincipal = new GroupBox();
            btnSair = new ReaLTaiizor.Controls.ForeverButtonSticky();
            btnUsuario = new ReaLTaiizor.Controls.MetroButton();
            btnComanda = new ReaLTaiizor.Controls.MetroButton();
            btnPedido = new ReaLTaiizor.Controls.MetroButton();
            btnCardapio = new ReaLTaiizor.Controls.MetroButton();
            Principal = new ReaLTaiizor.Forms.ForeverForm();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.BackColor = Color.DimGray;
            gpxPrincipal.Controls.Add(btnSair);
            gpxPrincipal.Controls.Add(btnUsuario);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnPedido);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.ForeColor = SystemColors.ControlText;
            gpxPrincipal.Location = new Point(12, 64);
            gpxPrincipal.MinimumSize = new Size(261, 65);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(776, 363);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            gpxPrincipal.UseWaitCursor = true;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.BaseColor = Color.Red;
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.Location = new Point(716, 18);
            btnSair.Name = "btnSair";
            btnSair.Rounded = false;
            btnSair.Size = new Size(54, 32);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.TextColor = Color.FromArgb(243, 243, 243);
            btnSair.UseWaitCursor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuario.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuario.DisabledForeColor = Color.Gray;
            btnUsuario.Font = new Font("Microsoft Sans Serif", 10F);
            btnUsuario.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnUsuario.HoverColor = Color.FromArgb(95, 207, 255);
            btnUsuario.HoverTextColor = Color.White;
            btnUsuario.IsDerivedStyle = true;
            btnUsuario.Location = new Point(603, 132);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnUsuario.NormalColor = Color.FromArgb(65, 177, 225);
            btnUsuario.NormalTextColor = Color.White;
            btnUsuario.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnUsuario.PressColor = Color.FromArgb(35, 147, 195);
            btnUsuario.PressTextColor = Color.White;
            btnUsuario.Size = new Size(134, 105);
            btnUsuario.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnUsuario.StyleManager = null;
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Usuários";
            btnUsuario.ThemeAuthor = "Taiizor";
            btnUsuario.ThemeName = "MetroLight";
            btnUsuario.UseWaitCursor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnComanda
            // 
            btnComanda.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledForeColor = Color.Gray;
            btnComanda.Font = new Font("Microsoft Sans Serif", 10F);
            btnComanda.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverTextColor = Color.White;
            btnComanda.IsDerivedStyle = true;
            btnComanda.Location = new Point(217, 132);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalTextColor = Color.White;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(134, 105);
            btnComanda.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnComanda.StyleManager = null;
            btnComanda.TabIndex = 2;
            btnComanda.Text = "Comanda";
            btnComanda.ThemeAuthor = "Taiizor";
            btnComanda.ThemeName = "MetroLight";
            btnComanda.UseWaitCursor = true;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnPedido
            // 
            btnPedido.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnPedido.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnPedido.DisabledForeColor = Color.Gray;
            btnPedido.Font = new Font("Microsoft Sans Serif", 10F);
            btnPedido.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnPedido.HoverColor = Color.FromArgb(95, 207, 255);
            btnPedido.HoverTextColor = Color.White;
            btnPedido.IsDerivedStyle = true;
            btnPedido.Location = new Point(413, 132);
            btnPedido.Name = "btnPedido";
            btnPedido.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnPedido.NormalColor = Color.FromArgb(65, 177, 225);
            btnPedido.NormalTextColor = Color.White;
            btnPedido.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedido.PressColor = Color.FromArgb(35, 147, 195);
            btnPedido.PressTextColor = Color.White;
            btnPedido.Size = new Size(134, 105);
            btnPedido.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnPedido.StyleManager = null;
            btnPedido.TabIndex = 1;
            btnPedido.Text = "Pedido Cozinha";
            btnPedido.ThemeAuthor = "Taiizor";
            btnPedido.ThemeName = "MetroLight";
            btnPedido.UseWaitCursor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledForeColor = Color.Gray;
            btnCardapio.Font = new Font("Microsoft Sans Serif", 10F);
            btnCardapio.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverTextColor = Color.White;
            btnCardapio.IsDerivedStyle = true;
            btnCardapio.Location = new Point(25, 132);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalTextColor = Color.White;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.White;
            btnCardapio.Size = new Size(134, 105);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.UseWaitCursor = true;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // Principal
            // 
            Principal.BackColor = Color.FromArgb(42, 42, 42);
            Principal.BaseColor = Color.FromArgb(60, 70, 73);
            Principal.BorderColor = Color.DodgerBlue;
            Principal.Dock = DockStyle.Fill;
            Principal.Font = new Font("Segoe UI", 12F);
            Principal.ForeverColor = Color.FromArgb(35, 168, 109);
            Principal.HeaderColor = Color.FromArgb(45, 47, 49);
            Principal.HeaderMaximize = false;
            Principal.HeaderTextFont = new Font("Segoe UI", 12F);
            Principal.Image = null;
            Principal.Location = new Point(0, 0);
            Principal.MinimumSize = new Size(210, 50);
            Principal.Name = "Principal";
            Principal.Padding = new Padding(1, 51, 1, 1);
            Principal.Sizable = true;
            Principal.Size = new Size(800, 450);
            Principal.TabIndex = 1;
            Principal.Text = "Sistema de comandas";
            Principal.TextColor = Color.FromArgb(234, 234, 234);
            Principal.TextLight = Color.SeaGreen;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpxPrincipal);
            Controls.Add(Principal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.MetroButton btnUsuario;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnPedido;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
        private ReaLTaiizor.Forms.ForeverForm Principal;
        private ReaLTaiizor.Controls.ForeverButtonSticky btnSair;
    }
}