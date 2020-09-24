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
    public partial class Cardapio : Form
    {


        public Cardapio()
        {
            InitializeComponent();
            botao();
        }
        double tamanho;
        double bebida;
        double total;

        public void botao()
        {
            total = bebida + tamanho;







            lbTotal.Text = total.ToString();

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

            
            if (bebida1.Checked == true)
            {
                bebida = 9.90;

            }
            if (bebida2.Checked == true)
            {
                bebida = 8.90;
            }
            if (bebida3.Checked == true)
            {
                bebida = 5.90;
            }
            if (bebida4.Checked == true)
            {
                bebida = 25.90;
            }
        }

        private void tamanhoPizza_Enter(object sender, EventArgs e)
        {
            

            if (tamanho1.Checked == true)
            {
                tamanho = 19.90;
            }
            if (tamanho2.Checked == true)
            {
                tamanho = 29.90;
            }
            if (tamanho3.Checked == true)
            {
                tamanho = 45.90;
            }
            
        }

        private void bebida1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            
        }
  

    private void lbTotal_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
  }
}
  
