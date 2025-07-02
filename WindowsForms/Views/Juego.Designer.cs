namespace WindowsForms.Views
{
    partial class Juego
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
            FilmPicture = new PictureBox();
            DataView = new DataGridView();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
            TabPageAgregarEditar = new TabPage();
            NumericCalificacion = new NumericUpDown();
            TxtClasificacion = new TextBox();
            TxtCategoria = new TextBox();
            TxtPortada = new TextBox();
            TxtTitulo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1 = new Panel();
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(-3, 81);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1125, 451);
            TabControl.TabIndex = 0;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(FilmPicture);
            TabPageLista.Controls.Add(DataView);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Location = new Point(4, 34);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3);
            TabPageLista.Size = new Size(1117, 413);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista de Juegos";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // FilmPicture
            // 
            FilmPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            FilmPicture.Location = new Point(660, 50);
            FilmPicture.Name = "FilmPicture";
            FilmPicture.Size = new Size(280, 354);
            FilmPicture.SizeMode = PictureBoxSizeMode.Zoom;
            FilmPicture.TabIndex = 9;
            FilmPicture.TabStop = false;
            // 
            // DataView
            // 
            DataView.AllowUserToAddRows = false;
            DataView.AllowUserToDeleteRows = false;
            DataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.Location = new Point(13, 48);
            DataView.MultiSelect = false;
            DataView.Name = "DataView";
            DataView.ReadOnly = true;
            DataView.RowHeadersWidth = 62;
            DataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataView.Size = new Size(631, 355);
            DataView.TabIndex = 8;
            DataView.SelectionChanged += FilmPicture_SelectionChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 30;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(386, 6);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(97, 31);
            BtnBuscar.TabIndex = 7;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 40;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(959, 245);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(135, 44);
            BtnSalir.TabIndex = 6;
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
            BtnEliminar.Location = new Point(959, 189);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(135, 50);
            BtnEliminar.TabIndex = 5;
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
            BtnModificar.Location = new Point(959, 139);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(135, 44);
            BtnModificar.TabIndex = 4;
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
            BtnAgregar.Location = new Point(959, 87);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(135, 46);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(85, 6);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(283, 31);
            TxtBuscar.TabIndex = 1;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 0;
            label2.Text = "Buscar:";
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(NumericCalificacion);
            TabPageAgregarEditar.Controls.Add(TxtClasificacion);
            TabPageAgregarEditar.Controls.Add(TxtCategoria);
            TabPageAgregarEditar.Controls.Add(TxtPortada);
            TabPageAgregarEditar.Controls.Add(TxtTitulo);
            TabPageAgregarEditar.Controls.Add(label7);
            TabPageAgregarEditar.Controls.Add(label6);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Location = new Point(4, 34);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3);
            TabPageAgregarEditar.Size = new Size(1117, 413);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // NumericCalificacion
            // 
            NumericCalificacion.Location = new Point(138, 106);
            NumericCalificacion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericCalificacion.Name = "NumericCalificacion";
            NumericCalificacion.Size = new Size(335, 31);
            NumericCalificacion.TabIndex = 15;
            NumericCalificacion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TxtClasificacion
            // 
            TxtClasificacion.Location = new Point(138, 194);
            TxtClasificacion.Name = "TxtClasificacion";
            TxtClasificacion.Size = new Size(344, 31);
            TxtClasificacion.TabIndex = 14;
            // 
            // TxtCategoria
            // 
            TxtCategoria.Location = new Point(138, 151);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(344, 31);
            TxtCategoria.TabIndex = 13;
            // 
            // TxtPortada
            // 
            TxtPortada.Location = new Point(138, 61);
            TxtPortada.Name = "TxtPortada";
            TxtPortada.Size = new Size(344, 31);
            TxtPortada.TabIndex = 12;
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(138, 16);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(344, 31);
            TxtTitulo.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 200);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 10;
            label7.Text = "Clasificación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 157);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 9;
            label6.Text = "Categoría";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 112);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 8;
            label5.Text = "Calificaión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 67);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 7;
            label4.Text = "Portada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 22);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 6;
            label3.Text = "Titulo";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Right;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 40;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(570, 317);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(135, 46);
            BtnCancelar.TabIndex = 5;
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
            BtnGuardar.Location = new Point(347, 317);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(135, 46);
            BtnGuardar.TabIndex = 4;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 47);
            label1.TabIndex = 1;
            label1.Text = "Lista de Juegos";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 85);
            panel1.TabIndex = 2;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1117, 525);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Name = "Juego";
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private DataGridView DataView;
        private PictureBox FilmPicture;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown NumericCalificacion;
        private TextBox TxtClasificacion;
        private TextBox TxtCategoria;
        private TextBox TxtPortada;
        private TextBox TxtTitulo;
    }
}