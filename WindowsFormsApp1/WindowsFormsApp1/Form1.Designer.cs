namespace WindowsFormsApp1
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
            this.gasolina = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litrox100km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Galónxkm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costox100km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btniniciar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pmciudad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gasolina)).BeginInit();
            this.SuspendLayout();
            // 
            // gasolina
            // 
            this.gasolina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gasolina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Litrox100km,
            this.Galónxkm,
            this.Costox100km});
            this.gasolina.Location = new System.Drawing.Point(308, 0);
            this.gasolina.Name = "gasolina";
            this.gasolina.Size = new System.Drawing.Size(443, 446);
            this.gasolina.TabIndex = 0;
            this.gasolina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Litrox100km
            // 
            this.Litrox100km.HeaderText = "Litro/100km";
            this.Litrox100km.Name = "Litrox100km";
            // 
            // Galónxkm
            // 
            this.Galónxkm.HeaderText = "Galón/km";
            this.Galónxkm.Name = "Galónxkm";
            // 
            // Costox100km
            // 
            this.Costox100km.HeaderText = "Costo/km";
            this.Costox100km.Name = "Costox100km";
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(12, 402);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(105, 36);
            this.btniniciar.TabIndex = 1;
            this.btniniciar.Text = "Comenzar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 37);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Cantidad de Litros";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pmciudad
            // 
            this.pmciudad.Location = new System.Drawing.Point(0, 43);
            this.pmciudad.Multiline = true;
            this.pmciudad.Name = "pmciudad";
            this.pmciudad.Size = new System.Drawing.Size(140, 36);
            this.pmciudad.TabIndex = 5;
            this.pmciudad.TextChanged += new System.EventHandler(this.pmciudad_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.pmciudad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.gasolina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gasolina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gasolina;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litrox100km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Galónxkm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costox100km;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pmciudad;
    }
}

