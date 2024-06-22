namespace PeliculasApp
{
    public partial class Form1 : Form
    {
        frmAdministrador logeo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text != "") && (txtContra.Text != ""))
            {
                if((txtUsuario.Text == "Julio") && (txtContra.Text == "progra"))
                {
                    logeo = new frmAdministrador();
                    logeo.Show();
                    this.Hide();
                }
            }
        }
    }
}
