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
    public partial class FrmCardapioCad : Form
    {
        //variavel que indica se esta criando um novo cardapio
        bool ehNovo = false;
        private FrmCardapio _frmCardapio;

        public int ID { get; }
        public string? TITULO { get; }
        public string? DESCRICAO { get; }
        public decimal PRECO { get; }
        public bool POSSUI_PREPARO { get; }

        public FrmCardapioCad(bool acao, FrmCardapio frmCardapio)
        {
            ehNovo = acao;
            _frmCardapio = frmCardapio;
            InitializeComponent();
        }

        public FrmCardapioCad(bool acao, int iD, string? tITULO, string? dESCRICAO, decimal pRECO, bool pOSSUI_PREPARO, FrmCardapio frmCardapio) : this(acao, frmCardapio)
        {
            ehNovo = acao;
            InitializeComponent();

            ID = iD;
            TITULO = tITULO;
            DESCRICAO = dESCRICAO;
            PRECO = pRECO;
            POSSUI_PREPARO = pOSSUI_PREPARO;

            PopularCampos();
        }

        private void PopularCampos()
        {
            txtId.Text = ID.ToString();
            txtTitulo.Text = TITULO;
            txtDescricao.Text = DESCRICAO;
            txtPreco.Text = PRECO.ToString();
            chkPreparo.Checked = POSSUI_PREPARO;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //se o form esta em modo de inclusão
            if (ehNovo)
            {
                //executa o método que realiza o INSERT na tabela
                AdicionarCardapio();
            }
            else
            {
                //executa o método que realiza o UPDATE na tabela
                AtualizarCardapio();
            }

            _frmCardapio.ListarCardapios();

            //fecha a tela
            Close();
        }

        private void AtualizarCardapio()
        {
            using (var banco = new AppDbContext())
            {
                var cardapio = banco.Cardapios.FirstOrDefault(c => c.Id == int.Parse(txtId.Text));

                cardapio.Titulo = txtTitulo.Text;
                cardapio.Descricao = txtDescricao.Text;
                cardapio.Preco = decimal.Parse(txtPreco.Text);
                cardapio.PossuiPreparo = chkPreparo.Checked;
                banco.SaveChanges();
            }
        }

        private void AdicionarCardapio()
        {
            //usar o banco de dados
            //cria uma variavel banco que extancia uma conexao com o banco
            using (var banco = new AppDbContext())
            {
                var novoCardapio = new Cardapio()
                {
                    Titulo = txtTitulo.Text,
                    Descricao = txtDescricao.Text,
                    Preco = decimal.Parse(txtPreco.Text),
                    PossuiPreparo = chkPreparo.Checked
                };

                banco.Cardapios.Add(novoCardapio);
                banco.SaveChanges();
            }
        }
    }
}
