using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projeto1
{


    public partial class frm_fornecedores : Form
    {
         //string connection = Insira a String de conexão;
        bool novo;

        public frm_fornecedores()
        {
            InitializeComponent();

            btn_salvar.Enabled = false;
            btn_buscar.Enabled = true;
            btn_excluir.Enabled = false;
            btn_novoFisíco.Enabled = true;
            btn_novoJuridico.Enabled = true;
            tb_pesquisarFonecedor.Enabled = true;
            tb_codigo.Enabled = false;
            tb_nomefantasia.Enabled = false;
            tb_razaosocial.Enabled = false;
            mkt_cnpj.Enabled = false;
            mkt_cpf.Enabled = false;
            tb_endereco.Enabled = false;
            tb_numeroForncedor.Enabled = false;
            tb_email.Enabled = false;
            tb_bairro.Enabled = false;
            tb_cidade.Enabled = false;
            cb_estado.Enabled = false;
            mkt_telefone.Enabled = false;
            tb_inscricao.Enabled = false;

        }

        public void Analizar_campos()
        {
            string cpf = mkt_cpf.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "").Replace(" ", "");
            string Cnpj = mkt_cnpj.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "").Replace(" ", "").Replace("/", "");
            if (tb_codigo.Text == "")
            {
                MessageBox.Show("Insira o Código ");
            }
            else if (tb_razaosocial.Text == "")
            {
                MessageBox.Show("Insira a Razão Social");
            }

            else if (tb_nomefantasia.Text == "")
            {
                MessageBox.Show("Insira o Nome Fantasia");
            }

            else if (tb_endereco.Text == "")
            {
                MessageBox.Show("Insira o Endereço");
            }
            else if (tb_numeroForncedor.Text == "")
            {
                MessageBox.Show("Insira o Endereço");
            }
            else if (tb_bairro.Text == "")
            {
                MessageBox.Show("Insira o Bairro ");
            }
            else if (tb_email.Text == "")
            {
                MessageBox.Show("Insira o E-mail");
            }
            else if (tb_cidade.Text == "")
            {
                MessageBox.Show("Insira o Cidade");
            }
            
            else if (cb_estado.Text == "")
            {
                MessageBox.Show("Insira o Estado");
            }


            else if (mkt_telefone.Text == "")
            {
                MessageBox.Show("Insira o Telefone");
            }

            else if (tb_inscricao.Text == "")
            {
                MessageBox.Show("Insira a Inscricão Estadual");
            }
        }









        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (novo)
            {
                Analizar_campos();
                string sql = "INSERT INTO FORNECEDOR (RAZSOCIAL_FORNECEDOR, NOMEFANT_FORNECEDOR,END_FORNECEDOR,BAIRRO_FORNECEDOR,CIDADE_FORNECEDOR,UF_FORNECEDOR,TEL_FORNECEDOR,EMAIL_FORNECEDOR,CPF_FORNECEDOR,CNPJ_FORNECEDOR,INSCRESTADUAL_FORNECEDOR, NUM_FORNECEDOR)"
                    + "VALUES (@razao, @nomeFant, @enderecoForn, @bairroForn, @cidadeForn, @estadoForn, @telefoneForn, @emailForn, @cpfForn, @cnpjForn, @InscricaoForn , @numero)";

                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@razao", tb_razaosocial.Text);
                cmd.Parameters.AddWithValue("@nomeFant", tb_nomefantasia.Text);
                cmd.Parameters.AddWithValue("@enderecoForn", tb_endereco.Text);
                cmd.Parameters.AddWithValue("@bairroForn", tb_bairro.Text);
                cmd.Parameters.AddWithValue("@cidadeForn", tb_cidade.Text);
                cmd.Parameters.AddWithValue("@estadoForn", cb_estado.Text);
                cmd.Parameters.AddWithValue("@telefoneForn", mkt_telefone.Text);
                cmd.Parameters.AddWithValue("@emailForn", tb_email.Text);
                cmd.Parameters.AddWithValue("@cpfForn", mkt_cpf.Text);
                cmd.Parameters.AddWithValue("@cnpjForn", mkt_cnpj.Text);
                cmd.Parameters.AddWithValue("@InscricaoForn", tb_inscricao.Text);
                cmd.Parameters.AddWithValue("@numero", tb_numeroForncedor.Text);


                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro incluido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    btn_salvar.Enabled = true;
                    btn_buscar.Enabled = true;
                    tb_pesquisarFonecedor.Enabled = true;
                    tb_codigo.Enabled = false;
                    tb_nomefantasia.Enabled = false;
                    tb_razaosocial.Enabled = false;
                    mkt_cnpj.Enabled = false;
                    mkt_cpf.Enabled = false;
                    tb_endereco.Enabled = false;
                    tb_numeroForncedor.Enabled = false;
                    tb_email.Enabled = false;
                    tb_bairro.Enabled = false;
                    tb_cidade.Enabled = false;
                    cb_estado.Enabled = false;
                    mkt_telefone.Enabled = false;
                    tb_inscricao.Enabled = false;


                    tb_pesquisarFonecedor.Text = " ";
                    tb_codigo.Text = " ";
                    tb_nomefantasia.Text = " ";
                    tb_razaosocial.Text = " ";
                    mkt_cnpj.Text = " ";
                    mkt_cpf.Text = " ";
                    tb_endereco.Text = " ";
                    tb_numeroForncedor.Text = " ";
                    tb_email.Text = " ";
                    tb_bairro.Text = " ";
                    tb_cidade.Text = " ";
                    cb_estado.Text = " ";
                    mkt_telefone.Text = " ";
                    tb_inscricao.Text = " ";
                    
                }
            }
            else
            {
                string sql = "UPDATE FORNECEDOR SET RAZSOCIAL_FORNECEDOR= @razao, NOMEFANT_FORNECEDOR= @nome,END_FORNECEDOR=@endereco, BAIRRO_FORNECEDOR=@bairro, " + "CIDADE_FORNECEDOR=@cidade, UF_FORNECEDOR=@estado, TEL_FORNECEDOR= @telefone, EMAIL_FORNECEDOR= @email, CPF_FORNECEDOR = @cpf, CNPJ_FORNECEDOR= @cnpj, INSCRESTADUAL_FORNECEDOR= @inscricao, NUM_FORNECEDOR= @numero WHERE ID_FORNECEDOR= @id";
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@razao", tb_razaosocial.Text);
                cmd.Parameters.AddWithValue("@nome", tb_nomefantasia.Text);
                cmd.Parameters.AddWithValue("@endereco", tb_endereco.Text);
                cmd.Parameters.AddWithValue("@bairro", tb_bairro.Text);
                cmd.Parameters.AddWithValue("@cidade", tb_cidade.Text);
                cmd.Parameters.AddWithValue("@estado", cb_estado.Text);
                cmd.Parameters.AddWithValue("@telefone", mkt_telefone.Text);
                cmd.Parameters.AddWithValue("@email", tb_email.Text);
                cmd.Parameters.AddWithValue("@cpf", mkt_cpf.Text);
                cmd.Parameters.AddWithValue("@cnpj", mkt_cnpj.Text);
                cmd.Parameters.AddWithValue("@inscricao", tb_inscricao.Text);
                cmd.Parameters.AddWithValue("@numero", tb_numeroForncedor.Text);
                cmd.Parameters.AddWithValue("@id", tb_codigo.Text);

                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    btn_salvar.Enabled = true;
                    btn_buscar.Enabled = true;
                    tb_pesquisarFonecedor.Enabled = true;
                    tb_codigo.Enabled = false;
                    tb_nomefantasia.Enabled = false;
                    tb_razaosocial.Enabled = false;
                    mkt_cnpj.Enabled = false;
                    mkt_cpf.Enabled = false;
                    tb_endereco.Enabled = false;
                    tb_numeroForncedor.Enabled = false;
                    tb_email.Enabled = false;
                    tb_bairro.Enabled = false;
                    tb_cidade.Enabled = false;
                    cb_estado.Enabled = false;
                    mkt_telefone.Enabled = false;
                    tb_inscricao.Enabled = false;


                    tb_pesquisarFonecedor.Text = " ";
                    tb_codigo.Text = " ";
                    tb_nomefantasia.Text = " ";
                    tb_razaosocial.Text = " ";
                    mkt_cnpj.Text = " ";
                    mkt_cpf.Text = " ";
                    tb_endereco.Text = " ";
                    tb_email.Text = " ";
                    tb_bairro.Text = " ";
                    tb_cidade.Text = " ";
                    cb_estado.Text = " ";
                    mkt_telefone.Text = " ";
                    tb_inscricao.Text = " ";
                }



            }
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM FORNECEDOR WHERE ID_FORNECEDOR= @Id";

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", tb_pesquisarFonecedor.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    btn_salvar.Enabled = true;
                    btn_excluir.Enabled = true;
                    btn_novoJuridico.Enabled = true;
                    btn_novoFisíco.Enabled = true;
                    tb_codigo.Enabled = false;
                    tb_nomefantasia.Enabled = true;
                    tb_razaosocial.Enabled = true;
                    mkt_cpf.Enabled = true;
                    mkt_cnpj.Enabled = true;
                    tb_inscricao.Enabled = true;
                    tb_bairro.Enabled = true;
                    tb_cidade.Enabled = true;
                    tb_endereco.Enabled = true;
                    tb_numeroForncedor.Enabled = true;
                    mkt_telefone.Enabled = true;
                    cb_estado.Enabled = true;
                    tb_email.Enabled = true;
                    tb_nomefantasia.Focus();
                    tb_codigo.Text = reader[0].ToString();
                    tb_razaosocial.Text = reader[1].ToString();
                    tb_nomefantasia.Text = reader[2].ToString();
                    tb_endereco.Text = reader[3].ToString();
                    tb_bairro.Text = reader[4].ToString();
                    tb_cidade.Text = reader[5].ToString();
                    cb_estado.Text = reader[6].ToString();
                    mkt_telefone.Text = reader[7].ToString();
                    tb_email.Text = reader[8].ToString();
                    mkt_cpf.Text = reader[9].ToString();
                    mkt_cnpj.Text = reader[10].ToString();
                    tb_inscricao.Text = reader[11].ToString();
                    tb_numeroForncedor.Text = reader[12].ToString();
                    novo = false;
                }
                else
                    MessageBox.Show("Nenhum registro encontrado com o Id informado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM FORNECEDOR WHERE ID_FORNECEDOR=@Id";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", tb_codigo.Text);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
                btn_salvar.Enabled = false;
                btn_buscar.Enabled = true;
                btn_excluir.Enabled = false;
                btn_novoFisíco.Enabled = true;
                btn_novoJuridico.Enabled = true;
                tb_pesquisarFonecedor.Enabled = true;
                tb_codigo.Enabled = false;
                tb_nomefantasia.Enabled = false;
                tb_razaosocial.Enabled = false;
                mkt_cnpj.Enabled = false;
                mkt_cpf.Enabled = false;
                tb_endereco.Enabled = false;
                tb_numeroForncedor.Enabled = false;
                tb_email.Enabled = false;
                tb_bairro.Enabled = false;
                tb_cidade.Enabled = false;
                cb_estado.Enabled = false;
                mkt_telefone.Enabled = false;
                tb_inscricao.Enabled = false;

                tb_pesquisarFonecedor.Text = " ";
                tb_codigo.Text = " ";
                tb_nomefantasia.Text = " ";
                tb_razaosocial.Text = " ";
                mkt_cnpj.Text = " ";
                mkt_cpf.Text = " ";
                tb_endereco.Text = " ";
                tb_numeroForncedor.Text = " ";
                tb_email.Text = " ";
                tb_bairro.Text = " ";
                tb_cidade.Text = " ";
                cb_estado.Text = " ";
                mkt_telefone.Text = " ";
                tb_inscricao.Text = " ";

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_fornecedores_Load(object sender, EventArgs e)
        {

        }

        private void rbt_fisico_CheckedChanged(object sender, EventArgs e)
        {
            lb_cpf.Visible = true;
            mkt_cpf.Visible = true;

            lb_cnpj.Visible = false;
            mkt_cnpj.Visible = false;

        }

        private void rbt_juridico_CheckedChanged(object sender, EventArgs e)
        {
            lb_cpf.Visible = false;
            mkt_cpf.Visible = false;

            lb_cnpj.Visible = true;
            mkt_cnpj.Visible = true;
        }

        private void mkt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_salvar.Enabled = true;
            btn_buscar.Enabled = false;
            tb_pesquisarFonecedor.Enabled = false;
            tb_codigo.Enabled = false;
            tb_nomefantasia.Enabled = true;
            tb_razaosocial.Enabled = true;
            mkt_cnpj.Enabled = true;
            mkt_cpf.Enabled = false;
            tb_endereco.Enabled = true;
            tb_numeroForncedor.Enabled = true;
            tb_email.Enabled = true;
            tb_bairro.Enabled = true;
            tb_cidade.Enabled = true;
            cb_estado.Enabled = true;
            mkt_telefone.Enabled = true;
            tb_inscricao.Enabled = true;


            tb_pesquisarFonecedor.Text = " ";
            tb_codigo.Text = " ";
            tb_nomefantasia.Text = " ";
            tb_razaosocial.Text = " ";
            mkt_cnpj.Text = " ";
            mkt_cpf.Text = " ";
            tb_endereco.Text = " ";
            tb_email.Text = " ";
            tb_bairro.Text = " ";
            tb_cidade.Text = " ";
            cb_estado.Text = " ";
            mkt_telefone.Text = " ";
            tb_inscricao.Text = " ";
            novo = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_salvar.Enabled = true;
            btn_buscar.Enabled = false;
            tb_pesquisarFonecedor.Enabled = false;
            tb_codigo.Enabled = false;
            tb_nomefantasia.Enabled = true;
            tb_razaosocial.Enabled = true;
            mkt_cnpj.Enabled = false;
            mkt_cpf.Enabled = true;
            tb_endereco.Enabled = true;
            tb_numeroForncedor.Enabled = true;
            tb_email.Enabled = true;
            tb_bairro.Enabled = true;
            tb_cidade.Enabled = true;
            cb_estado.Enabled = true;
            mkt_telefone.Enabled = true;
            tb_inscricao.Enabled = true;

            tb_pesquisarFonecedor.Text = " ";
            tb_codigo.Text = " ";
            tb_nomefantasia.Text = " ";
            tb_razaosocial.Text = " ";
            mkt_cnpj.Text = " ";
            mkt_cpf.Text = " ";
            tb_endereco.Text = " ";
            tb_numeroForncedor.Text = " ";
            tb_email.Text = " ";
            tb_bairro.Text = " ";
            tb_cidade.Text = " ";
            cb_estado.Text = " ";
            mkt_telefone.Text = " ";
            tb_inscricao.Text = " ";
            novo = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_salvar.Enabled = false;
            btn_buscar.Enabled = true;
            btn_excluir.Enabled = false;
            btn_novoFisíco.Enabled = true;
            btn_novoJuridico.Enabled = true;
            tb_pesquisarFonecedor.Enabled = true;
            tb_codigo.Enabled = false;
            tb_nomefantasia.Enabled = false;
            tb_razaosocial.Enabled = false;
            mkt_cnpj.Enabled = false;
            mkt_cpf.Enabled = false;
            tb_endereco.Enabled = false;
            tb_numeroForncedor.Enabled = false;
            tb_email.Enabled = false;
            tb_bairro.Enabled = false;
            tb_cidade.Enabled = false;
            cb_estado.Enabled = false;
            mkt_telefone.Enabled = false;
            tb_inscricao.Enabled = false;

            tb_pesquisarFonecedor.Text = " ";
            tb_codigo.Text = " ";
            tb_nomefantasia.Text = " ";
            tb_razaosocial.Text = " ";
            mkt_cnpj.Text = " ";
            mkt_cpf.Text = " ";
            tb_endereco.Text = " ";
            tb_numeroForncedor.Text = " ";
            tb_email.Text = " ";
            tb_bairro.Text = " ";
            tb_cidade.Text = " ";
            cb_estado.Text = " ";
            mkt_telefone.Text = " ";
            tb_inscricao.Text = " ";
        }
    }
}
