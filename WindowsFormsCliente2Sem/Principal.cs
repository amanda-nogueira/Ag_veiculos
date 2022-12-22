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
    public partial class Principal : Form
    {
        CadCliente cadCliente = new CadCliente();
        AtuaCliente atuaCliente = new AtuaCliente();
        ConsClientecs consCliente = new ConsClientecs();
        ExclCliente exclCliente = new ExclCliente();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void dASDSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCliente.ShowDialog();
        }

        private void dASDASDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atuaCliente.ShowDialog();
        }

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consCliente.ShowDialog();
        }

        private void eXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exclCliente.ShowDialog();
        }
    }
}
