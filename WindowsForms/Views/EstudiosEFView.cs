using System.Data;
using WindowsForms.Models;
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class EstudiosEFView : Form
    {
        EstudioEFService estudioService = new EstudioEFService();
        Estudio EstudioModificado;
        List<Estudio> Estudios;

        public EstudiosEFView()
        {
            InitializeComponent();
            ObtenemosEstudios();
        }

        private async void ObtenemosEstudios()
        {
            GridEstudios.DataSource = await estudioService.GetAllAsync();
        }

        private void GridEstudios_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridEstudios.RowCount > 0 && GridEstudios.SelectedRows.Count > 0)
            {
                Estudio estudioSeleccionado = (Estudio)GridEstudios.SelectedRows[0].DataBoundItem;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridEstudios.RowCount > 0 && GridEstudios.SelectedRows.Count > 0)
            {
                Estudio estudioSeleccionado = (Estudio)GridEstudios.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el estudio {estudioSeleccionado.nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await estudioService.DeleteAsync(estudioSeleccionado.id))
                    {
                        LabelStatusMessage.Text = $"Estudio {estudioSeleccionado.nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        ObtenemosEstudios();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el Estudio de Cine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Estudio para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TxtNombre.Clear();
            TxtDireccion.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Estudio estudioAGuardar = new Estudio
            {
                id = EstudioModificado?.id??null, 
                nombre = TxtNombre.Text,
                direccion = TxtDireccion.Text,
            };

            bool response;
            if (EstudioModificado != null)
            {
                response=await estudioService.UpdateAsync(estudioAGuardar);
            }
            else
            {
                response = await estudioService.AddAsync(estudioAGuardar);
            }
            if (response)
            {
                EstudioModificado = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = "Estudio guardado correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                ObtenemosEstudios();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar el Estudio de Cine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridEstudios.RowCount > 0 && GridEstudios.SelectedRows.Count > 0)
            {
                EstudioModificado = (Estudio)GridEstudios.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = EstudioModificado.nombre;
                TxtDireccion.Text = EstudioModificado.direccion;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridEstudios.DataSource = Estudios.Where(p => p.nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
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
