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
        }

        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {   
                //consulta um usuario na tabela usando o id da tela
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.Text) )
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
        }
    }
}
