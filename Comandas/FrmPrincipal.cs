using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        //metodo (visibilidade=private, retorno=void, nome)
        private void CriarBancoDeDados()
        {
            //criar uma variavel do tipo AppDbContext
            //usar a variavel e acessar o contexto
            //executar a migração == F5

            using (var banco = new AppDbContext())
            {
                //executar a migração
                banco.Database.Migrate();
            }
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}