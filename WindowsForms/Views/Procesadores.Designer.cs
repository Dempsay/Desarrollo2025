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
            label7 = new Label();
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
            TabControl.Location = new Point(11, 40);
            TabControl.Margin = new Padding(2, 2, 2, 2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(879, 336);
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
            TabPageLista.Location = new Point(4, 24);
            TabPageLista.Margin = new Padding(2, 2, 2, 2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(2, 2, 2, 2);
            TabPageLista.Size = new Size(871, 308);
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
            BtnSalir.Location = new Point(751, 275);
            BtnSalir.Margin = new Padding(2, 2, 2, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(94, 26);
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
            BtnEliminar.Location = new Point(751, 122);
            BtnEliminar.Margin = new Padding(2, 2, 2, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 30);
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
            BtnModificar.Location = new Point(751, 85);
            BtnModificar.Margin = new Padding(2, 2, 2, 2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(94, 26);
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
            BtnAgregar.Location = new Point(751, 45);
            BtnAgregar.Margin = new Padding(2, 2, 2, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 28);
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
            BtnBuscar.Location = new Point(353, 12);
            BtnBuscar.Margin = new Padding(2, 2, 2, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(68, 19);
            BtnBuscar.TabIndex = 8;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(71, 12);
            TxtBuscar.Margin = new Padding(2, 2, 2, 2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(264, 23);
            TxtBuscar.TabIndex = 2;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // GridProcesadores
            // 
            GridProcesadores.AllowUserToAddRows = false;
            GridProcesadores.AllowUserToDeleteRows = false;
            GridProcesadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridProcesadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProcesadores.Location = new Point(11, 39);
            GridProcesadores.Margin = new Padding(2, 2, 2, 2);
            GridProcesadores.Name = "GridProcesadores";
            GridProcesadores.ReadOnly = true;
            GridProcesadores.RowHeadersWidth = 62;
            GridProcesadores.Size = new Size(704, 271);
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
            TabPageAgregarEditar.Location = new Point(4, 24);
            TabPageAgregarEditar.Margin = new Padding(2, 2, 2, 2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(2, 2, 2, 2);
            TabPageAgregarEditar.Size = new Size(871, 308);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // TxtSufijo
            // 
            TxtSufijo.Location = new Point(194, 138);
            TxtSufijo.Margin = new Padding(2, 2, 2, 2);
            TxtSufijo.Name = "TxtSufijo";
            TxtSufijo.Size = new Size(218, 23);
            TxtSufijo.TabIndex = 17;
            // 
            // TxtGeneracion
            // 
            TxtGeneracion.Location = new Point(194, 84);
            TxtGeneracion.Margin = new Padding(2, 2, 2, 2);
            TxtGeneracion.Name = "TxtGeneracion";
            TxtGeneracion.Size = new Size(218, 23);
            TxtGeneracion.TabIndex = 16;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(194, 56);
            TxtModelo.Margin = new Padding(2, 2, 2, 2);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(218, 23);
            TxtModelo.TabIndex = 15;
            // 
            // TxtModeloGeneracion
            // 
            TxtModeloGeneracion.Location = new Point(194, 109);
            TxtModeloGeneracion.Margin = new Padding(2, 2, 2, 2);
            TxtModeloGeneracion.Name = "TxtModeloGeneracion";
            TxtModeloGeneracion.Size = new Size(218, 23);
            TxtModeloGeneracion.TabIndex = 14;
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(194, 28);
            TxtMarca.Margin = new Padding(2, 2, 2, 2);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(218, 23);
            TxtMarca.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 12;
            label6.Text = "Sufijo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 113);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 11;
            label5.Text = "Modelo de la generacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 88);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Generacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 59);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
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
            BtnCancelar.Location = new Point(461, 247);
            BtnCancelar.Margin = new Padding(2, 2, 2, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 28);
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
            BtnGuardar.Location = new Point(305, 247);
            BtnGuardar.Margin = new Padding(2, 2, 2, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 28);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 10);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 1;
            label7.Text = "Procesadores";
            // 
            // Procesadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 383);
            Controls.Add(label7);
            Controls.Add(TabControl);
            Margin = new Padding(2, 2, 2, 2);
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
            PerformLayout();
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
        private Label label7;
    }
}