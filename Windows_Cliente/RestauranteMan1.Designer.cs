
namespace Windows_Cliente
{
    partial class RestauranteMan1
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dtgRestaurantes = new System.Windows.Forms.DataGridView();
            this.Id_Restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_CategoriaRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direc_Restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_DistritoRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tele_Restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_EstadoRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRestaurantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(839, 377);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(159, 37);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(642, 377);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(159, 37);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dtgRestaurantes
            // 
            this.dtgRestaurantes.AllowUserToAddRows = false;
            this.dtgRestaurantes.AllowUserToDeleteRows = false;
            this.dtgRestaurantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRestaurantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRestaurantes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRestaurantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Restaurante,
            this.Nom_Restaurante,
            this.Nom_CategoriaRestaurante,
            this.Direc_Restaurante,
            this.Nom_DistritoRestaurante,
            this.Tele_Restaurante,
            this.Nom_EstadoRestaurante});
            this.dtgRestaurantes.Location = new System.Drawing.Point(42, 42);
            this.dtgRestaurantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgRestaurantes.Name = "dtgRestaurantes";
            this.dtgRestaurantes.ReadOnly = true;
            this.dtgRestaurantes.RowHeadersVisible = false;
            this.dtgRestaurantes.Size = new System.Drawing.Size(956, 312);
            this.dtgRestaurantes.TabIndex = 7;
            this.dtgRestaurantes.DoubleClick += new System.EventHandler(this.dtgRestaurantes_DoubleClick);
            // 
            // Id_Restaurante
            // 
            this.Id_Restaurante.DataPropertyName = "Id_Restaurante";
            this.Id_Restaurante.HeaderText = "Código";
            this.Id_Restaurante.Name = "Id_Restaurante";
            this.Id_Restaurante.ReadOnly = true;
            this.Id_Restaurante.Visible = false;
            // 
            // Nom_Restaurante
            // 
            this.Nom_Restaurante.DataPropertyName = "Nom_Restaurante";
            this.Nom_Restaurante.HeaderText = "Nombre";
            this.Nom_Restaurante.Name = "Nom_Restaurante";
            this.Nom_Restaurante.ReadOnly = true;
            // 
            // Nom_CategoriaRestaurante
            // 
            this.Nom_CategoriaRestaurante.DataPropertyName = "Nom_CategoriaRestaurante";
            this.Nom_CategoriaRestaurante.HeaderText = "Categoria";
            this.Nom_CategoriaRestaurante.Name = "Nom_CategoriaRestaurante";
            this.Nom_CategoriaRestaurante.ReadOnly = true;
            // 
            // Direc_Restaurante
            // 
            this.Direc_Restaurante.DataPropertyName = "Direc_Restaurante";
            this.Direc_Restaurante.HeaderText = "Dirección";
            this.Direc_Restaurante.Name = "Direc_Restaurante";
            this.Direc_Restaurante.ReadOnly = true;
            // 
            // Nom_DistritoRestaurante
            // 
            this.Nom_DistritoRestaurante.DataPropertyName = "Nom_DistritoRestaurante";
            this.Nom_DistritoRestaurante.HeaderText = "Distrito";
            this.Nom_DistritoRestaurante.Name = "Nom_DistritoRestaurante";
            this.Nom_DistritoRestaurante.ReadOnly = true;
            // 
            // Tele_Restaurante
            // 
            this.Tele_Restaurante.DataPropertyName = "Tele_Restaurante";
            this.Tele_Restaurante.HeaderText = "Teléfono";
            this.Tele_Restaurante.Name = "Tele_Restaurante";
            this.Tele_Restaurante.ReadOnly = true;
            // 
            // Nom_EstadoRestaurante
            // 
            this.Nom_EstadoRestaurante.DataPropertyName = "Nom_EstadoRestaurante";
            this.Nom_EstadoRestaurante.HeaderText = "Estado";
            this.Nom_EstadoRestaurante.Name = "Nom_EstadoRestaurante";
            this.Nom_EstadoRestaurante.ReadOnly = true;
            // 
            // RestauranteMan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 454);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgRestaurantes);
            this.MaximizeBox = false;
            this.Name = "RestauranteMan1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurantes";
            this.Load += new System.EventHandler(this.RestauranteMan1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRestaurantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dtgRestaurantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Restaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Restaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_CategoriaRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direc_Restaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_DistritoRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tele_Restaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_EstadoRestaurante;
    }
}