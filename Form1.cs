using System;
using System.Text;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            navegador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            navegador.GoForward();
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            navegador.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            navegador.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            navegador.GoHome();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            navegador.Navigate(URLNavega.Text);
        }
    }


}
