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
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class Procesadores : Form
    {
        ProcesadorADOService procesadorService = new ProcesadorADOService();
        Procesador procesadorModificado;
        List<Procesador> procesadores;
        public Procesadores()
        {
            InitializeComponent();
            ObtenemosProcesadores();
        }
        private async void ObtenemosProcesadores()
        {
            procesadores = await procesadorService.GetAllAsync();
            GridProcesadores.DataSource = procesadores;
        }

        private void GridProcesadores_SelectionChanged(object sender, EventArgs e)
        {
            if (GridProcesadores.RowCount > 0 && GridProcesadores.SelectedRows.Count > 0)
            {
                Procesador procesadorSeleccionada = (Procesador)GridProcesadores.SelectedRows[0].DataBoundItem;
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (GridProcesadores.RowCount > 0 && GridProcesadores.SelectedRows.Count > 0)
            {
                Procesador procesadorSeleccionado = (Procesador)GridProcesadores.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el procesador?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await procesadorService.DeleteAsync(procesadorSeleccionado.id))
                    {
                        MessageBox.Show($"Procesador eliminado correctamente", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el procesador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un procesador para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TxtMarca.Text = string.Empty;
            TxtModelo.Text = string.Empty;
            TxtGeneracion.Text = string.Empty;
            TxtModeloGeneracion.Text = string.Empty;
            TxtSufijo.Text = string.Empty;
            procesadorModificado = null;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
            procesadorModificado = null;
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Procesador procesadorAGuardar = new Procesador
            {
                id = procesadorModificado?.id ?? 0,
                marca = TxtMarca.Text,
                modelo = TxtModelo.Text,
                generacion = TxtGeneracion.Text,
                modelo_generacion = TxtModeloGeneracion.Text,
                sufijo = TxtSufijo.Text
            };
            bool response;
            if (procesadorModificado != null)
            {
                response = await procesadorService.UpdateAsync(procesadorAGuardar);
            }
            else
            {
                response = await procesadorService.AddAsync(procesadorAGuardar);
            }
            if (response)
            {
                procesadorModificado = null; // Reset the modified movie after saving
                MessageBox.Show("Procesador guardado correctamente");
                ObtenemosProcesadores();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar el Procesador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridProcesadores.RowCount > 0 && GridProcesadores.SelectedRows.Count > 0)
            {
                procesadorModificado = (Procesador)GridProcesadores.SelectedRows[0].DataBoundItem;
                TxtMarca.Text = procesadorModificado.marca;
                TxtModelo.Text = procesadorModificado.modelo;
                TxtGeneracion.Text = procesadorModificado.generacion;
                TxtModeloGeneracion.Text = procesadorModificado.modelo_generacion;
                TxtSufijo.Text = procesadorModificado.sufijo;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridProcesadores.DataSource = procesadores.Where(p => p.marca.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
                .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                BtnBuscar.PerformClick();
            }
        }
    }
}
