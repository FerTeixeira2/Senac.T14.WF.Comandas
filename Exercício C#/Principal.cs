namespace Exercício_C_
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            new FrmChamados().ShowDialog();
        }
    }
}
