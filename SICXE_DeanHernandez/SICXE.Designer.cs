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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Abrir,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
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
            this.labelContenido.Location = new System.Drawing.Point(68, 37);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(109, 13);
            this.labelContenido.TabIndex = 1;
            this.labelContenido.Text = "Contenido de Archivo";
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(13, 53);
            this.textBox_codigo.Multiline = true;
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_codigo.Size = new System.Drawing.Size(220, 385);
            this.textBox_codigo.TabIndex = 2;
            // 
            // textBox_errores
            // 
            this.textBox_errores.Location = new System.Drawing.Point(239, 53);
            this.textBox_errores.Multiline = true;
            this.textBox_errores.Name = "textBox_errores";
            this.textBox_errores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_errores.Size = new System.Drawing.Size(235, 385);
            this.textBox_errores.TabIndex = 3;
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(329, 37);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(46, 13);
            this.labelErrores.TabIndex = 4;
            this.labelErrores.Text = "Errores: ";
            // 
            // SICXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.labelErrores);
            this.Controls.Add(this.textBox_errores);
            this.Controls.Add(this.textBox_codigo);
            this.Controls.Add(this.labelContenido);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SICXE";
            this.Text = "SICXE_DeanHernandez";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}

