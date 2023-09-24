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
        List<List<String>> codigo; //Lista de lista de strings, el primer string de cada lista (dentro del conjunto de listas) es la linea original de codigo, lo que le siguen son tokens
        public static List<string> ListaErrores = new List<string>();
        Dictionary<String, String> TabSim;
        //public static List<int> selected_error;


        public SICXE()
        {
            InitializeComponent();
        }

        #region Entrega 2
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
                    this.codigo = new List<List<String>>();  //Vaciar contenido de codigo
                }
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e) //Analizar codigo    LISTO
        {
            textBox_errores.Text = "";                              //Reiniciar textbox de errores
            dGV_Sim.Rows.Clear();
            dGV_int.Rows.Clear();

            codigo = new List<List<String>>();                      //En la lista de codigo agrega todo uno por uno para su uso mas adelante en paso 1
            for(int i = 0; i < textBox_codigo.Lines.Length; i++)
            {
                //MessageBox.Show(textBox_codigo.Lines[i]);
                String trim = textBox_codigo.Lines[i].Trim();
                if (trim != "")
                    codigo.Add(new List<string> { trim });
                //MessageBox.Show(trim);
                //String[] lineArr = trim.Split('\t');
                //foreach(string line in lineArr)
                    //MessageBox.Show(line);
            }

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
                    IParseTree parseTree = parser.programa();       // Analiza la gramática
                    //MessageBox.Show(parseTree.ToStringTree());
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
                String ArchivoT = this.Archivo;                     //Rescatar ruta del archivo de ".s"
                ArchivoT = ArchivoT.Remove(ArchivoT.Length - 2, 2); //Modificar la extension para crear un nuevo .t
                ArchivoT += ".t";
                FileStream fs = File.Create(ArchivoT);              //Crear el archivo
                fs.Close();
                File.WriteAllLines(ArchivoT, textBox_errores.Lines);//Toma el contenido del textbox de errores y lo pasa al archivo .t

                Paso1(); //Iniciar con el calculo de Paso 1 (Entrega 3)

            }
            else
            {
                MessageBox.Show("Inserta codigo");
            }
        }
        #endregion

        #region Entrega 3

        private void Paso1()
        {
            int ContadorPrograma = 0;
            for(int i = 0; i < codigo.Count; i++)
            {
                GramaticaLexer lex = new GramaticaLexer(new AntlrInputStream(codigo[i][0] + Environment.NewLine));
                CommonTokenStream tokens = new CommonTokenStream(lex);
                GramaticaParser parser = new GramaticaParser(tokens);
                ErrorListener errores = new ErrorListener();
                parser.AddErrorListener(errores);
                ListaErrores = new List<string>();

                DataGridViewRow r = new DataGridViewRow();  
                r.CreateCells(dGV_int);    //Crea las celdas en el nuevo row de acuerdo a las columnas existentes en el datagridview que le pasas
                r.Cells[0].Value = i; //La primera celda toma el valor de linea actual
                r.Cells[2].Value = ContadorPrograma; //La primera celda toma el valor del CP

                if (i == 0)
                {
                    IParseTree parseTree = parser.inicio();       // Verifica si pertenece a inicio
                    if (ListaErrores.Count > 0)
                    {
                        r.Cells[6].Value = "Error de sintaxis";
                    }
                }
                else if( i == codigo.Count - 1)
                {
                    IParseTree parseTree = parser.fin();                // Verifica si pertenece a fin/end
                    if (ListaErrores.Count > 0)
                    {
                        r.Cells[6].Value = "Error de sintaxis";
                    }
                }
                else
                {
                    IParseTree parseTree = parser.proposicion();       // Verifica si pertenece a proposicion
                    if (ListaErrores.Count > 0)
                    {
                        r.Cells[6].Value = "Error de sintaxis";
                    }
                }
                dGV_int.Rows.Add(r);
            }
        }

        #endregion
    }
}




