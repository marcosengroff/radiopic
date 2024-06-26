using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiopic
{
    public partial class frmveiculos : Form
    {
        public frmveiculos()
        {
            InitializeComponent();
        }

        private void radCarros_CheckedChanged(object sender, EventArgs e)
        {
            // deixa visivel o Camaro
            picCamaro.Visible = true;
            radCamaro.Visible = true;

            // deixa visivel a Lamborguine
            picLamborguine.Visible = true;
            radLamborguine.Visible= true;

            picPop.Visible = false;
            radPop.Visible = false;

            picBiz.Visible = false;
            radBiz.Visible = false;

            lblMensagem.Visible = false;

        }

        private void radMotos_CheckedChanged(object sender, EventArgs e)
        {
            picPop.Visible = true;
            radPop.Visible = true;

            picBiz.Visible = true;
            radBiz.Visible = true;

            picCamaro.Visible = false;
            radCamaro.Visible = false;

            picLamborguine.Visible = false;
            radLamborguine.Visible = false;

            lblMensagem.Visible = false;
        }

        private void radLamborguine_CheckedChanged(object sender, EventArgs e)
        {
            picCamaro.Visible = false;
            radCamaro.Visible = false;

            lblMensagem.Text = "O carro selecionado foi um " + radLamborguine.Text + "!";
            lblMensagem.Visible = true;
        }

        private void radCamaro_CheckedChanged(object sender, EventArgs e)
        {
            picLamborguine.Visible = false;
            radLamborguine.Visible = false;

            lblMensagem.Text = "O carro selecionado foi um " + radCamaro.Text + "!";
            lblMensagem.Visible = true;
        }

        private void radPop_CheckedChanged(object sender, EventArgs e)
        {
            picBiz.Visible = false;
            radBiz.Visible = false;

            lblMensagem.Text = "A moto selecionado foi uma " + radPop.Text + "!";
            lblMensagem.Visible = true;
        }

        private void radBiz_CheckedChanged(object sender, EventArgs e)
        {
            picPop.Visible = false;
            radPop.Visible = false;

            lblMensagem.Text = "A moto selecionado foi uma " + radBiz.Text + "!";
            lblMensagem.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            radCarros.Checked = false;  
            radMotos.Checked = false;   
            
            radLamborguine.Checked=false;
            radCamaro.Checked=false;

            radPop.Checked=false;
            radBiz.Checked=false;

            picPop.Visible = false;
            radPop.Visible = false;

            picBiz.Visible = false;
            radBiz.Visible = false;

            picCamaro.Visible = false;
            radCamaro.Visible = false;

            picLamborguine.Visible = false;
            radLamborguine.Visible = false;

            lblMensagem.Visible=false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
