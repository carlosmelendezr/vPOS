using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vPOS.Formularios.Inventario
{
    public partial class FichaArticulos : Form
    {
        public FichaArticulos()
        {
            InitializeComponent();
        }

        private void descripcion_Validating(object sender, CancelEventArgs e)
        {
            if (descripcion.Text == string.Empty) {
                errorProvider1.SetError(descripcion, "Debe colocar una descripcion.");
            }
        }
    }
}
