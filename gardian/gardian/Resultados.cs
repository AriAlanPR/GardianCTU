using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//referencias agregadas
using AForge.Video;
using AForge.Video.DirectShow;
//librerias de alternativa(open source) para lectura de codigo QR
using ZXing.QrCode;
using ZXing;
//
namespace gardian
{
    public partial class Resultados : Form
    {
        //para crear este formulario debe recibir como parametro los puntajes necesarios
        public Resultados(int _aciertos, int _errores, int _total, string _nivel, string _actividad)
        {
            aciertos = _aciertos;
            errores = _errores;
            total = _total;
            niveldif = _nivel;
            actividadrea = _actividad;
            InitializeComponent();
        }
        //
        //Metodos y variables para interaccion con la cámara:
        //variable para lista de dispositivos
        private FilterInfoCollection dispositivos;
        //variable para fuente de video
        private VideoCaptureDevice fuentedevideo;
        //metodos para manejar la camara y hacer la decodificacion del QR
        public void EncenderCamara()
        {
            try
            {
                if (vspqr.IsRunning == false)
                {
                    
                    //Se establece el dispositivo seleccionado como fuente de video
                    fuentedevideo = new VideoCaptureDevice(dispositivos[cmbcamara.SelectedIndex].MonikerString);
                    //Se inicializa el control
                    vspqr.VideoSource = fuentedevideo;
                    //Iniciar recepcion de imagenes
                    vspqr.Start();
                    //Comienza la lectura
                    tmrscan.Enabled = true;
                }
            }
            catch (Exception x)
            {
                
                MessageBox.Show(x.Message);
            }
        }

