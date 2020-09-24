using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHOW
{
    public partial class ContaCardapio : Form
    {
        public ContaCardapio()
        {
             InitializeComponent();
        }
        private void btnCardapio_Click_1(object sender, EventArgs e)
        {
            Cardapio OutroForm = new Cardapio(); 
            this.Hide();
            OutroForm.ShowDialog();
        }

        private void btnMinhaConta_Click_1(object sender, EventArgs e)
        {
            DadosUsuario OutroForm = new DadosUsuario();
            this.Hide();
            OutroForm.ShowDialog();
        }
    }
}
