namespace SICXE_DeanHernandez
{
    partial class SICXE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SICXE));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_Abrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.labelContenido = new System.Windows.Forms.Label();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.textBox_errores = new System.Windows.Forms.TextBox();
            this.labelErrores = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV_int = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Sim = new System.Windows.Forms.DataGridView();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sim)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Abrir,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(997, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB_Abrir
            // 
            this.tSB_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("tSB_Abrir.Image")));
            this.tSB_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Abrir.Name = "tSB_Abrir";
            this.tSB_Abrir.Size = new System.Drawing.Size(100, 22);
            this.tSB_Abrir.Text = "Abrir archivo \".s\"";
            this.tSB_Abrir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "Analizar codigo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Location = new System.Drawing.Point(61, 8);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(109, 13);
            this.labelContenido.TabIndex = 1;
            this.labelContenido.Text = "Contenido de Archivo";
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(6, 24);
            this.textBox_codigo.Multiline = true;
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_codigo.Size = new System.Drawing.Size(238, 374);
            this.textBox_codigo.TabIndex = 2;
            // 
            // textBox_errores
            // 
            this.textBox_errores.Location = new System.Drawing.Point(258, 24);
            this.textBox_errores.Multiline = true;
            this.textBox_errores.Name = "textBox_errores";
            this.textBox_errores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_errores.Size = new System.Drawing.Size(235, 374);
            this.textBox_errores.TabIndex = 3;
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(355, 8);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(46, 13);
            this.labelErrores.TabIndex = 4;
            this.labelErrores.Text = "Errores: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 430);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_codigo);
            this.tabPage1.Controls.Add(this.labelErrores);
            this.tabPage1.Controls.Add(this.labelContenido);
            this.tabPage1.Controls.Add(this.textBox_errores);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrega 2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dGV_int);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dGV_Sim);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entrega 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archivo Intermedio";
            // 
            // dGV_int
            // 
            this.dGV_int.AllowUserToAddRows = false;
            this.dGV_int.AllowUserToDeleteRows = false;
            this.dGV_int.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_int.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Formato,
            this.CP,
            this.ETQ,
            this.INS,
            this.OPER,
            this.MODO});
            this.dGV_int.Location = new System.Drawing.Point(257, 34);
            this.dGV_int.Name = "dGV_int";
            this.dGV_int.ReadOnly = true;
            this.dGV_int.Size = new System.Drawing.Size(702, 364);
            this.dGV_int.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla de Simbolos";
            // 
            // dGV_Sim
            // 
            this.dGV_Sim.AllowUserToAddRows = false;
            this.dGV_Sim.AllowUserToDeleteRows = false;
            this.dGV_Sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Sim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Simbolo,
            this.Direccion});
            this.dGV_Sim.Location = new System.Drawing.Point(7, 34);
            this.dGV_Sim.Name = "dGV_Sim";
            this.dGV_Sim.ReadOnly = true;
            this.dGV_Sim.Size = new System.Drawing.Size(243, 364);
            this.dGV_Sim.TabIndex = 0;
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Símbolo";
            this.Simbolo.Name = "Simbolo";
            this.Simbolo.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(965, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Entrega 4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Archivo Intermedio: CONT. LOC + CODIGO FUENTE + CODIGO OBJETO+ERRORES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.ERR});
            this.dataGridView1.Location = new System.Drawing.Point(257, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(702, 364);
            this.dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tabla de Simbolos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView2.Location = new System.Drawing.Point(7, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(243, 364);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Símbolo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Num";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Formato";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ETQ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "INS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "OPER";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "COD. OP.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 105;
            // 
            // ERR
            // 
            this.ERR.HeaderText = "ERR";
            this.ERR.Name = "ERR";
            this.ERR.ReadOnly = true;
            this.ERR.Width = 114;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 50;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            this.Formato.Width = 50;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Width = 70;
            // 
            // ETQ
            // 
            this.ETQ.HeaderText = "ETQ";
            this.ETQ.Name = "ETQ";
            this.ETQ.ReadOnly = true;
            this.ETQ.Width = 90;
            // 
            // INS
            // 
            this.INS.HeaderText = "INS";
            this.INS.Name = "INS";
            this.INS.ReadOnly = true;
            this.INS.Width = 80;
            // 
            // OPER
            // 
            this.OPER.HeaderText = "OPER";
            this.OPER.Name = "OPER";
            this.OPER.ReadOnly = true;
            // 
            // MODO
            // 
            this.MODO.HeaderText = "MODO";
            this.MODO.Name = "MODO";
            this.MODO.ReadOnly = true;
            this.MODO.Width = 218;
            // 
            // SICXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SICXE";
            this.Text = "SICXE_DeanHernandez";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Sim)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_Abrir;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.TextBox textBox_errores;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Sim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridView dGV_int;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn INS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODO;
    }
}