        public void ApagarCamara()
        {
            try
            {
                //Detener lectura
                tmrscan.Enabled = false;
                //timzxing.Enabled = false;
                if (vspqr.IsRunning)
                {//Se detiene la recepcion de imagenes
                    vspqr.SignalToStop();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void Llenarcombocamara()
        {
            try
            {
                //Se hace un listado de los dispositivos de entrada de video
                dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                //Se cargar todos los dispositivos en el combobox
                foreach (FilterInfo x in dispositivos)
                {
                    cmbcamara.Items.Add(x.Name);
                }
                cmbcamara.SelectedIndex = 0;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        //Terminan metodos de interaccion con cámara.
        //
        //
        //variables que guardaran los errores y aciertos
        double aciertos, errores, auxaciertos, auxerrores;
        int total;
        //variables que indican nivel y actividad
        string niveldif, actividadrea;

        //generada variable para conexion a base de datos
        BDaccess bdgardian;
        //metodo para obtener promedio de aciertos/errores
        public double Promediar(double cantidad, int total)
        {
            //tipos 1 = promedio de aciertos, 2 = promedio de errores
            return (cantidad * 100) / total;
        
        }
        private void Resultados_Load(object sender, EventArgs e)
        {
            try
            {
               
                //se guardan los datos de aciertos/errores de esta ocasion
                lblpnta1.Text = aciertos.ToString();
                lblpnte1.Text = errores.ToString();
                lblprca1.Text = Promediar(Convert.ToDouble(aciertos), total).ToString("#.##")+ " %";
                lblprce1.Text = Promediar(Convert.ToDouble(errores), total).ToString("#.##")+ " %";
                //se accede a base de datos antes de cargar el formulario
                AccesaraBD("poro");
                //se impide que el usuario maximize el formulario
                this.MaximizeBox = false;
                //se cargan los elementos de la camara en el combobox
                Llenarcombocamara();
                //se guardan los aciertos/errores en auxiliares
                auxaciertos = aciertos;
                auxerrores = errores;
                //se obtienen los promedios de cada dato
                aciertos = Promediar(aciertos, total);
                errores = Promediar(errores, total);
                //obtener el promedio en total            
                /*Si la cadena contiene caracteres no numéricos o el valor numérico es demasiado grande o 
                 * demasiado pequeño para el tipo determinado que ha especificado, TryParse devuelve el valor 
                 * false y establece el parámetro out en cero.De lo contrario, devuelve el valor true y establece 
                 * el parámetro out en el valor numérico de la cadena.
                */
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

        }
        //metodo para accesar a base de datos
        private void AccesaraBD(string pwd)
        {
            string ruta = "";
            if (bdgardian == null)
            {
                try
                {
                    //OpenFileDialog open = new OpenFileDialog();
                    //open.Filter = "archivo Acess(*.accdb)|*.accdb";
                    //open.Title = "archivos accdb";
                    //if (open.ShowDialog() == DialogResult.OK)
                    //{
                    //    ruta = open.FileName;
                    //}
                    ////se libera de memoria el objeto openfiledialog
                    //open.Dispose();
                    ruta = Application.StartupPath + "\\basedatos\\gardianbd.accdb";
                    //luego de obtener la ruta podemos iniciar la base de datos
                    bdgardian = new BDaccess(@"Data Source=" + ruta + ";Jet OLEDB:Database Password=" + pwd + ";");//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;
                    //Jet OLEDB:Database Password=MyDbPassword;
                    
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("La base de datos seleccionada es nula :c");
                    Application.Exit();
                }
            }


        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                aciertos = auxaciertos;
                errores = auxerrores;

                if (bdgardian == null)
                    AccesaraBD("poro");

                int aux;
                bool acconvertible = int.TryParse(lblresnl.Text, out aux);
                if (acconvertible)
                {
                    //variables para verificar si no hay aciertos/errores
                   // bool hayaciertos = true, hayerrores = true;
                    //si es convertible el numero de lista a numerico
                    //se evaluan los aciertos y errores
                    //primero el puntaje
                    //luego porcentaje
                    string ptaciertos = "SELECT AVG(aciertos) AS PROMAC FROM Puntajes WHERE Numero_Lista =" + lblresnl.Text+ " AND Actividad=\""+ actividadrea+ "\"";
                    ptaciertos = bdgardian.Comandounvalor(ptaciertos);
                    if (string.IsNullOrWhiteSpace(ptaciertos))
                    {
                        ptaciertos = "N/A";
                        lblporca2.Text = "N/A";
                        //hayaciertos = false;
                    }
                    else
                    {
                        lblporca2.Text = Promediar(double.Parse(ptaciertos), total).ToString("#.##") + " %";
                        lblpnta2.Text = double.Parse(ptaciertos).ToString("#.##");
                    }
                    string pterrores = "SELECT AVG(Errores) AS PROMAC FROM Puntajes WHERE Numero_Lista =" + lblresnl.Text + "AND Actividad = \"" + actividadrea + "\"";
                    pterrores = bdgardian.Comandounvalor(pterrores);
                    if (string.IsNullOrWhiteSpace(pterrores))
                    {
                        pterrores = "N/A";
                        lblporce2.Text = "N/A";
                        //hayerrores = false;
                    }
                    else
                    {
                        lblporce2.Text = Promediar(double.Parse(pterrores), total).ToString("#.##") + " %";
                        lblpnte2.Text = double.Parse(pterrores).ToString("#.##");
                    }
                    //Se evalua el numero de intento a ingresar
                    string vecesevaluado = "SELECT Max(Intento) as Ocasion FROM Puntajes WHERE Numero_lista =" + lblresnl.Text+ "AND Actividad = \""+ actividadrea+"\"";
                    vecesevaluado = bdgardian.Comandounvalor(vecesevaluado);
                    int numerointento;
                    int.TryParse(vecesevaluado, out numerointento);
                    if (numerointento == 0 || numerointento == null)
                        numerointento = 1;
                    else
                        numerointento++;
                    bdgardian.Comandosinresultado(string.Format("INSERT INTO Puntajes VALUES({0},{1}, {2}, {3}, \"{4}\", \"{5}\")", numerointento, lblresnl.Text, aciertos, errores,niveldif, actividadrea));
                }
                else
                    MessageBox.Show("Aún no se ha escaneado una identificación válida");
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int contador = 0;
        private void tmrscan_Tick(object sender, EventArgs e)
        {
            try
            {
                // create a barcode reader instance
                IBarcodeReader reader = new ZXing.BarcodeReader();
                // load a bitmap
                var barcodeBitmap = vspqr.GetCurrentVideoFrame();
                // detect and decode the barcode inside the bitmap
                var result = reader.Decode(barcodeBitmap);
                // do something with the result
                if (result != null)
                {
                    lblresnl.Text = result.Text;

                }
                if (bdgardian != null && lblresnl.Text.Contains("???") == false)
                {
                    string traernombre = "SELECT Nombre_completo FROM Lista_completa WHERE Numero_lista = " + lblresnl.Text;
                    lblresnom.Text = bdgardian.Comandounvalor(traernombre);
                }
            }
            catch (Exception x)
            {
                if (contador < 3)
                {
                    if (!(x.Message.Contains("El valor no puede")) && !(x.Message.Contains("especificado valores")))
                        MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contador++;
                }
                else
                {
                    MessageBox.Show("Se apagará la cámara debido a generacion de muchos errores.");
                    ApagarCamara();

                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnon_Click(object sender, EventArgs e)
        {
            try
            {
                EncenderCamara();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            try
            {
                ApagarCamara();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //se cierra la conexion a base de datos
                bdgardian.CerrarConexion();
                //se apaga la camara
                ApagarCamara();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //se cierra la aplicacion
                Application.Exit();
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                AccesaraBD("poro");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
