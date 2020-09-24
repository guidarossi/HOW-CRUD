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
    
    public partial class DadosUsuario : Form
    {

        private MySqlConnectionStringBuilder conectaBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();//Integração com o Banco de dados
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "cadastropizzaria";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            return conexaoBD;
        }
        public DadosUsuario()
        {
            InitializeComponent();
        }
        private void DadosUsuario_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";                                                     //Integração com o Banco de dados
            conexaoBD.Database = "cadastropizzaria";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexacoBD.Open();
                
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM idcadastropizzaria WHERE Email = '" + Usuario.Email + "'"; //Puxa todos os dados vinculados ao usuario que fez login
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridConta.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//CPF
                    row.Cells[3].Value = reader.GetString(3);//TELEFONE
                    row.Cells[4].Value = reader.GetString(4);//ENDERECO
                    row.Cells[5].Value = reader.GetString(5);//CEP
                    row.Cells[6].Value = reader.GetString(6);//EMAIL/LOGIN
                    row.Cells[7].Value = reader.GetString(7);//SENHA
                    dataGridConta.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem conexão!");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conectaBanco();//Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexacoBD.Open();
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                if (txtAtualizaSenha.Text != txtConfirmaSenha.Text) //Verificação de senha, se não forem iguais ERRO
                {
                    MessageBox.Show("Senha incorreta, tente novamente.");
                    txtConfirmaSenha.BackColor = Color.FromArgb(255, 192, 203); //
                }
                else if (txtAtualizaSenha.Text == txtConfirmaSenha.Text) //Verificação de senha, se iguais faz o procedimento de editar cadastro
                {

                    comandoMySql.CommandText = "UPDATE  idcadastropizzaria SET nomeCliente = '" + txtAtualizaNome.Text + "'," + "CPF = '" + maskedTextAtualizaCPF.Text + "', " + "Telefone = '" + maskedTextAtualizaTelefone.Text + "'," + "Endereco = '" + txtAtualizaEndereco.Text + "', " + "CEP = '" + maskedTextAtualizaCEP.Text + "'," + "Email = '" + txtAtualizaEmail.Text + "', " + "Senha = '" + txtAtualizaSenha.Text + "' WHERE idcadastropizzaria.idCliente = " + txtID.Text + "";
                    comandoMySql.ExecuteNonQuery();


                    realizaConexacoBD.Close();

                    MessageBox.Show("Cadastro atualizado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel atualizar o cadastro."); //Mensagem de alerta caso não tenha sido realizado o cadastro
            }
        }
        private void dataGridConta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridConta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridConta.CurrentRow.Selected = true;

                //preenche os textbox com as células da linha selecionada
                txtID.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
                txtAtualizaNome.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                maskedTextAtualizaCPF.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnCpf"].FormattedValue.ToString();
                maskedTextAtualizaTelefone.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnTelefone"].FormattedValue.ToString();
                txtAtualizaEndereco.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnEndereco"].FormattedValue.ToString();
                maskedTextAtualizaCEP.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnCep"].FormattedValue.ToString();
                txtAtualizaEmail.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnEmail"].FormattedValue.ToString();
                txtAtualizaSenha.Text = dataGridConta.Rows[e.RowIndex].Cells["ColumnSenha"].FormattedValue.ToString();
            }
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conectaBanco();//Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL

            realizaConexacoBD.Open();

            if (txtAtualizaSenha.Text != txtConfirmaSenha.Text) //Verificação de senha, se não forem iguais ERRO
            {
                MessageBox.Show("Senha incorreta, tente novamente.");
                txtConfirmaSenha.BackColor = Color.FromArgb(255, 192, 203); //Altera a cor do textbox  
            }
            else if (txtAtualizaSenha.Text == txtConfirmaSenha.Text) //Verificação de senha, se iguais faz o procedimento de deleter cadastro
            {
                comandoMySql.CommandText = "DELETE FROM idcadastropizzaria WHERE idCliente = '" + txtID.Text + "'";
                comandoMySql.ExecuteNonQuery();
                realizaConexacoBD.Close();

                MessageBox.Show("Cadastro deletado, até mais...");

                //Conta deletada, volta a pagina inicial da aplicação
                Inicio voltaInicio = new Inicio();
                this.Hide();
                voltaInicio.ShowDialog();
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Volta tela anterior
            ContaCardapio volta = new ContaCardapio();
            this.Hide();
            volta.ShowDialog();
        }
    }
}
