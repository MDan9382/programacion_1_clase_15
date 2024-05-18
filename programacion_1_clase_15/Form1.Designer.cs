namespace programacion_1_clase_15
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewpersonaje = new System.Windows.Forms.DataGridView();
            this.buttoncargar = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelraza = new System.Windows.Forms.Label();
            this.labelnivel_de_poder = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxraza = new System.Windows.Forms.TextBox();
            this.numericUpDownnivel_de_poder = new System.Windows.Forms.NumericUpDown();
            this.buttoninsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnivel_de_poder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewpersonaje
            // 
            this.dataGridViewpersonaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpersonaje.Location = new System.Drawing.Point(43, 251);
            this.dataGridViewpersonaje.Name = "dataGridViewpersonaje";
            this.dataGridViewpersonaje.Size = new System.Drawing.Size(589, 187);
            this.dataGridViewpersonaje.TabIndex = 1;
            this.dataGridViewpersonaje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttoncargar
            // 
            this.buttoncargar.Location = new System.Drawing.Point(660, 348);
            this.buttoncargar.Name = "buttoncargar";
            this.buttoncargar.Size = new System.Drawing.Size(75, 23);
            this.buttoncargar.TabIndex = 2;
            this.buttoncargar.Text = "cargar";
            this.buttoncargar.UseVisualStyleBackColor = true;
            this.buttoncargar.Click += new System.EventHandler(this.buttoncargar_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(40, 30);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(15, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "id";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(40, 68);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(42, 13);
            this.labelnombre.TabIndex = 4;
            this.labelnombre.Text = "nombre";
            // 
            // labelraza
            // 
            this.labelraza.AutoSize = true;
            this.labelraza.Location = new System.Drawing.Point(40, 107);
            this.labelraza.Name = "labelraza";
            this.labelraza.Size = new System.Drawing.Size(27, 13);
            this.labelraza.TabIndex = 5;
            this.labelraza.Text = "raza";
            // 
            // labelnivel_de_poder
            // 
            this.labelnivel_de_poder.AutoSize = true;
            this.labelnivel_de_poder.Location = new System.Drawing.Point(40, 152);
            this.labelnivel_de_poder.Name = "labelnivel_de_poder";
            this.labelnivel_de_poder.Size = new System.Drawing.Size(74, 13);
            this.labelnivel_de_poder.TabIndex = 6;
            this.labelnivel_de_poder.Text = "nivel de poder";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(127, 30);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(60, 20);
            this.textBoxid.TabIndex = 7;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(127, 65);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(257, 20);
            this.textBoxnombre.TabIndex = 8;
            // 
            // textBoxraza
            // 
            this.textBoxraza.Location = new System.Drawing.Point(127, 107);
            this.textBoxraza.Name = "textBoxraza";
            this.textBoxraza.Size = new System.Drawing.Size(257, 20);
            this.textBoxraza.TabIndex = 9;
            // 
            // numericUpDownnivel_de_poder
            // 
            this.numericUpDownnivel_de_poder.Location = new System.Drawing.Point(127, 152);
            this.numericUpDownnivel_de_poder.Name = "numericUpDownnivel_de_poder";
            this.numericUpDownnivel_de_poder.Size = new System.Drawing.Size(202, 20);
            this.numericUpDownnivel_de_poder.TabIndex = 10;
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(127, 188);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(75, 23);
            this.buttoninsertar.TabIndex = 11;
            this.buttoninsertar.Text = "insertar";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.numericUpDownnivel_de_poder);
            this.Controls.Add(this.textBoxraza);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.labelnivel_de_poder);
            this.Controls.Add(this.labelraza);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.buttoncargar);
            this.Controls.Add(this.dataGridViewpersonaje);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnivel_de_poder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewpersonaje;
        private System.Windows.Forms.Button buttoncargar;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelraza;
        private System.Windows.Forms.Label labelnivel_de_poder;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxraza;
        private System.Windows.Forms.NumericUpDown numericUpDownnivel_de_poder;
        private System.Windows.Forms.Button buttoninsertar;
    }
}

