using System.Data;
using WindowsForms.Models;
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class ActoresEFView : Form
    {
        ActorEFService actorEFService = new ActorEFService();
        Actor actorCurrent;
        List<Actor> actores;

        public ActoresEFView()
        {
            InitializeComponent();
            ObtenemosActores();
        }

        private async void ObtenemosActores()
        {
            GridPaises.DataSource = await actorEFService.GetAllAsync();
        }

        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridPaises.RowCount > 0 && GridPaises.SelectedRows.Count > 0)
            {
                Actor actorSeleccionado = (Actor)GridPaises.SelectedRows[0].DataBoundItem;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridPaises.RowCount > 0 && GridPaises.SelectedRows.Count > 0)
            {
                Actor actorSelected = (Actor)GridPaises.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el Actor {actorSelected.Id}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await actorEFService.DeleteAsync(actorSelected.Id))
                    {
                        LabelStatusMessage.Text = $"Actor {actorSelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        ObtenemosActores();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el Actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Actor para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabPageAgregarEditar");
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtTitulo.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Actor actorAGuardar = new Actor
            {
                Id = actorCurrent?.Id ?? 0, 
                Nombre = TxtTitulo.Text,
            };

            bool response;
            if (actorCurrent != null)
            {
                response=await actorEFService.UpdateAsync(actorAGuardar);
            }
            else
            {
                response = await actorEFService.AddAsync(actorAGuardar);
            }
            if (response)
            {
                actorCurrent = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = "Actor guardado correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                ObtenemosActores();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar el Actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridPaises.RowCount > 0 && GridPaises.SelectedRows.Count > 0)
            {
                actorCurrent = (Actor)GridPaises.SelectedRows[0].DataBoundItem;
                TxtTitulo.Text = actorCurrent.Nombre;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridPaises.DataSource = actores.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
                .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                BtnBuscar.PerformClick();
            }
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }
    }
}
