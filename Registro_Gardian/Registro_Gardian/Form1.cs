using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Gardian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;
        //Jet OLEDB:Database Password=MyDbPassword;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //diseño del formulario para los registros de alumnos
        Alumnos regalm;
        private void txtusr_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (regalm == null)
                        regalm = new Alumnos(txtpwd.Text, this);
                    else
                        regalm.ActualizarPass(txtpwd.Text);

                    regalm.verificarInicio();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (regalm == null)
                    regalm = new Alumnos(txtpwd.Text, this);
                else
                    regalm.ActualizarPass(txtpwd.Text);
                regalm.verificarInicio();
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
