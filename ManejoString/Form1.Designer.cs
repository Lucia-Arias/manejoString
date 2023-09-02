namespace ManejoString
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.btLongitud = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btPrueba = new System.Windows.Forms.Button();
            this.btMayuscula = new System.Windows.Forms.Button();
            this.btMinuscula = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscado = new System.Windows.Forms.TextBox();
            this.btDeletrear = new System.Windows.Forms.Button();
            this.btExtraer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString.Location = new System.Drawing.Point(13, 13);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(815, 38);
            this.txtString.TabIndex = 0;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            // 
            // btLongitud
            // 
            this.btLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLongitud.Location = new System.Drawing.Point(13, 63);
            this.btLongitud.Name = "btLongitud";
            this.btLongitud.Size = new System.Drawing.Size(139, 42);
            this.btLongitud.TabIndex = 1;
            this.btLongitud.Text = "Longitud";
            this.btLongitud.UseVisualStyleBackColor = true;
            this.btLongitud.Click += new System.EventHandler(this.btLongitud_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(10, 115);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 31);
            this.lblResultado.TabIndex = 2;
            // 
            // btPrueba
            // 
            this.btPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrueba.Location = new System.Drawing.Point(171, 63);
            this.btPrueba.Name = "btPrueba";
            this.btPrueba.Size = new System.Drawing.Size(118, 39);
            this.btPrueba.TabIndex = 3;
            this.btPrueba.Text = "Prueba";
            this.btPrueba.UseVisualStyleBackColor = true;
            this.btPrueba.Click += new System.EventHandler(this.btPrueba_Click);
            // 
            // btMayuscula
            // 
            this.btMayuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMayuscula.Location = new System.Drawing.Point(312, 63);
            this.btMayuscula.Name = "btMayuscula";
            this.btMayuscula.Size = new System.Drawing.Size(168, 39);
            this.btMayuscula.TabIndex = 4;
            this.btMayuscula.Text = "Mayuscula";
            this.btMayuscula.UseVisualStyleBackColor = true;
            this.btMayuscula.Click += new System.EventHandler(this.btMayuscula_Click);
            // 
            // btMinuscula
            // 
            this.btMinuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinuscula.Location = new System.Drawing.Point(486, 65);
            this.btMinuscula.Name = "btMinuscula";
            this.btMinuscula.Size = new System.Drawing.Size(168, 39);
            this.btMinuscula.TabIndex = 5;
            this.btMinuscula.Text = "Minuscula";
            this.btMinuscula.UseVisualStyleBackColor = true;
            this.btMinuscula.Click += new System.EventHandler(this.btMinuscula_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(660, 66);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(168, 39);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscado
            // 
            this.txtBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscado.Location = new System.Drawing.Point(862, 13);
            this.txtBuscado.Name = "txtBuscado";
            this.txtBuscado.Size = new System.Drawing.Size(319, 38);
            this.txtBuscado.TabIndex = 7;
            this.txtBuscado.TextChanged += new System.EventHandler(this.txtBuscado_TextChanged);
            // 
            // btDeletrear
            // 
            this.btDeletrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletrear.Location = new System.Drawing.Point(839, 65);
            this.btDeletrear.Name = "btDeletrear";
            this.btDeletrear.Size = new System.Drawing.Size(168, 39);
            this.btDeletrear.TabIndex = 9;
            this.btDeletrear.Text = "Deletrear";
            this.btDeletrear.UseVisualStyleBackColor = true;
            this.btDeletrear.Click += new System.EventHandler(this.btDeletrear_Click);
            // 
            // btExtraer
            // 
            this.btExtraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExtraer.Location = new System.Drawing.Point(1013, 65);
            this.btExtraer.Name = "btExtraer";
            this.btExtraer.Size = new System.Drawing.Size(168, 39);
            this.btExtraer.TabIndex = 10;
            this.btExtraer.Text = "Extraer";
            this.btExtraer.UseVisualStyleBackColor = true;
            this.btExtraer.Click += new System.EventHandler(this.btExtraer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 177);
            this.Controls.Add(this.btExtraer);
            this.Controls.Add(this.btDeletrear);
            this.Controls.Add(this.txtBuscado);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btMinuscula);
            this.Controls.Add(this.btMayuscula);
            this.Controls.Add(this.btPrueba);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btLongitud);
            this.Controls.Add(this.txtString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btLongitud;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btPrueba;
        private System.Windows.Forms.Button btMayuscula;
        private System.Windows.Forms.Button btMinuscula;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Button btDeletrear;
        private System.Windows.Forms.Button btExtraer;
    }
}

