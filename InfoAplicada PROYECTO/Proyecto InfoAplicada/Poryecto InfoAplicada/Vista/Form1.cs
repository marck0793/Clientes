using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poryecto_InfoAplicada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2000DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.adventureWorks2000DataSet.Customer);

        }


        private void cbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbFiltro.Text)
            {
                case "Cedula":
                    Console.WriteLine(cbFiltro.Text);
                    break;
                case "Region":
                    break;
                case "VIP":
                    break;
                case "Categorias":
                    break;
                default:
                    Console.WriteLine(cbFiltro.Text);
                    break;
            }
        }
    }
}
