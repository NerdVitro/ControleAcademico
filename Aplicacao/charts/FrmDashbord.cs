using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charts
{
    public partial class FrmDashbord : Form
    {
        public FrmDashbord()
        {
            InitializeComponent();
        }

        private void BtnAbrirGrafico_Click(object sender, EventArgs e)
        {
            Form1 FormularioGraficos = new Form1();
            FormularioGraficos.ShowDialog();
        }
    }
}
