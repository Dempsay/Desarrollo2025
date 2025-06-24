namespace WindowsForms
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo 2");
        }
    }
}
