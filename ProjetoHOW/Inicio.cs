using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoHOW
{
   
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conectaBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";                                                     //Integração com o Banco de dados
            conexaoBD.Database = "cadastropizzaria";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            return conexaoBD;
        }
        private void btbEntrar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conectaBanco();
            //Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());

            string Email = txtLogin.Text; 
            string Senha = txtSenha.Text;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Senha)) //Verifica se todos os campos estão preenchidos
            {
                MessageBox.Show("Preencha todos os campos!");//Mensagem de alerta caso tenha algum campo não preenchido
                txtLogin.BackColor = Color.FromArgb(255, 192, 203); //Altera a cor do textbox
                txtSenha.BackColor = Color.FromArgb(255, 192, 203); //Altera a cor do textbox
                txtLogin.Clear(); //Limpa os campos do textbox
                txtSenha.Clear(); //Limpa os campos do textbox
            }
            else
                try
                {
                    realizaConexacoBD.Open(); //Abre a conexão com o banco
                    MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                    MySqlCommand comandoMySq2 = realizaConexacoBD.CreateCommand(); //Crio um comando SQL

                    comandoMySql.CommandText = "SELECT Email, Senha FROM idcadastropizzaria WHERE Email = '" + Email + "' AND Senha = '" + Senha + "'"; //Busca no meu banco de dados se existe o login e senha
                    bool verifica = comandoMySql.ExecuteReader().HasRows;

                    comandoMySq2.CommandText = "SELECT idCliente FROM idcadastropizzaria";

                    if (verifica == true) //Se login e senha estiverem correstos
                    {
                        MessageBox.Show("Login efetuado com sucesso!"); //Mensagem de alerta caso o login seja efetuado
                        Usuario.Email = txtLogin.Text;
                        Usuario.Senha = txtSenha.Text;
                        ContaCardapio OutroForm = new ContaCardapio(); //Login efetuado com sucesso abre o cardapio/usuario
                        this.Hide();
                        OutroForm.ShowDialog();
                    }
                    else //Se login e senha nao estiverem correstos
                    {
                        MessageBox.Show("Nome ou senha incorretos!");
                        txtLogin.BackColor = Color.FromArgb(255, 192, 203); //Altera a cor do textbox
                        txtSenha.BackColor = Color.FromArgb(255, 192, 203); //Altera a cor do textbox
                        txtLogin.Clear(); //Limpa os campos do textbox
                        txtSenha.Clear(); //Limpa os campos do textbox
                    }
                }
                catch { }
                     realizaConexacoBD.Close(); // encerra a conexao com o banco de dados
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro OutroForm = new TelaCadastro(); //abre tela para criar um novo cadastro
            this.Hide();
            OutroForm.ShowDialog();
        }  
    }
}
