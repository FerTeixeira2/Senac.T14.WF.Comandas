using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmCardapio : Form
    {
        public int ID { get; private set; }
        public string? TITULO { get; private set; }
        public string? DESCRICAO { get; private set; }
        public decimal PRECO { get; private set; }
        public bool POSSUI_PREPARO { get; private set; }

        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        private void ListarCardapios()
        {
            using (var banco = new AppDbContext())
            {
                var cardapios = banco.Cardapios.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            var ehNovo = true;
            new FrmCardapioCad(ehNovo).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo, ID, TITULO, DESCRICAO, PRECO, POSSUI_PREPARO).ShowDialog();
        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obter o número da linha clicada
            var numeroLinha = e.RowIndex;
            //exibe uma mensagme na tela com o número da linha
            MessageBox.Show(numeroLinha.ToString());

            if(numeroLinha >= 0)
            {
                var id = dgvCardapio.Rows[numeroLinha].Cells["id"].Value.ToString();
                //popular as outras colunas
                var titulo = dgvCardapio.Rows[numeroLinha].Cells["id"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["titulo"].Value.ToString();
                var preco = dgvCardapio.Rows[numeroLinha].Cells["preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["possuiPreparo"].Value.ToString();

                //converter para os tipos corretos
                ID = int.Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUI_PREPARO = bool.Parse(possuiPreparo);

                //habilitar o botão editar e excluir 
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
