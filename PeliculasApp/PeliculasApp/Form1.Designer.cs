namespace PeliculasApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblContra = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(60, 100);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(125, 29);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUARIO :";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContra.Location = new Point(60, 141);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(168, 29);
            lblContra.TabIndex = 1;
            lblContra.Text = "CONTRASEÑA :";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Green;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(188, 204);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(147, 49);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(251, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(187, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(251, 142);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(187, 27);
            txtContra.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 65);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(166, 16);
            label1.Name = "label1";
            label1.Size = new Size(201, 35);
            label1.TabIndex = 6;
            label1.Text = "inicia sesion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(528, 279);
            Controls.Add(panel1);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblContra);
            Controls.Add(lblUsuario);
            Name = "Form1";
            Text = "Inicio de Sesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContra;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Panel panel1;
        private Label label1;
    }
}
