namespace BibliotecaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblCantPaginas = new System.Windows.Forms.Label();
            this.txtCantPaginas = new System.Windows.Forms.TextBox();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnFinalizarEstante = new System.Windows.Forms.Button();
            this.lstResumen = new System.Windows.Forms.ListBox();
            this.lblEstante = new System.Windows.Forms.Label();
            this.lblResumenFinal = new System.Windows.Forms.Label();
            this.lstResumenFinal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombreLibro
            // 
            resources.ApplyResources(this.lblNombreLibro, "lblNombreLibro");
            this.lblNombreLibro.BackColor = System.Drawing.Color.Chocolate;
            this.lblNombreLibro.Name = "lblNombreLibro";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.txtNombreLibro, "txtNombreLibro");
            this.txtNombreLibro.Name = "txtNombreLibro";
            // 
            // lblGenero
            // 
            resources.ApplyResources(this.lblGenero, "lblGenero");
            this.lblGenero.BackColor = System.Drawing.Color.Chocolate;
            this.lblGenero.Name = "lblGenero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.MistyRose;
            this.cmbGenero.FormattingEnabled = true;
            resources.ApplyResources(this.cmbGenero, "cmbGenero");
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // lblCantPaginas
            // 
            resources.ApplyResources(this.lblCantPaginas, "lblCantPaginas");
            this.lblCantPaginas.BackColor = System.Drawing.Color.Chocolate;
            this.lblCantPaginas.Name = "lblCantPaginas";
            // 
            // txtCantPaginas
            // 
            this.txtCantPaginas.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.txtCantPaginas, "txtCantPaginas");
            this.txtCantPaginas.Name = "txtCantPaginas";
            this.txtCantPaginas.TextChanged += new System.EventHandler(this.txtCantPaginas_TextChanged);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.btnAgregarLibro, "btnAgregarLibro");
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnFinalizarEstante
            // 
            this.btnFinalizarEstante.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.btnFinalizarEstante, "btnFinalizarEstante");
            this.btnFinalizarEstante.Name = "btnFinalizarEstante";
            this.btnFinalizarEstante.UseVisualStyleBackColor = false;
            this.btnFinalizarEstante.Click += new System.EventHandler(this.btnFinalizarEstante_Click);
            // 
            // lstResumen
            // 
            this.lstResumen.BackColor = System.Drawing.Color.MistyRose;
            this.lstResumen.FormattingEnabled = true;
            resources.ApplyResources(this.lstResumen, "lstResumen");
            this.lstResumen.Name = "lstResumen";
            // 
            // lblEstante
            // 
            resources.ApplyResources(this.lblEstante, "lblEstante");
            this.lblEstante.BackColor = System.Drawing.Color.Chocolate;
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Click += new System.EventHandler(this.lblEstante_Click);
            // 
            // lblResumenFinal
            // 
            resources.ApplyResources(this.lblResumenFinal, "lblResumenFinal");
            this.lblResumenFinal.BackColor = System.Drawing.Color.Chocolate;
            this.lblResumenFinal.Name = "lblResumenFinal";
            this.lblResumenFinal.Click += new System.EventHandler(this.lblResumenFinal_Click);
            // 
            // lstResumenFinal
            // 
            this.lstResumenFinal.BackColor = System.Drawing.Color.MistyRose;
            this.lstResumenFinal.FormattingEnabled = true;
            resources.ApplyResources(this.lstResumenFinal, "lstResumenFinal");
            this.lstResumenFinal.Name = "lstResumenFinal";
            this.lstResumenFinal.Click += new System.EventHandler(this.lblResumenFinal_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.lstResumenFinal);
            this.Controls.Add(this.lblResumenFinal);
            this.Controls.Add(this.lblEstante);
            this.Controls.Add(this.lstResumen);
            this.Controls.Add(this.btnFinalizarEstante);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.txtCantPaginas);
            this.Controls.Add(this.lblCantPaginas);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.lblNombreLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblCantPaginas;
        private System.Windows.Forms.TextBox txtCantPaginas;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnFinalizarEstante;
        private System.Windows.Forms.ListBox lstResumen;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.Label lblResumenFinal;
        private System.Windows.Forms.ListBox lstResumenFinal;
    }
}

