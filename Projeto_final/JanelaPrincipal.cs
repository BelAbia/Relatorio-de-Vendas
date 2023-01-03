using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final
{
    public partial class JanelaPrincipal : Form
    {
        //Primeiro commit 03/01/23
        public JanelaPrincipal()
        {
            InitializeComponent();
        }



        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            if (ChecarDados())
            {
                AddRelatorio();
                LimparDados();
            }
            else
            {
                MessageBox.Show("Voce nao completou todos os dados corretamente.", "Erro: ");
            }
        }

        private bool ChecarDados()
        {
            if (!String.IsNullOrEmpty(tb_ID.Text) &&
                !String.IsNullOrEmpty(tb_Nome.Text) &&
                !String.IsNullOrEmpty(tb_Sobrenome.Text) &&
                !String.IsNullOrEmpty(mtb_CEP.Text) &&
                !String.IsNullOrEmpty(mtb_Telefone.Text) &&
                !String.IsNullOrEmpty(mtb_Valor.Text) //&&
               // cb_Status.SelectedItem != null
                )
                return true;
            else
                return false;
        }

        private void AddRelatorio()
        {
            ListViewItem relatorio = new ListViewItem(tb_ID.Text);
            relatorio.SubItems.Add(tb_Nome.Text);
            relatorio.SubItems.Add(tb_Sobrenome.Text);
            relatorio.SubItems.Add(mtb_Telefone.Text);
            relatorio.SubItems.Add(mtb_CEP.Text);
            relatorio.SubItems.Add(cb_Status.Text);
            relatorio.SubItems.Add(rb_Sim.Checked ? rb_Sim.Text : rb_Nao.Text);
            relatorio.SubItems.Add(mtb_Valor.Text);
            relatorio.SubItems.Add(dtp_Data.Text);

            String anotacoes = String.Empty;
            if(cb_HComercial.Checked)
                anotacoes += cb_HComercial + " - ";
         
            if (cb_Condominio.Checked)
                anotacoes += cb_Condominio + " - ";
            
            if (cb_APrevio.Checked)
                anotacoes += cb_APrevio;

            relatorio.SubItems.Add(anotacoes);

            lv_Relatorio.Items.Add(relatorio);
        }

        private void LimparDados()
        {
            tb_ID.Text = null;
            tb_Nome.Text = null;
            tb_Sobrenome.Text = null;
            mtb_Telefone.Text = null;
            mtb_CEP.Text = null;
            cb_Status.SelectedItem = null;
            rb_Sim.Checked = true;
            mtb_Valor.Text = null;
            dtp_Data.Text = null;
            cb_HComercial.Checked = false;
            cb_Condominio.Checked = false;
            cb_APrevio.Checked = false;


            
        }

       

        private void TeclaPessionada_ID(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}
