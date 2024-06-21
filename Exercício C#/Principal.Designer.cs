namespace Exercício_C_
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new ReaLTaiizor.Controls.CyberButton();
            btnChamados = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Alpha = 20;
            btnUsuario.BackColor = Color.Transparent;
            btnUsuario.Background = true;
            btnUsuario.Background_WidthPen = 4F;
            btnUsuario.BackgroundPen = true;
            btnUsuario.ColorBackground = Color.FromArgb(37, 52, 68);
            btnUsuario.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnUsuario.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnUsuario.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnUsuario.ColorLighting = Color.FromArgb(29, 200, 238);
            btnUsuario.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnUsuario.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnUsuario.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnUsuario.Effect_1 = true;
            btnUsuario.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnUsuario.Effect_1_Transparency = 25;
            btnUsuario.Effect_2 = true;
            btnUsuario.Effect_2_ColorBackground = Color.White;
            btnUsuario.Effect_2_Transparency = 20;
            btnUsuario.Font = new Font("Arial", 11F);
            btnUsuario.ForeColor = Color.FromArgb(245, 245, 245);
            btnUsuario.Lighting = false;
            btnUsuario.LinearGradient_Background = false;
            btnUsuario.LinearGradientPen = false;
            btnUsuario.Location = new Point(87, 138);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.PenWidth = 15;
            btnUsuario.Rounding = true;
            btnUsuario.RoundingInt = 70;
            btnUsuario.Size = new Size(250, 130);
            btnUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUsuario.TabIndex = 0;
            btnUsuario.Tag = "Cyber";
            btnUsuario.TextButton = "Usuarios";
            btnUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUsuario.Timer_Effect_1 = 5;
            btnUsuario.Timer_RGB = 300;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnChamados
            // 
            btnChamados.Alpha = 20;
            btnChamados.BackColor = Color.Transparent;
            btnChamados.Background = true;
            btnChamados.Background_WidthPen = 4F;
            btnChamados.BackgroundPen = true;
            btnChamados.ColorBackground = Color.FromArgb(37, 52, 68);
            btnChamados.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnChamados.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnChamados.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnChamados.ColorLighting = Color.FromArgb(29, 200, 238);
            btnChamados.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnChamados.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnChamados.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnChamados.Effect_1 = true;
            btnChamados.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnChamados.Effect_1_Transparency = 25;
            btnChamados.Effect_2 = true;
            btnChamados.Effect_2_ColorBackground = Color.White;
            btnChamados.Effect_2_Transparency = 20;
            btnChamados.Font = new Font("Arial", 11F);
            btnChamados.ForeColor = Color.FromArgb(245, 245, 245);
            btnChamados.Lighting = false;
            btnChamados.LinearGradient_Background = false;
            btnChamados.LinearGradientPen = false;
            btnChamados.Location = new Point(463, 138);
            btnChamados.Name = "btnChamados";
            btnChamados.PenWidth = 15;
            btnChamados.Rounding = true;
            btnChamados.RoundingInt = 70;
            btnChamados.Size = new Size(234, 130);
            btnChamados.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnChamados.TabIndex = 1;
            btnChamados.Tag = "Cyber";
            btnChamados.TextButton = "Chamados";
            btnChamados.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnChamados.Timer_Effect_1 = 5;
            btnChamados.Timer_RGB = 300;
            btnChamados.Click += btnChamados_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChamados);
            Controls.Add(btnUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnUsuario;
        private ReaLTaiizor.Controls.CyberButton btnChamados;
    }
}
