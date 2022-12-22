using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCliente2Sem
{
    public partial class ConsClientecs : Form
    {
        Cliente cliente = new Cliente();

        public ConsClientecs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cliente.setCpf(txtCpf.Text);
        }     

        private void btConsu_Click(object sender, EventArgs e)
        {
            //Conexão com Database
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database= AG_VEICULOS; password=''");
            conexao.Open();
            //Comando SELECT para consulta e parametros
            MySqlCommand sqlQuery = new MySqlCommand("SELECT nome, nascimento, sexo, email, celular, residencial, cpf, estado, logradouro, cep, numero, " +
                $"complemento, cidade, renavam, chassi, modelo, marca, cor, ano, placa, cambio, combustivel, fipe FROM CLIENTE WHERE CPF = @cpf", conexao);

            sqlQuery.Parameters.Clear();
            sqlQuery.Parameters.Add("@cpf", MySqlDbType.String).Value = txtCpf.Text;
            sqlQuery.CommandType = CommandType.Text; //Executa o comando            
            MySqlDataReader dr; //Recebe os valores do DB
            dr = sqlQuery.ExecuteReader();
            dr.Read(); //Insere os valores do DB nos componentes no forms de consulta.

            txtNome.Text = dr.GetString(0);
            txtNasc.Text = dr.GetString(1);
            txtSexo.Text = dr.GetString(2);
            txtEmail.Text = dr.GetString(3);
            txtCel.Text = dr.GetString(4);
            txtReside.Text = dr.GetString(5);
            txtCpf.Text = dr.GetString(6);
            txtEstado.Text = dr.GetString(7);
            txtRua.Text = dr.GetString(8);
            txtCep.Text = dr.GetString(9);
            txtNum.Text = dr.GetString(10);
            txtComple.Text = dr.GetString(11);
            txtCidade.Text = dr.GetString(12);
            txtRenavam.Text = dr.GetString(13);
            txtChassi.Text = dr.GetString(14);
            txtModelo.Text = dr.GetString(15);
            txtMarca.Text = dr.GetString(16);
            txtCor.Text = dr.GetString(17);
            txtAno.Text = dr.GetString(18);
            txtPlaca.Text = dr.GetString(19);
            txtCambio.Text = dr.GetString(20);
            txtCombus.Text = dr.GetString(21);
            txtFipe.Text = dr.GetString(22);

            try
            {
                btConsu.PerformClick();
            }
            catch (Exception ex) //Erro em salvar
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close(); //Fecha conexão com o Data
            }
        }
    }      
}
