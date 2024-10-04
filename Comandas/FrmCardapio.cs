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
        //variaveis locais
        public int ID { get; set; }
        public string? TITULO { get; set; }
        public string? DESCRICAO { get; set; }
        public decimal PRECO { get; set; }
        public bool POSSUI_PREPARO { get; set; }

        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        public void ListarCardapios()
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
            new FrmCardapioCad(ehNovo, this).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {   
            //exibe uma mensagem de confirmação para o usuario
            var result = MessageBox.Show(
                $"Você realmente deseja excluir {TITULO} ?", 
                "Excluir Cardápio", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            //se o usuario clicou em não, para o método
            if (result == DialogResult.No)
            {
                //para o método
                return;
            }
            
            //chamar o método excluir
            if(ExcluirCardapio(ID))
            {
                //atualza a tabela
                ListarCardapios();
                //exibe a mensagem
                MessageBox.Show($"Cardápio '{TITULO}' excluído com sucesso!");
                //desabilida o botão excluir
                btnExcluir.Enabled = false;
            }
        }

        private bool ExcluirCardapio(int iD)
        {
            //conectar no banco
            using(var banco = new AppDbContext())
            {
                //buscar o cardápio através do id
                //SELECT * FROM Cardapio WHERE id = @id
                var card = banco.Cardapios.First(c => c.Id == iD);

                //avisar o banco que vai excluir 
                banco.Cardapios.Remove(card);

                //confirmar a exclusão(ação)
                banco.SaveChanges();
            }
            return true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo, ID, TITULO, DESCRICAO, PRECO, POSSUI_PREPARO, this).ShowDialog();
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
