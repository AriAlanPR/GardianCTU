using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gardian
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
       
        private void btninicio_Click(object sender, EventArgs e)
        {
            //inicializacion del menu principal
             Factividades child= new Factividades(this);
            //se muestra menu principal
             child.Show();
            //se oculta este control
             this.Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
