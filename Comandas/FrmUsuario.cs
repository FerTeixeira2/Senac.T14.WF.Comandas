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
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == 1)
                    .FirstOrDefault();
                usuario.Name = "João";
                usuario.Email = "jo@jo.com";
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
                novoUsuario.Name = "Fernando";
                novoUsuario.Email = "fe@fer.com";
                novoUsuario.Password = "123";

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
