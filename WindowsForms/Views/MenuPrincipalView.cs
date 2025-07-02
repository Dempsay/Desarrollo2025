using WindowsForms.Models;
using WindowsForms.Views;

namespace WindowsForms
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmenuAppClima_Click(object sender, EventArgs e)
        {
            var appClimaView = new ClimaAppView();
            appClimaView.ShowDialog();
        }

        private void SubmenuFormularioFuentes_Click(object sender, EventArgs e)
        {
            var fuentesView = new FuentesView();
            fuentesView.ShowDialog();
        }

        private void SubmenuFormPeliculasApi_Click(object sender, EventArgs e)
        {
            var peliculasView = new PeliculasView();
            peliculasView.ShowDialog();
        }

        private void SubmenuFormPeliculasADO_Click(object sender, EventArgs e)
        {
            var peliculasADOView = new PeliculasADOView();
            peliculasADOView.ShowDialog();
        }

        private void SubmenuJuegos_Click(object sender, EventArgs e)
        {
            var juego = new Juego();
            juego.ShowDialog();
        }

        private void SubmenuProcesadores_Click(object sender, EventArgs e)
        {
            var procesadoresView = new Procesadores();
            procesadoresView.ShowDialog();
        }
    }
}
