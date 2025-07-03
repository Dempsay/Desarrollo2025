﻿namespace WindowsForms
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            SubmenuAppClima = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            SubmenuFormularioFuentes = new FontAwesome.Sharp.IconMenuItem();
            SubmenuJuegos = new FontAwesome.Sharp.IconMenuItem();
            SubmenuProcesadores = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            SubmenuFormPeliculasApi = new FontAwesome.Sharp.IconMenuItem();
            SubmenuFormPeliculasADO = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            SubmenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SubmenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            SubmenuPeliculasEF = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(890, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SubmenuAppClima, iconMenuItem3, iconMenuItem4 });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(104, 28);
            iconMenuItem1.Text = "Principal";
            // 
            // SubmenuAppClima
            // 
            SubmenuAppClima.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuAppClima.IconColor = Color.Black;
            SubmenuAppClima.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuAppClima.Name = "SubmenuAppClima";
            SubmenuAppClima.Size = new Size(228, 30);
            SubmenuAppClima.Text = "App Clima";
            SubmenuAppClima.Click += SubmenuAppClima_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { SubmenuFormularioFuentes, SubmenuJuegos, SubmenuProcesadores });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(228, 30);
            iconMenuItem3.Text = "Tareas";
            // 
            // SubmenuFormularioFuentes
            // 
            SubmenuFormularioFuentes.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuFormularioFuentes.IconColor = Color.Black;
            SubmenuFormularioFuentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuFormularioFuentes.Name = "SubmenuFormularioFuentes";
            SubmenuFormularioFuentes.Size = new Size(218, 26);
            SubmenuFormularioFuentes.Text = "Formulario Fuentes";
            SubmenuFormularioFuentes.Click += SubmenuFormularioFuentes_Click;
            // 
            // SubmenuJuegos
            // 
            SubmenuJuegos.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuJuegos.IconColor = Color.Black;
            SubmenuJuegos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuJuegos.Name = "SubmenuJuegos";
            SubmenuJuegos.Size = new Size(218, 26);
            SubmenuJuegos.Text = "Juegos";
            SubmenuJuegos.Click += SubmenuJuegos_Click;
            // 
            // SubmenuProcesadores
            // 
            SubmenuProcesadores.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuProcesadores.IconColor = Color.Black;
            SubmenuProcesadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuProcesadores.Name = "SubmenuProcesadores";
            SubmenuProcesadores.Size = new Size(218, 26);
            SubmenuProcesadores.Text = "Procesadores";
            SubmenuProcesadores.Click += SubmenuProcesadores_Click;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { SubmenuFormPeliculasApi, SubmenuFormPeliculasADO, SubmenuPeliculasEF });
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(228, 30);
            iconMenuItem4.Text = "Trabajos en clase";
            // 
            // SubmenuFormPeliculasApi
            // 
            SubmenuFormPeliculasApi.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuFormPeliculasApi.IconColor = Color.Black;
            SubmenuFormPeliculasApi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuFormPeliculasApi.Name = "SubmenuFormPeliculasApi";
            SubmenuFormPeliculasApi.Size = new Size(298, 30);
            SubmenuFormPeliculasApi.Text = "Formulario Películas(Api)";
            SubmenuFormPeliculasApi.Click += SubmenuFormPeliculasApi_Click;
            // 
            // SubmenuFormPeliculasADO
            // 
            SubmenuFormPeliculasADO.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuFormPeliculasADO.IconColor = Color.Black;
            SubmenuFormPeliculasADO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuFormPeliculasADO.Name = "SubmenuFormPeliculasADO";
            SubmenuFormPeliculasADO.Size = new Size(298, 30);
            SubmenuFormPeliculasADO.Text = "Formulario Películas(ADO Net)";
            SubmenuFormPeliculasADO.Click += SubmenuFormPeliculasADO_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { SubmenuSalirDelSistema, toolStripSeparator1, SubmenuAcercaDe });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(76, 28);
            iconMenuItem2.Text = "Salir";
            // 
            // SubmenuSalirDelSistema
            // 
            SubmenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuSalirDelSistema.IconColor = Color.Black;
            SubmenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuSalirDelSistema.Name = "SubmenuSalirDelSistema";
            SubmenuSalirDelSistema.Size = new Size(200, 26);
            SubmenuSalirDelSistema.Text = "Salir del sistema";
            SubmenuSalirDelSistema.Click += SubMenuSalirDelSistema_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(197, 6);
            // 
            // SubmenuAcercaDe
            // 
            SubmenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuAcercaDe.IconColor = Color.Black;
            SubmenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuAcercaDe.Name = "SubmenuAcercaDe";
            SubmenuAcercaDe.Size = new Size(200, 26);
            SubmenuAcercaDe.Text = "Acerca de...";
            // 
            // SubmenuPeliculasEF
            // 
            SubmenuPeliculasEF.IconChar = FontAwesome.Sharp.IconChar.None;
            SubmenuPeliculasEF.IconColor = Color.Black;
            SubmenuPeliculasEF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuPeliculasEF.Name = "SubmenuPeliculasEF";
            SubmenuPeliculasEF.Size = new Size(298, 30);
            SubmenuPeliculasEF.Text = "Formulario PeliculasEF";
            SubmenuPeliculasEF.Click += SubmenuPeliculasEF_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 447);
            Controls.Add(menuStrip1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MenuPrincipalView";
            Text = "Pruebas varias en Programación I - 2025";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem SubmenuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem SubmenuAppClima;
        private ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem SubmenuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem SubmenuFormularioFuentes;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem SubmenuFormPeliculasApi;
        private FontAwesome.Sharp.IconMenuItem SubmenuFormPeliculasADO;
        private FontAwesome.Sharp.IconMenuItem SubmenuJuegos;
        private FontAwesome.Sharp.IconMenuItem SubmenuProcesadores;
        private FontAwesome.Sharp.IconMenuItem SubmenuPeliculasEF;
    }
}
