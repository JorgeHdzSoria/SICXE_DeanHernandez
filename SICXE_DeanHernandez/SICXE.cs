using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace SICXE_DeanHernandez
{
    public partial class SICXE : Form
    {
        String Archivo;
        List<String> codigo;
        public static List<string> ListaErrores = new List<string>();
        Dictionary<String, String> TabSim;
        public static List<int> selected_error;


        public SICXE()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Abrir archivo ".s" LISTO
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "s files (*.s)|*.s|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.Contains(".s")) //Debe leer archivo tipo ".s" que es el que contiene las lineas de ensamblador
                {
                    this.Archivo = ofd.FileName; //Guardar el nombre del archivo abierto en una variable para facil acceso en otras funciones
            
                    //Limpiar el espacio de trabajo
                    textBox_codigo.Text = "";
                    textBox_errores.Text = "";

                    //Leer archivo ".s" e imprimir en textBox_codigo
                    textBox_codigo.Lines = File.ReadAllLines(Archivo);
                    this.codigo = new List<String>();  //Vaciar contenido de codigo
                }
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e) //Analizar codigo    LISTO
        {
            textBox_errores.Text = "";          //Reiniciar textbox de errores
            codigo = new List<String>();
            ListaErrores = new List<string>();

            if (textBox_codigo.Text != "") //Si el textbox no esta vacio continuar
            {
                String code = textBox_codigo.Text + Environment.NewLine;
                GramaticaLexer lex = new GramaticaLexer(new AntlrInputStream(code));
                CommonTokenStream tokens = new CommonTokenStream(lex);
                GramaticaParser parser = new GramaticaParser(tokens);
                ErrorListener errores = new ErrorListener();
                parser.AddErrorListener(errores);
                
                try
                {
                    parser.programa();  // Analiza la gramática
                    if (ListaErrores.Count > 0)
                    {
                        foreach (String error in ListaErrores)
                        {
                            textBox_errores.Text += error + Environment.NewLine;
                        }
                    }
                    else
                        textBox_errores.Text = "NO HAY ERRORES";
                }
                catch (RecognitionException ex)
                {
                    Console.Error.WriteLine(ex.StackTrace);
                }

                // Creacion del archivo de errores
                String ArchivoT = this.Archivo;   //Rescatar ruta del archivo de ".s"
                ArchivoT = ArchivoT.Remove(ArchivoT.Length - 2, 2); //Modificar la extension para crear un nuevo .t
                ArchivoT += ".t";
                FileStream fs = File.Create(ArchivoT); //Crear el archivo
                fs.Close();
                File.WriteAllLines(ArchivoT, textBox_errores.Lines); //Toma el contenido del textbox de errores y lo pasa al archivo .t
                
            }
            else
            {
                MessageBox.Show("Inserta codigo");
            }
        } 
    }
}




