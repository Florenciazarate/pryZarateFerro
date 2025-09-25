using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateFerro
{

    public partial class frmFerro : Form
      
 
    {
        public frmFerro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int distancia = (int)numDistancia.Value * 2;
            int dias = (int)numDias.Value;
            double precio = distancia * 5;

            if (distancia >= 100 && dias >= 7)
                {
                    precio = precio / 2;
                    MessageBox.Show("Precio final: " + precio);
            }
            else {
                    MessageBox.Show("Precio final: " + precio);
            }
            }
        }
    
}
