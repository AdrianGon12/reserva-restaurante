
namespace Windows_Cliente
{
    partial class frmExcel
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
            this.cboRestaurante = new System.Windows.Forms.ComboBox();
            this.btnListadoReservas = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgReservas = new System.Windows.Forms.DataGridView();
            this.Usua_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usua_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRestaurante
            // 
            this.cboRestaurante.FormattingEnabled = true;
            this.cboRestaurante.Location = new System.Drawing.Point(58, 55);
            this.cboRestaurante.Margin = new System.Windows.Forms.Padding(4);
            this.cboRestaurante.Name = "cboRestaurante";
            this.cboRestaurante.Size = new System.Drawing.Size(255, 21);
            this.cboRestaurante.TabIndex = 25;
            // 
            // btnListadoReservas
            // 
            this.btnListadoReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListadoReservas.Location = new System.Drawing.Point(787, 425);
            this.btnListadoReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListadoReservas.Name = "btnListadoReservas";
            this.btnListadoReservas.Size = new System.Drawing.Size(199, 42);
            this.btnListadoReservas.TabIndex = 26;
            this.btnListadoReservas.Text = "Descargar Reservas";
            this.btnListadoReservas.UseVisualStyleBackColor = true;
            this.btnListadoReservas.Click += new System.EventHandler(this.btnListadoReservas_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(371, 48);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 33);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgReservas
            // 
            this.dtgReservas.AllowUserToAddRows = false;
            this.dtgReservas.AllowUserToDeleteRows = false;
            this.dtgReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReservas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usua_Nombre,
            this.Usua_Apellido,
            this.Cant_Personas,
            this.Fecha_Reserva,
            this.Estado_Reserva});
            this.dtgReservas.Location = new System.Drawing.Point(58, 137);
            this.dtgReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgReservas.Name = "dtgReservas";
            this.dtgReservas.ReadOnly = true;
            this.dtgReservas.RowHeadersVisible = false;
            this.dtgReservas.Size = new System.Drawing.Size(928, 241);
            this.dtgReservas.TabIndex = 29;
            // 
            // Usua_Nombre
            // 
            this.Usua_Nombre.DataPropertyName = "Usua_Nombre";
            this.Usua_Nombre.HeaderText = "Nombre";
            this.Usua_Nombre.Name = "Usua_Nombre";
            this.Usua_Nombre.ReadOnly = true;
            // 
            // Usua_Apellido
            // 
            this.Usua_Apellido.DataPropertyName = "Usua_Apellido";
            this.Usua_Apellido.HeaderText = "Apellido";
            this.Usua_Apellido.Name = "Usua_Apellido";
            this.Usua_Apellido.ReadOnly = true;
            // 
            // Cant_Personas
            // 
            this.Cant_Personas.DataPropertyName = "Cant_Personas";
            this.Cant_Personas.HeaderText = "Cant. Personas";
            this.Cant_Personas.Name = "Cant_Personas";
            this.Cant_Personas.ReadOnly = true;
            // 
            // Fecha_Reserva
            // 
            this.Fecha_Reserva.DataPropertyName = "Fecha_Reserva";
            this.Fecha_Reserva.HeaderText = "Fecha";
            this.Fecha_Reserva.Name = "Fecha_Reserva";
            this.Fecha_Reserva.ReadOnly = true;
            // 
            // Estado_Reserva
            // 
            this.Estado_Reserva.DataPropertyName = "Estado_Reserva";
            this.Estado_Reserva.HeaderText = "Estado";
            this.Estado_Reserva.Name = "Estado_Reserva";
            this.Estado_Reserva.ReadOnly = true;
            // 
            // frmExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 535);
            this.Controls.Add(this.dtgReservas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListadoReservas);
            this.Controls.Add(this.cboRestaurante);
            this.MaximizeBox = false;
            this.Name = "frmExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel";
            this.Load += new System.EventHandler(this.frmExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRestaurante;
        private System.Windows.Forms.Button btnListadoReservas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usua_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usua_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Personas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Reserva;
    }
}