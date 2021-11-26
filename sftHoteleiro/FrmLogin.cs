using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sftHoteleiro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166 , this.Height / 2 - 170) ;
            pnlLogin.Visible = true;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ChamandoLogin();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamandoLogin();
            }
        }

        private void ChamandoLogin()
        {
            if (txtbUsuario.Text == "")
            {
                MessageBox.Show("Preencha o Usuário");
                txtbUsuario.Focus();
                return;
            }
            if (txtbSenha.Text == "")
            {
                MessageBox.Show("Preencha a Senha");
                txtbSenha.Focus();
                return;
            }

            //Aqui vai ir o Código para o Login
            FrmMenu form = new FrmMenu();
            //this.Hide();
            Limpar();
            form.Show();
        }
        private void Limpar()
        {
            txtbUsuario.Text = "";
            txtbSenha.Text = "";
            txtbUsuario.Focus();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
