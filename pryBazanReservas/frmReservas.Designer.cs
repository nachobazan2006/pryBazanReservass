namespace pryBazanReservas
{
    partial class frmReservas
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
            gbTipo = new GroupBox();
            cmbPersonas = new ComboBox();
            txtDias = new TextBox();
            cmbTipo = new ComboBox();
            lblDías = new Label();
            lblPersonas = new Label();
            lblTipo = new Label();
            grbAdicionales = new GroupBox();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            grbFormasDePago = new GroupBox();
            cmbTarjetas = new ComboBox();
            lblTarjetas = new Label();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            grbTitular = new GroupBox();
            txtTeléfonos = new TextBox();
            txtNombre = new TextBox();
            lblTeléfonos = new Label();
            lblNombre = new Label();
            btnAceptar = new Button();
            gbTipo.SuspendLayout();
            grbAdicionales.SuspendLayout();
            grbFormasDePago.SuspendLayout();
            grbTitular.SuspendLayout();
            SuspendLayout();
            // 
            // gbTipo
            // 
            gbTipo.Controls.Add(cmbPersonas);
            gbTipo.Controls.Add(txtDias);
            gbTipo.Controls.Add(cmbTipo);
            gbTipo.Controls.Add(lblDías);
            gbTipo.Controls.Add(lblPersonas);
            gbTipo.Controls.Add(lblTipo);
            gbTipo.Location = new Point(32, 28);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(744, 100);
            gbTipo.TabIndex = 0;
            gbTipo.TabStop = false;
            gbTipo.Text = "Tipo de cabaña";
            // 
            // cmbPersonas
            // 
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbPersonas.Location = new Point(307, 47);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(121, 23);
            cmbPersonas.TabIndex = 5;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(500, 47);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(119, 23);
            txtDias.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "A", "B" });
            cmbTipo.Location = new Point(95, 47);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 1;
            // 
            // lblDías
            // 
            lblDías.AutoSize = true;
            lblDías.Location = new Point(465, 50);
            lblDías.Name = "lblDías";
            lblDías.Size = new Size(29, 15);
            lblDías.TabIndex = 2;
            lblDías.Text = "Días";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(247, 50);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 1;
            lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(40, 50);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // grbAdicionales
            // 
            grbAdicionales.Controls.Add(chkTelevisor);
            grbAdicionales.Controls.Add(chkHeladera);
            grbAdicionales.Controls.Add(chkCocina);
            grbAdicionales.Location = new Point(32, 185);
            grbAdicionales.Name = "grbAdicionales";
            grbAdicionales.Size = new Size(216, 161);
            grbAdicionales.TabIndex = 1;
            grbAdicionales.TabStop = false;
            grbAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(17, 119);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(72, 19);
            chkTelevisor.TabIndex = 4;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(17, 84);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 4;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(17, 47);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 4;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // grbFormasDePago
            // 
            grbFormasDePago.Controls.Add(cmbTarjetas);
            grbFormasDePago.Controls.Add(lblTarjetas);
            grbFormasDePago.Controls.Add(optTarjeta);
            grbFormasDePago.Controls.Add(optEfectivo);
            grbFormasDePago.Location = new Point(268, 185);
            grbFormasDePago.Name = "grbFormasDePago";
            grbFormasDePago.Size = new Size(508, 161);
            grbFormasDePago.TabIndex = 2;
            grbFormasDePago.TabStop = false;
            grbFormasDePago.Text = "Formas de pago";
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Items.AddRange(new object[] { "Card red", "Card green", "Card blue" });
            cmbTarjetas.Location = new Point(211, 119);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(270, 23);
            cmbTarjetas.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(211, 88);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(47, 15);
            lblTarjetas.TabIndex = 2;
            lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(11, 86);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(60, 19);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(11, 47);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // grbTitular
            // 
            grbTitular.Controls.Add(txtTeléfonos);
            grbTitular.Controls.Add(txtNombre);
            grbTitular.Controls.Add(lblTeléfonos);
            grbTitular.Controls.Add(lblNombre);
            grbTitular.Location = new Point(32, 384);
            grbTitular.Name = "grbTitular";
            grbTitular.Size = new Size(744, 141);
            grbTitular.TabIndex = 3;
            grbTitular.TabStop = false;
            grbTitular.Text = "Titular de la reserva";
            // 
            // txtTeléfonos
            // 
            txtTeléfonos.Location = new Point(131, 97);
            txtTeléfonos.Name = "txtTeléfonos";
            txtTeléfonos.Size = new Size(594, 23);
            txtTeléfonos.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(594, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblTeléfonos
            // 
            lblTeléfonos.AutoSize = true;
            lblTeléfonos.Location = new Point(40, 100);
            lblTeléfonos.Name = "lblTeléfonos";
            lblTeléfonos.Size = new Size(58, 15);
            lblTeléfonos.TabIndex = 1;
            lblTeléfonos.Text = "Teléfonos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(613, 558);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(163, 38);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(812, 628);
            Controls.Add(btnAceptar);
            Controls.Add(grbTitular);
            Controls.Add(grbFormasDePago);
            Controls.Add(grbAdicionales);
            Controls.Add(gbTipo);
            Name = "frmReservas";
            Text = "Reservas de cabañas";
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            grbAdicionales.ResumeLayout(false);
            grbAdicionales.PerformLayout();
            grbFormasDePago.ResumeLayout(false);
            grbFormasDePago.PerformLayout();
            grbTitular.ResumeLayout(false);
            grbTitular.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTipo;
        private ComboBox cmbTipo;
        private Label lblDías;
        private Label lblPersonas;
        private Label lblTipo;
        private GroupBox grbAdicionales;
        private GroupBox grbFormasDePago;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private GroupBox grbTitular;
        private Label lblTarjetas;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private ComboBox cmbTarjetas;
        private Label lblNombre;
        private Label lblTeléfonos;
        private TextBox txtTeléfonos;
        private TextBox txtNombre;
        private Button btnAceptar;
        private TextBox txtDias;
        private ComboBox cmbPersonas;
    }
}
