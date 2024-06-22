namespace PeliculasApp
{
    partial class frmAdministrador
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
            dtgvPeliculas = new DataGridView();
            NOMBRE = new DataGridViewTextBoxColumn();
            DIRECTOR = new DataGridViewTextBoxColumn();
            GENERO = new DataGridViewTextBoxColumn();
            lblNombre = new Label();
            label2 = new Label();
            lblDirector = new Label();
            lblInformacion = new Label();
            lblGenero = new Label();
            txtNombre = new TextBox();
            txtDirector = new TextBox();
            txtGenero = new TextBox();
            btnCrear = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvPeliculas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvPeliculas
            // 
            dtgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPeliculas.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, DIRECTOR, GENERO });
            dtgvPeliculas.Location = new Point(12, 423);
            dtgvPeliculas.Name = "dtgvPeliculas";
            dtgvPeliculas.RowHeadersWidth = 51;
            dtgvPeliculas.Size = new Size(725, 214);
            dtgvPeliculas.TabIndex = 0;
            dtgvPeliculas.CellClick += dtgvPeliculas_CellClick;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE DE LA PELICULA";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 125;
            // 
            // DIRECTOR
            // 
            DIRECTOR.HeaderText = "DIRECTOR";
            DIRECTOR.MinimumWidth = 6;
            DIRECTOR.Name = "DIRECTOR";
            DIRECTOR.Width = 125;
            // 
            // GENERO
            // 
            GENERO.HeaderText = "GENERO";
            GENERO.MinimumWidth = 6;
            GENERO.Name = "GENERO";
            GENERO.Width = 125;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(22, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(290, 29);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE DE LA PELICULA:";
            lblNombre.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 154);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDirector.Location = new Point(22, 145);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(136, 29);
            lblDirector.TabIndex = 3;
            lblDirector.Text = "DIRECTOR:";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformacion.Location = new Point(22, 373);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(125, 29);
            lblInformacion.TabIndex = 4;
            lblInformacion.Text = "pelicula:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(22, 209);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(110, 29);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "GENERO:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(398, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(301, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(398, 147);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(301, 27);
            txtDirector.TabIndex = 7;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(398, 209);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(301, 27);
            txtGenero.TabIndex = 8;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Green;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(167, 282);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(132, 39);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(436, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 39);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 53);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(206, 11);
            label4.Name = "label4";
            label4.Size = new Size(355, 29);
            label4.TabIndex = 12;
            label4.Text = "administrador de peliculas";
            // 
            // frmAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(749, 651);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(txtGenero);
            Controls.Add(txtDirector);
            Controls.Add(txtNombre);
            Controls.Add(lblGenero);
            Controls.Add(lblInformacion);
            Controls.Add(lblDirector);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(dtgvPeliculas);
            Name = "frmAdministrador";
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)dtgvPeliculas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvPeliculas;
        private Label lblNombre;
        private Label label2;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn DIRECTOR;
        private DataGridViewTextBoxColumn GENERO;
        private Label lblDirector;
        private Label lblInformacion;
        private Label lblGenero;
        private TextBox txtNombre;
        private TextBox txtDirector;
        private TextBox txtGenero;
        private Button btnCrear;
        private Button btnEliminar;
        private Panel panel1;
        private Label label4;
    }
}