using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO1
{
    public partial class frmCadastro : Form

    {
        String nome = "";
        int cpf;
        String email = "";
        int telefone;
        String dnascimento;
        string mnascimento = "";
        int anascimento;
        String cep = "";
        string endereco = "";
        int numero;
        string cidade = "";

        


        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cep = txtCEP.Text;

            switch (cep)
            {
                case "06730150":
                    txtEnd.Text = "Rua das Papoulas - Piratininga";
                    cmbCidade.Text = "Osasco";
                    break;
                case "06720122":
                    txtEnd.Text = "Rua das Casas - Munhoz Junior";
                    cmbCidade.Text = "Osasco";
                    break;

                default:

                    break;

            }
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            cpf = Int32.Parse(txtCPF.Text);
            email = txtEmail.Text;
            telefone = Int32.Parse(txtTelefone.Text);
            dnascimento = cmbDia.Text;
            mnascimento = cmbMes.Text;
            anascimento = Int32.Parse(cmbAno.Text);
            cep = txtCEP.Text;
            endereco = txtEnd.Text;
            numero = Int32.Parse(textBox1.Text);
            cidade = cmbCidade.Text;


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
