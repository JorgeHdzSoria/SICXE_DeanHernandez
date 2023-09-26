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
        HashSet<string> Set_TabSim;
        Dictionary<String, String> TabSim;

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
                String trim = textBox_codigo.Lines[i].Trim(); //Quita todos los espacios en blanco sobrantes antes y despues del string
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
                catch (RecognitionException ex){
                    Console.Error.WriteLine(ex.StackTrace);}

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
                MessageBox.Show("Inserta codigo");
        }
        #endregion

        #region Entrega 3

        private void Paso1()
        {
            int ContadorPrograma = 0; //CP,PC
            for(int i = 0; i < codigo.Count; i++)
            {
                GramaticaLexer lex = new GramaticaLexer(new AntlrInputStream(codigo[i][0] + Environment.NewLine));
                CommonTokenStream tokens = new CommonTokenStream(lex);
                GramaticaParser parser = new GramaticaParser(tokens);
                ErrorListener errores = new ErrorListener();
                parser.AddErrorListener(errores);
                ListaErrores = new List<string>();

                DataGridViewRow r = new DataGridViewRow();  
                r.CreateCells(dGV_int);     //Crea las celdas en el nuevo row de acuerdo a las columnas existentes en el datagridview que le pasas
                r.Cells[0].Value = i;       //La primera celda toma el valor de linea actual
                r.Cells[2].Value = ContadorPrograma; //La tercera celda toma el valor del CP

                // Codigos lexicos
                /* T__0 = 1, T__1 = 2, RSUB = 3, @ = 4, # = 5, +RSUB = 6, BASE = 7, RESW = 8, RESB = 9, 
		        WORD = 10, BYTE = 11, START = 12, END = 13, COMA = 14, INSTR1 = 15, INSTR2_r1r2 = 16, 
		        INSTR2_r1 = 17, INSTR2_r1n = 18, INSTR2_n = 19, INSTR3 = 20, INSTR4 = 21, FINL = 22, 
		        REG = 23, NUMDEC = 24, NUMHEX_sh = 25, NUMHEX = 26, TEXT = 27, CONSTHEX = 28, CONSTCAD = 29;
                */

                //  INSTRUCCIONES / DIRECTIVAS
                /* 7 a 11 son directivas "operadores", Start es 12 y end es 13*/
                /* 15 a 21 son instrucciones de formatos que varian*/


                //MessageBox.Show(parseTree.ToStringTree());
                //int syntax = parseTree.SourceInterval.Length;
                //MessageBox.Show(tokens.GetTokens + ' ' + syntax);

                /*foreach (IToken token in t)
                    {
                        MessageBox.Show(token.ToString() + token.Type);
                    }*/

                //MessageBox.Show(t[0].Type.ToString());



                if (i == 0)
                {
                    IParseTree parseTree = parser.inicio();       // Verifica si pertenece a inicio
                    r.Cells[1].Value = "---";
                    r.Cells[6].Value = "---";
                    
                    IList<IToken> t = tokens.GetTokens();
                    if (t[0].Type.ToString() == "27")
                        r.Cells[3].Value = t[0].Text;

                    if (ListaErrores.Count > 0)
                    {
                        r.Cells[6].Value = "Error de sintaxis";
                    }

                }
                else if( i == codigo.Count - 1)
                {
                    IParseTree parseTree = parser.fin();                // Verifica si pertenece a fin/end
                    r.Cells[1].Value = "---";
                    r.Cells[6].Value = "---";

                    IList<IToken> t = tokens.GetTokens();
                    if (ListaErrores.Count > 0)
                    {
                        r.Cells[6].Value = "Error de sintaxis";
                    }
                }
                else
                {
                    IParseTree parseTree = parser.proposicion();        // Verifica si pertenece a proposicion
                    IList<IToken> t = tokens.GetTokens();               // Obtener todos los tokens
                    if (t[0].Type.ToString() == "27")                   // Identificar si el primer token es etiqueta y lo agrega a la columan ETIQ
                        r.Cells[3].Value = t[0].Text;

                    r.Cells[1].Value = RegresarFormato(t);
                    r.Cells[4].Value = RegresarInstruccion(t);


                    if (ListaErrores.Count > 0)
                    {
                        r.Cells[6].Value = "Error de sintaxis";
                    }
                }
                dGV_int.Rows.Add(r);    //Agregar renglon en tabla datagridView de Archivo intermedio
            }
        }

        String RegresarFormato(IList<IToken> t)
        {
            int cont = 0;
            String ret = "---"; //Por default se considera directiva
            //Formato1: 15 , Formato2: 16-19 , Formato3: 20 , Formato4: 21
            foreach(IToken token in t)
            {
                switch (token.Type.ToString())
                {
                    case "15": ret = "1";
                        cont++;
                        break;
                    case "16": ret = "2";
                        cont++;
                        break;
                    case "17": ret = "2";
                        cont++;
                        break;
                    case "18": ret = "2";
                        cont++;
                        break;
                    case "19": ret = "2";
                        cont++;
                        break;
                    case "20": ret = "3";
                        cont++;
                        break;
                    case "3": ret = "3"; //Caso especial de RSUB
                        cont++;
                        break;
                    case "21": ret = "4";
                        cont++;
                        break;
                    case "6": ret = "4"; //Caso especial de +RSUB
                        cont++;
                        break;
                    default: break;
                }
            }
            if (cont <= 1)
                return ret;
            else
                return "Error";
        }

        String RegresarInstruccion(IList<IToken> t)
        {
            int cont = 0;
            String ret = "";
            //Formato1: 15 , Formato2: 16-19 , Formato3: 20 , Formato4: 21
            foreach (IToken token in t)
            {
                if(token.Type == 3 || token.Type == 6 || (token.Type >= 7 && token.Type <= 11) ||(token.Type >= 15 && token.Type <= 21) )
                {
                    ret = token.Text;
                    cont++;
                }
            }
            if (cont == 1)
                return ret;
            else
                return "Error";
        }

        List<String> RegresarOperandos(IList<IToken> t)
        {
            List<String> Operandos = new List<String>();
            foreach (IToken token in t)
            {
                if (token.Type == 4 || token.Type == 5 || (token.Type >= 23 && token.Type <= 29))
                    Operandos.Add(token.Text);
            }
            return Operandos;
        }

        #endregion
    }
}




