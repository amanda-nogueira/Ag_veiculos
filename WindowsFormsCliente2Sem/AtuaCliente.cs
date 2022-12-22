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
    public partial class AtuaCliente : Form
    {
        Cliente cliente = new Cliente();
        Veiculo veiculo = new Veiculo();

        public AtuaCliente()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            cliente.setEmail(txtEmail.Text);
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {
            cliente.setCelular(txtCel.Text);
        }

        private void txtReside_TextChanged(object sender, EventArgs e)
        {
            cliente.setResidencial(txtReside.Text); 
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            cliente.setCpf(txtCpf.Text);
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            cliente.setLog(txtRua.Text);
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            cliente.setCep(txtCep.Text);
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            cliente.setNumero(txtNum.Text);
        }

        private void txtComple_TextChanged(object sender, EventArgs e)
        {
            cliente.setComplemento(txtComple.Text);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            cliente.setCidade(txtCidade.Text);
        }

        private void txtRenavam_TextChanged(object sender, EventArgs e)
        {
            veiculo.setRenavam(txtRenavam.Text);
        }

        private void txtChassi_TextChanged(object sender, EventArgs e)
        {
            veiculo.setChassi(txtChassi.Text);
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            veiculo.setModelo(txtModelo.Text);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            veiculo.setMarca(txtMarca.Text);
        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            veiculo.setCor(txtCor.Text);
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            veiculo.setPlaca(txtPlaca.Text);
        }

        private void btCadastar_Click(object sender, EventArgs e)  { }

        private void groupBox1_Enter(object sender, EventArgs e) {  }

        private void label2_Click(object sender, EventArgs e) { }

        private void btCadastar_Click_1(object sender, EventArgs e)
        {
            //Conexão com Database
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database= AG_VEICULOS; password=''");
            //Modelo da tabela e como vai atualizar as informações
            MySqlCommand sqlQuery = new MySqlCommand("UPDATE CLIENTE SET nome '" + txtNome.Text + "', nascimento='" + dateNasc.Text + "', sexo='" + checkedListBox1.Text +"', email='" + txtEmail.Text + "', celular='" + txtCel.Text + "', residencial='" +
                txtReside.Text + "', estado='" + cBEstado.Text + "', logradouro='" + txtRua.Text + "', cep='" + txtCep.Text + "', numero='" + txtNum + "', complemento='" +
                txtComple.Text + "', cidade='" + txtCidade.Text + "', renavam='" + txtRenavam.Text + "', chassi='" + txtChassi + "', modelo='" + txtModelo.Text + "', marca='" +
                txtMarca.Text + "', cor='" + txtCor.Text + "', ano='" + cBAno.Text + "', placa='" + txtPlaca + "', cambio='" + cbCambio.Text + "', combustivel='" +
                cbCombu.Text + "', fipe='" + txtFipe.Text + "' , WHERE cpf ='" + txtCpf.Text, conexao);
            try
            {
                conexao.Open();//Abrir conexão
                sqlQuery.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso!", "Salvar dados [DB]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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