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
        //HashSet<string> Set_TabSim;
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
            TabSim = new Dictionary<string, string>();

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

        // Codigos lexicos
        /* ",X" = 1, ", X" = 2, RSUB = 3, @ = 4, # = 5, +RSUB = 6, BASE = 7, RESW = 8, RESB = 9, 
        WORD = 10, BYTE = 11, START = 12, END = 13, COMA = 14, INSTR1 = 15, INSTR2_r1r2 = 16, 
        INSTR2_r1 = 17, INSTR2_r1n = 18, INSTR2_n = 19, INSTR3 = 20, INSTR4 = 21, FINL = 22, 
        REG = 23, NUMDEC = 24, NUMHEX_sh = 25, NUMHEX = 26, TEXT = 27, CONSTHEX = 28, CONSTCAD = 29;
        */

        //  INSTRUCCIONES / DIRECTIVAS
        /* 7 a 11 son directivas "operadores", Start es 12 y end es 13*/
        /* 15 a 21 son instrucciones de formatos que varian*/

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
                r.CreateCells(dGV_int);                                     //Crea las celdas en el nuevo row de acuerdo a las columnas existentes en el datagridview que le pasas
                r.Cells[0].Value = i;                                       //La primera celda toma el valor de linea actual
                r.Cells[2].Value = Convert.ToString(ContadorPrograma, 16);  //La tercera celda toma el valor del CP, convierte el decimal en hexadecimal
                
                if (i == 0)
                {
                    IParseTree parseTree = parser.inicio();             // Verifica si pertenece a inicio
                    r.Cells[1].Value = "---";
                    r.Cells[6].Value = "---";
                    
                    IList<IToken> t = tokens.GetTokens();
                    if (t[0].Type.ToString() == "27")
                        r.Cells[3].Value = t[0].Text;

                    if (ListaErrores.Count > 0)
                    {
                        r.Cells[6].Value = "Error: Sintaxis";
                    }
                    else
                    {
                        r.Cells[4].Value = t[1].Text;
                        List<String> op = RegresarOperandos(t);
                        if (op.Count == 1)
                        {
                            r.Cells[5].Value = op[0];
                            String num = r.Cells[5].Value.ToString();
                            if (num.Last() == 'h' || num.Last() == 'H')
                            {
                                num = num.Remove(num.Length - 1, 1);//Remover letra
                                ContadorPrograma += Convert.ToInt32(num, 16);
                            }
                            else
                            {
                                ContadorPrograma += Int32.Parse(r.Cells[5].Value.ToString());
                            }
                        }
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
                        r.Cells[6].Value = "Error: Sintaxis";
                    }
                    else
                    {
                        r.Cells[4].Value = t[0].Text;
                        List<String> op = RegresarOperandos(t);
                        if (op.Count == 1)
                            r.Cells[5].Value = op[0];
                    }
                        
                }
                else
                {
                    r.Cells[6].Value = "---";
                    IParseTree parseTree = parser.proposicion();        // Verifica si pertenece a proposicion
                    IList<IToken> t = tokens.GetTokens();               // Obtener todos los tokens
                    bool ErrorSimboloDuplicado = false;
                    if (t[0].Type.ToString() == "27")                   // Identificar si el primer token es etiqueta y lo agrega a la columan ETIQ
                    {
                        r.Cells[3].Value = t[0].Text;
                        if (!TabSim.ContainsKey(t[0].Text))
                        {
                            TabSim.Add(t[0].Text, ContadorPrograma.ToString());
                            DataGridViewRow rs = new DataGridViewRow();
                            rs.CreateCells(dGV_Sim);                    //Crea las celdas en el nuevo row de acuerdo a las columnas existentes en el datagridview que le pasas
                            rs.Cells[0].Value = t[0].Text;
                            rs.Cells[1].Value = Convert.ToString(ContadorPrograma, 16); //Convertir decimal a hexadecimal
                            dGV_Sim.Rows.Add(rs);                       //Agregar renglon en tabla datagridView de Archivo intermedio
                        }
                        else
                            ErrorSimboloDuplicado = true;               //No debe insertarse en tabla de sim y da error en la linea
                    }

                    r.Cells[1].Value = RegresarFormato(t);              //Determinar que rellenar en la columna formato
                    r.Cells[4].Value = RegresarInstruccion(t);          //Determinar que rellenar en la columna instruccion
                    List<String> op = RegresarOperandos(t);             //Determinar que rellenar en la columna operandos
                    foreach (String o in op)
                        r.Cells[5].Value += o;

                    //Determinar tipo de formato si es formato 3 o 4
                    if(r.Cells[5].Value != null && (r.Cells[1].Value.ToString() == "3" || r.Cells[1].Value.ToString() == "4"))
                    {
                        if (r.Cells[5].Value.ToString().Contains("#"))
                            r.Cells[6].Value = "Inmediato";
                        else if (r.Cells[5].Value.ToString().Contains("@"))
                            r.Cells[6].Value = "Indirecto";
                        else
                            r.Cells[6].Value = "Simple";
                    }

                    //Tratar con operandos de mas en instrucciones RSUB
                    if(r.Cells[4].Value.ToString().Contains("RSUB") || r.Cells[4].Value.ToString().Contains("+RSUB"))
                    {
                        if(r.Cells[5].Value == null)
                            r.Cells[6].Value = "---";
                        else if(r.Cells[5].Value.ToString() == "")
                            r.Cells[6].Value = "---";
                        else
                            r.Cells[6].Value = "Error: Sintaxis";
                    }

                    //Tratar con operandos en formato 1, dar error
                    if (r.Cells[1].Value.ToString() == "1")
                    {
                        if (r.Cells[5].Value != null)
                        {
                            if (r.Cells[5].Value.ToString() != "")
                                r.Cells[6].Value = "Error: Sintaxis";
                        }
                    }

                    //Tratar con errores
                    if (ListaErrores.Count > 0)
                    {
                        if (r.Cells[4].Value.ToString() == "Error")
                            r.Cells[6].Value = "Error: Instruccion no existe";
                        else
                            r.Cells[6].Value = "Error: Sintaxis";
                    }
                    else if(ErrorSimboloDuplicado)
                        r.Cells[6].Value = "Error: Simbolo Duplicado";

                    //Incremento de CP para formato 1-4 y directivas
                    if(!(r.Cells[1].Value.ToString() == "Error" || r.Cells[6].Value.ToString() == "Error: Sintaxis" || r.Cells[1].Value.ToString() == "Error: Instruccion no existe"))
                    {
                        switch (r.Cells[1].Value.ToString())
                        {
                            case "1":
                                ContadorPrograma += 1;
                                break;
                            case "2":
                                ContadorPrograma += 2;
                                break;
                            case "3":
                                ContadorPrograma += 3;
                                break;
                            case "4":
                                ContadorPrograma += 4;
                                break;
                            case "---": //Directiva
                                {
                                    switch (r.Cells[4].Value.ToString())
                                    {
                                        case "BASE": //nada
                                            break;
                                        case "RESW":
                                            String s = r.Cells[5].Value.ToString();
                                            if(s.Last() == 'h' || s.Last() == 'H')
                                            {
                                                s = s.Remove(s.Length-1,1);//Remover letra
                                                ContadorPrograma += Convert.ToInt32(s, 16) * 3;
                                            }
                                            else
                                            {
                                                ContadorPrograma += Int32.Parse(r.Cells[5].Value.ToString()) * 3;
                                            }
                                            break;
                                        case "RESB":
                                            String s2 = r.Cells[5].Value.ToString();
                                            if (s2.Last() == 'h' || s2.Last() == 'H')
                                            {
                                                s2 = s2.Remove(s2.Length - 1, 1);//Remover letra
                                                ContadorPrograma += Convert.ToInt32(s2, 16);
                                            }
                                            else
                                            {
                                                ContadorPrograma += Int32.Parse(r.Cells[5].Value.ToString());
                                            }
                                            break;
                                        case "WORD":
                                            ContadorPrograma += 3;
                                            break;
                                        case "BYTE":
                                            String s3 = r.Cells[5].Value.ToString();
                                            if(s3.First() == 'X')
                                            {
                                                int calculo = (s3.Length - 3) / 2;
                                                if ((s3.Length - 3) % 2 == 1)
                                                    calculo++;
                                                ContadorPrograma += calculo;
                                            }
                                            else if(s3.First() == 'C')
                                            {
                                                int calculo = s3.Length - 3;
                                                ContadorPrograma += calculo;
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
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
            for(int i = 0; i < t.Count; i++)
            {
                if (i != 0 && (t[i].Type == 1 || t[i].Type == 2 || t[i].Type == 4 || t[i].Type == 5 || t[i].Type == 14 || (t[i].Type >= 23 && t[i].Type <= 29)) )
                    Operandos.Add(t[i].Text);
            }
            return Operandos;
        }

        #endregion
    }
}




