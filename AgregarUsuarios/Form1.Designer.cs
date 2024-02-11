namespace AgregarUsuarios
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
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.dtMostrarDato = new System.Windows.Forms.DataGridView();
            this.btnConsultarLista = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarDato)).BeginInit();
            this.SuspendLayout();
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(110, 93);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(282, 20);
            this.textDescripcion.TabIndex = 3;
            this.textDescripcion.TextChanged += new System.EventHandler(this.textDescripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(431, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Nuevo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(110, 56);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(282, 20);
            this.textNombre.TabIndex = 9;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // dtMostrarDato
            // 
            this.dtMostrarDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMostrarDato.Location = new System.Drawing.Point(40, 153);
            this.dtMostrarDato.Name = "dtMostrarDato";
            this.dtMostrarDato.Size = new System.Drawing.Size(585, 216);
            this.dtMostrarDato.TabIndex = 10;
            this.dtMostrarDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMostrarDato_CellContentClick);
            // 
            // btnConsultarLista
            // 
            this.btnConsultarLista.Location = new System.Drawing.Point(550, 375);
            this.btnConsultarLista.Name = "btnConsultarLista";
            this.btnConsultarLista.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarLista.TabIndex = 11;
            this.btnConsultarLista.Text = "Mostrar";
            this.btnConsultarLista.UseVisualStyleBackColor = true;
            this.btnConsultarLista.Click += new System.EventHandler(this.btnConsultarLista_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(533, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(635, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultarLista);
            this.Controls.Add(this.dtMostrarDato);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDescripcion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrarDato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DataGridView dtMostrarDato;
        private System.Windows.Forms.Button btnConsultarLista;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

