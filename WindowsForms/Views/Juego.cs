using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;

namespace WindowsForms.Views
{
    public partial class Juego : Form
    {
        HttpClient clientHttp = new HttpClient();
        string url = "https://gamescalification-bb0c.restdb.io/rest/games?apikey=302a221f95bc88ca1e9232cc9542aed551baa";
        Juegos JuegoModificado;
        List<Juegos> Juegos;
        public Juego()
        {
            InitializeComponent();
            ObtenemosJuegos();
        }
        private async void ObtenemosJuegos()
        {
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                Juegos = await response.Content.ReadFromJsonAsync<List<Juegos>>();
                DataView.DataSource = Juegos;
            }
        }
        private void FilmPicture_SelectionChanged(object sender, EventArgs e)
        {
            if (DataView.RowCount > 0 && DataView.SelectedRows.Count > 0)
            {
                Juegos juegoSeleccionado = (Juegos)DataView.SelectedRows[0].DataBoundItem;
                FilmPicture.ImageLocation = juegoSeleccionado.Portada;
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DataView.RowCount > 0 && DataView.SelectedRows.Count > 0)
            {
                Juegos JuegoSelecionado = (Juegos)DataView.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el juego {JuegoSelecionado.Titulo}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    string url = $"https://gamescalification-bb0c.restdb.io/rest/games/{JuegoSelecionado._id}?apikey=302a221f95bc88ca1e9232cc9542aed551baa";
                    var response = await clientHttp.DeleteAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Juego {JuegoSelecionado.Titulo} eliminado correctamente", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenemosJuegos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el juego");
                    }
                    MessageBox.Show($"Juego eliminado correctamente");
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageAgregarEditar");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabPageLista");
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtTitulo.Clear();
            TxtPortada.Clear();
            TxtClasificacion.Clear();
            TxtCategoria.Clear();
            NumericCalificacion.Value = 0;
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Juegos JuegoGuardar = new Juegos
            {
                Titulo = TxtTitulo.Text,
                Portada = TxtPortada.Text,
                Clasificación = TxtClasificacion.Text,
                Categoría = TxtCategoria.Text,
                Calificación = (double)NumericCalificacion.Value
            };
            HttpResponseMessage response;
            if (JuegoModificado != null)
            {
                var url = $"https://gamescalification-bb0c.restdb.io/rest/games/{JuegoModificado._id}?apikey=302a221f95bc88ca1e9232cc9542aed551baa";
                response = await clientHttp.PutAsJsonAsync(url, JuegoGuardar);

            }
            else
            {
                response = await clientHttp.PostAsJsonAsync(url, JuegoGuardar);
            }
            if (response.IsSuccessStatusCode)
            {
                JuegoModificado = null; // Limpiar la variable de modificación
                MessageBox.Show("Juego guardado correctamente", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenemosJuegos();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al guardar el juego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (DataView.RowCount > 0 && DataView.SelectedRows.Count > 0)
            {
                JuegoModificado = (Juegos)DataView.SelectedRows[0].DataBoundItem;
                TxtTitulo.Text = JuegoModificado.Titulo;
                TxtPortada.Text = JuegoModificado.Portada;
                TxtClasificacion.Text = JuegoModificado.Clasificación;
                TxtCategoria.Text = JuegoModificado.Categoría;
                NumericCalificacion.Value = (decimal)JuegoModificado.Calificación;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataView.DataSource = Juegos.Where(j => j.Titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBuscar.Text)) {
                {
                    BtnBuscar.PerformClick();
                }
            }
        }
    }
}
