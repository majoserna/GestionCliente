using CapaNegocio;
using CapaDatos;



namespace GestionClientes
{
    public partial class FrmPadre : Form
    {
        public FrmPadre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            padre pue =new padre();
            pue.id = 1;

            MessageBox.Show(pue.suma(1, 2).ToString());

            hija hija = new hija();
            hija.id = 2;

            CapaNegocio.clsCliente cliente = new clsCliente();
            cliente.name = "Richard";
        }
    }
}