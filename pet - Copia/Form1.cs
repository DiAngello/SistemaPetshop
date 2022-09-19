using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.TopLevel = false;
            cadastro.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(cadastro);
            cadastro.Show();

            PanelSelect.Top = Cadastro.Top;
        }

        private void Financeiro_Click(object sender, EventArgs e)
        {
            PanelSelect.Top = Financeiro.Top;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void PanelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelCentral.Controls.Clear();
            PanelSelect.Top = Inicio.Top;

        }

        private void Atendimento_Click(object sender, EventArgs e)
        {
            PanelSelect.Top = Atendimento.Top;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //Minimizar
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
