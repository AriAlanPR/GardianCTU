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
    public partial class Alumnos : Form
    {
        //variable que guarda la contraseña a la base de datos
        string contraseñabd;
        public Alumnos(string _contraseña, Form1 _parent)
        {
            contraseñabd = _contraseña;
            parent = _parent;
            InitializeComponent();
        }
        //creacion de un objeto que se utilizara para manipular la base de datos
        BDaccess bdgardian;
        //metodos para desactivar controles de pestaña modificacion y viceversa
        public void deshabilitarmodif()
        {
            txtmodnom.Enabled = false;
            txtmodappat.Enabled = false;
            txtmodapmat.Enabled = false;
            btnmodifalm.Enabled = false;
            foreach (Control C in gbinfomodif.Controls)
            {
                if (C is MaskedTextBox || C is TextBox)
                {
                    C.Text = "";
                }
            }

        }
        //metodo para habilitar cuadros de texto de la pestaña modificar
        public void habilitarmodif()
        {
            txtmodnom.Enabled = true;
            txtmodappat.Enabled = true;
            txtmodapmat.Enabled = true;
            btnmodifalm.Enabled = true;
        }
        //
        //
        private void btnmodifbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenabusqueda= "SELECT Nombre, Apellido_paterno, Apellido_materno FROM Niño WHERE Numero_lista ="+txtmodnl.Text;
                DataTable dt = bdgardian.ConandoconResultados(cadenabusqueda);
                if (dt.Rows.Count > 0)
                {
                    txtmodnom.Text = dt.Rows[0][0].ToString();
                    txtmodappat.Text = dt.Rows[0][1].ToString();
                    txtmodapmat.Text = dt.Rows[0][2].ToString();
                    habilitarmodif();
                }
                else
                {
                    deshabilitarmodif();
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                //insercion de los datos del alumno
                string cadenainsercion = string.Format("Insert into Niño values({0}, \"{1}\", \"{2}\", \"{3}\")", txtagnl.Text, txtagnom.Text, txtagappat.Text, txtagapmat.Text);

                int res = bdgardian.Comandosinresultado(cadenainsercion);
                if (res > 0)
                {
                    MessageBox.Show("Alumno agregado correctamente :3");
                    MessageBox.Show("Seleccione una ubicacion para el QR de ifdentificacion del niño");
                    Image img = (Image)pictqrcode.Image.Clone();
                    SaveFileDialog svqr = new SaveFileDialog();
                    svqr.AddExtension = true;
                    svqr.Filter = "Image JPG (*.jpg)|*.jpg";
                    svqr.ShowDialog();
                    if (!string.IsNullOrEmpty(svqr.FileName))
                        img.Save(svqr.FileName);
                    img.Dispose();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Alumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bdgardian.CerrarConexion();
                Application.Exit();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void Alumnos_Load(object sender, EventArgs e)
        {
            try
            {
                cmblistado.SelectedIndex = 0;
                AccesaraBD(contraseñabd);
                banderainicio = true;
            }            
            catch (Exception ex)
            {
                if (!ex.Message.Contains("es una contraseña"))
                {
                    MessageBox.Show(":c No se pudo porque: " + ex.Message);
                    Application.Exit();
                }
                else
                {
                    banderainicio = false;
                    MessageBox.Show(ex.Message + "\nIntente de nuevo.");                  
                    parent.Show();
                    this.Hide();
                }

            }
        }
        //
        //formulario origen
        Form1 parent;
        //bandera que indica si se debe salir de la aplicacion
        bool cerrarapp = false;
        //variable que indica si la conexion se realizo satisfactoriamente
        //bool conectado = true;
        //metodo diseñado para acceder a la base de datos de access
        //
        private void AccesaraBD(string pwd)
        {
            string ruta="";
            if (bdgardian == null)
            {
                try
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "archivo Acess(*.accdb)|*.accdb";
                    open.Title = "archivos accdb";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        ruta = open.FileName;
                    }
                    //se libera de memoria el objeto openfiledialog
                    open.Dispose();
                    //luego de obtener la ruta podemos iniciar la base de datos
                    bdgardian = new BDaccess(@"Data Source=" + ruta + ";Jet OLEDB:Database Password=" + pwd + ";");//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;
                    //Jet OLEDB:Database Password=MyDbPassword;
                    banderainicio = true;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("La base de datos seleccionada es nula :c");
                    Application.Exit();
                    
                }
            }          
             

        }
        public void ActualizarPass(string newpass)
        {            
            AccesaraBD(newpass);
            
        }
        //metodo que indica el estado de la conexion
        public bool EstadoConexion()
        {
            if (bdgardian != null)
                return bdgardian.Estado();
            else
                return false;
        }
        bool banderainicio;
        public void verificarInicio()
        {
            if (banderainicio == true)
            {
                this.Show();
                parent.Hide();
            }
            else
            {
                parent.Show();
                this.Hide();
            }
        }

        private void btnmodifalm_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenamodificacion= string.Format("UPDATE Niño SET Nombre =\"{0}\" , Apellido_paterno= \"{1}\", Apellido_materno=\"{2}\" WHERE Numero_lista ={3}",txtmodnom.Text, txtmodappat.Text, txtmodapmat.Text , txtmodnl.Text);
                DialogResult dialogo = MessageBox.Show("Va a modificar la informacion de un alumno, una vez hecho no se podra deshacer.\n¿Esta seguro de querer realizar esta acción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogo == DialogResult.Yes)
                {
                    bdgardian.Comandosinresultado(cadenamodificacion);
                    MessageBox.Show("Operación exitosa");
                }
                else
                    MessageBox.Show("Operación cancelada");

                deshabilitarmodif();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenabusqueda="SELECT Nombre_completo FROM Lista_completa WHERE Numero_lista =" + txtbajanc.Text;
                cadenabusqueda= bdgardian.Comandounvalor(cadenabusqueda);
                if (cadenabusqueda != "")
                {
                    btninfeliminar.Enabled = true;
                    lblnombrealm.Text = cadenabusqueda;
                }
                else
                    btninfeliminar.Enabled = false;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btninfeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenadeletear="DELETE FROM Niño WHERE Numero_lista ="+ txtbajanc.Text;
                //se pide confirmacion del usuario
                DialogResult dialogo = MessageBox.Show("Va a eliminar la informacion de un alumno, una vez hecho no se podra deshacer.\n¿Esta seguro de querer realizar esta acción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    //si confirma se ejecuta el metodo para dar de baja
                    bdgardian.Comandosinresultado(cadenadeletear);
                    //se manda mensaje al usuario
                    MessageBox.Show("Se ha dado de baja al alumno:\r\n" + lblnombrealm.Text);
                }
                else //si no se deasea borrar se manda mensaje al usuario de que se canceló la operación
                    MessageBox.Show("Operación cancelada");
                //se desactiva de nuevo el boton sea que se haya realizado o no la transaccion
                btninfeliminar.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscaralm_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenabuscar= "SELECT * FROM Lista_completa WHERE Nombre_completo Like \"%" + txtconsalmn.Text + "%\"" ;
                dgvalumno.DataSource = bdgardian.ConandoconResultados(cadenabuscar);
                if (dgvalumno.Rows.Count >= 1)
                    btnrecuperarqr.Enabled = true;
                else
                    btnrecuperarqr.Enabled = false;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnconstodos_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenalistado= "Select * FROM ";
                switch (cmblistado.SelectedIndex)
                {
                    case 0:
                        cadenalistado += "Lista_completa";
                break;
                    case 1 :
                cadenalistado += "Lista_aprendizaje";
                break;
                    case 2:
                cadenalistado += "Lista_visual";
                break;
                    case 3:
                cadenalistado += "Lista_auditivo";
                break;
                }
                dgvalumno.DataSource = bdgardian.ConandoconResultados(cadenalistado);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtagnl_TextChanged(object sender, EventArgs e)
        {
            pictqrcode.Text = txtagnl.Text;
        }
        int cdselec = -1;
        private void dgvalumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        
        private void btnrecuperarqr_Click(object sender, EventArgs e)
        {
            
            //se guarda la imagen
            Image img = (Image)qrrecuperado.Image.Clone();
            SaveFileDialog svqr = new SaveFileDialog();
            svqr.AddExtension = true;
            svqr.Filter = "Image JPG (*.jpg)|*.jpg";
            svqr.ShowDialog();
            if (!string.IsNullOrEmpty(svqr.FileName))
                img.Save(svqr.FileName);
            img.Dispose();
        }
        string numlistaselec = "";
        private void dgvalumno_SelectionChanged(object sender, EventArgs e)
        {
            //cada que se seleccione una celda se dara un numero de lista nuevo
            cdselec = dgvalumno.CurrentRow.Index;
            if (cdselec > -1 && cmblistado.SelectedIndex == 0)
            {
                //se recupera el numero de lista            
                btnrecuperarqr.Enabled = true;
                numlistaselec = dgvalumno.CurrentRow.Cells[0].Value.ToString();
                qrrecuperado.Text = numlistaselec;
            } 
        }

        private void cmblistado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmblistado.SelectedIndex != 0)
                 btnrecuperarqr.Enabled = false;

        } 
    }
}
