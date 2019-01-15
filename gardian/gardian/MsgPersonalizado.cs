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
    public partial class MsgPersonalizado : Form
    {
        //variable que guarda el texto enviado para colocarlo en el label
        string texto1;
        public MsgPersonalizado(string titulo, string texto)
        {
            this.Text = titulo;
            texto1 = texto;
            InitializeComponent();
        }

        private void MsgPersonalizado_Load(object sender, EventArgs e)
        {
            lbltexto.Text = texto1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
