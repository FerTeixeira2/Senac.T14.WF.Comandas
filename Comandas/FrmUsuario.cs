using Microsoft.EntityFrameworkCore;
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
    public partial class FrmUsuario : Form
    {
        private bool ehNovo;

        public FrmUsuario()
        {
            InitializeComponent();
            //metodo que lista os usuarios
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            //1.conectar no banco
            using (var banco = new AppDbContext())
            {
                //2.converteu os usuarios cadastrados em um lista e armazenou = SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                //3.popular a tabela na tela DataGridViews
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // quando o if so tem uma linha n precisa colocar chaves {}!
            if (ehNovo)
                CriarUsuario();
            else
                AtualizarUsuario();

            desabilitarCampos();
            ListarUsuarios();
            limparCampos();
        }


        private void limparCampos()
        {
            txtId.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
        }

        private void AtualizarUsuario()
        {
            //consulta um usuario na tabela usando o ID da tela
            using (var banco = new AppDbContext())
            {
                //consulta um usuario na tabela usando o id da tela
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.Text))
                    .FirstOrDefault();
                usuario.Name = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Password = txtSenha.Text;
                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new AppDbContext())
            {
                //criar um novo usuário
                var novoUsuario = new Usuario();
                //atribuimos as propriedades do usuário.
                novoUsuario.Name = txtNome.Text;
                novoUsuario.Email = txtEmail.Text;
                novoUsuario.Password = txtSenha.Text;

                //salvar as alterações(INSERT INTO usuario)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso.");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            habilitarCampos();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //indica que esta editando um usuario
            ehNovo = false;
            habilitarCampos();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            //conectar no banco
            using (var banco = new AppDbContext())
            {
                //realizar a consulta na tabela usuarios
                var usuarios = banco.Usuarios.ToList();
                //popular os dados do grid(dataGridViews)
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verrifica se o indice da linha eh maior ou igual a 0
            //saber se existe uma linha selecionada 
            if(e.RowIndex >= 0)
            {
                //mensagem "Linha selecionada 1"
                //MessageBox.Show("Linha selecionada " + (e.RowIndex + 1));

                //obter dados da linha
                var id = dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["Password"].Value.ToString();

                txtId.Text = id;
                txtNome.Text = nome;
                txtEmail.Text = email;
                txtSenha.Text = senha;
            }
        }
    }
}
