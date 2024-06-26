namespace Exercício_C_
{
    partial class FrmChamados
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
            BtnVoltar = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Alpha = 20;
            BtnVoltar.BackColor = Color.Transparent;
            BtnVoltar.Background = true;
            BtnVoltar.Background_WidthPen = 4F;
            BtnVoltar.BackgroundPen = true;
            BtnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            BtnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            BtnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BtnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            BtnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            BtnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BtnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BtnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnVoltar.Effect_1 = true;
            BtnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BtnVoltar.Effect_1_Transparency = 25;
            BtnVoltar.Effect_2 = true;
            BtnVoltar.Effect_2_ColorBackground = Color.White;
            BtnVoltar.Effect_2_Transparency = 20;
            BtnVoltar.Font = new Font("Arial", 11F);
            BtnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            BtnVoltar.Lighting = false;
            BtnVoltar.LinearGradient_Background = false;
            BtnVoltar.LinearGradientPen = false;
            BtnVoltar.Location = new Point(673, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.PenWidth = 15;
            BtnVoltar.Rounding = true;
            BtnVoltar.RoundingInt = 70;
            BtnVoltar.Size = new Size(103, 40);
            BtnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnVoltar.TabIndex = 0;
            BtnVoltar.Tag = "Cyber";
            BtnVoltar.TextButton = "Voltar";
            BtnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnVoltar.Timer_Effect_1 = 5;
            BtnVoltar.Timer_RGB = 300;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // FrmChamados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmChamados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chamados";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton BtnVoltar;
    }
}