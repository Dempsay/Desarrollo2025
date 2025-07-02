namespace WindowsForms.Views
{
    partial class Procesadores
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
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label1 = new Label();
            GridProcesadores = new DataGridView();
            TabPageAgregarEditar = new TabPage();
            TxtSufijo = new TextBox();
            TxtGeneracion = new TextBox();
            TxtModelo = new TextBox();
            TxtModeloGeneracion = new TextBox();
            TxtMarca = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridProcesadores).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(16, 67);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1256, 560);
            TabControl.TabIndex = 0;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label1);
            TabPageLista.Controls.Add(GridProcesadores);
            TabPageLista.Location = new Point(4, 34);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3);
            TabPageLista.Size = new Size(1248, 522);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista de Procesadores";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 40;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(1073, 458);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(135, 44);
            BtnSalir.TabIndex = 12;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Right;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 40;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(1073, 203);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(135, 50);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Right;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.IconSize = 40;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(1073, 142);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(135, 44);
            BtnModificar.TabIndex = 10;
            BtnModificar.Text = "Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Right;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.IconSize = 40;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(1073, 75);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(135, 46);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 30;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(504, 20);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(97, 31);
            BtnBuscar.TabIndex = 8;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(101, 20);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(376, 31);
            TxtBuscar.TabIndex = 2;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // GridProcesadores
            // 
            GridProcesadores.AllowUserToAddRows = false;
            GridProcesadores.AllowUserToDeleteRows = false;
            GridProcesadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridProcesadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProcesadores.Location = new Point(16, 65);
            GridProcesadores.Name = "GridProcesadores";
            GridProcesadores.ReadOnly = true;
            GridProcesadores.RowHeadersWidth = 62;
            GridProcesadores.Size = new Size(1005, 451);
            GridProcesadores.TabIndex = 0;
            GridProcesadores.SelectionChanged += GridProcesadores_SelectionChanged;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(TxtSufijo);
            TabPageAgregarEditar.Controls.Add(TxtGeneracion);
            TabPageAgregarEditar.Controls.Add(TxtModelo);
            TabPageAgregarEditar.Controls.Add(TxtModeloGeneracion);
            TabPageAgregarEditar.Controls.Add(TxtMarca);
            TabPageAgregarEditar.Controls.Add(label6);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(label2);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Location = new Point(4, 34);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3);
            TabPageAgregarEditar.Size = new Size(1248, 522);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // TxtSufijo
            // 
            TxtSufijo.Location = new Point(277, 230);
            TxtSufijo.Name = "TxtSufijo";
            TxtSufijo.Size = new Size(309, 31);
            TxtSufijo.TabIndex = 17;
            // 
            // TxtGeneracion
            // 
            TxtGeneracion.Location = new Point(277, 140);
            TxtGeneracion.Name = "TxtGeneracion";
            TxtGeneracion.Size = new Size(309, 31);
            TxtGeneracion.TabIndex = 16;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(277, 93);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(309, 31);
            TxtModelo.TabIndex = 15;
            // 
            // TxtModeloGeneracion
            // 
            TxtModeloGeneracion.Location = new Point(277, 182);
            TxtModeloGeneracion.Name = "TxtModeloGeneracion";
            TxtModeloGeneracion.Size = new Size(309, 31);
            TxtModeloGeneracion.TabIndex = 14;
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(277, 46);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(309, 31);
            TxtMarca.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 236);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 12;
            label6.Text = "Sufijo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 188);
            label5.Name = "label5";
            label5.Size = new Size(213, 25);
            label5.TabIndex = 11;
            label5.Text = "Modelo de la generacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 146);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 10;
            label4.Text = "Generacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 99);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 9;
            label3.Text = "Modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 52);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 8;
            label2.Text = "Marca:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Right;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 40;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(659, 411);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(135, 46);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Right;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 40;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(436, 411);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(135, 46);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // Procesadores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 639);
            Controls.Add(TabControl);
            Name = "Procesadores";
            Text = "Procesadores";
            WindowState = FormWindowState.Maximized;
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridProcesadores).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private DataGridView GridProcesadores;
        private Label label1;
        private TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtSufijo;
        private TextBox TxtGeneracion;
        private TextBox TxtModelo;
        private TextBox TxtModeloGeneracion;
        private TextBox TxtMarca;
    }
}