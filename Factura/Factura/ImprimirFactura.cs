using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class ImprimirFactura : Form
    {
        public Imprimir imprime = new Imprimir();

        public ImprimirFactura()
        {
            InitializeComponent();
        }

        private void btnConfirmarImpresion_Click(object sender, EventArgs e)
        {
            dgvImprimir.DataSource = imprime.ListImprimeFactura;
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvImprimir);

            MessageBox.Show("Gracias por preferirnos");

            //this.Close();
        }

        private void ImprimirFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
