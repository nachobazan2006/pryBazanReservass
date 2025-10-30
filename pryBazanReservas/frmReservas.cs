using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryBazanReservas
{
    public partial class frmReservas : Form
    {

        public frmReservas()
        {
            InitializeComponent();
        }


        public struct Cabaña
        {
            public const float TipoA = 20;
            public const float TipoB = 34;
            public const float Cocina = 1;
            public const float Heladera = 1.5f;
            public const float Televisor = 2;
            public const float PorPersona = 1;
        }


        private void frmReservas_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("A");
            cmbTipo.Items.Add("B");
            cmbTipo.SelectedIndex = 0;

            // se inicializa la cantidad de días en 1
            txtDias.Text = "1";

            // inicialzar los demás controles de la interfaz
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;

            // en los radiobuttons se asigna sólo el que debe quedar en true

            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTeléfonos.Text = "";
            // cargar los items del combo de tarjetas

            cmbTarjetas.Items.Clear();
            cmbTarjetas.Items.Add("Card Red");
            cmbTarjetas.Items.Add("Card Green");
            cmbTarjetas.Items.Add("Card Blue");
            // deshabiliar el botón "Aceptar"

            btnAceptar.Enabled = false;
        }

        

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Determinar máximo de personas según el tipo seleccionado
            int I = 0;
            if (cmbTipo.SelectedIndex == 0)
            {
                    for (I = 1; I <= 4; I++)
                    {
                        cmbPersonas.Items.Add(I);
                }

            }
            else 
            {
                for (I = 1; I <= 8; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            cmbPersonas.SelectedIndex = 0;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbTarjetas.Enabled = false;
            cmbTarjetas.SelectedIndex = -1;
        }
        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cmbTarjetas.Enabled = true;
            cmbTarjetas.SelectedIndex = 0;
        }
        //Condiciones para ;habilitar el botón Aceptar
      
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            float Total;
            int Dias;


               
                if (txtDias.Text == "")
                {
                    MessageBox.Show("Ingrese la cantidad de días", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDias.Focus();
                    return;
                }
               if (txtNombre.Text  == "")
                {
                    MessageBox.Show("Ingrese Nombre", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
            }
            if (txtTeléfonos.Text == "")
            {
                MessageBox.Show("Ingrese Teléfono", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (    cmbTarjetas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una tarjeta", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTarjetas.Focus();
                return;
            }

            // Obligar al usuario a poner al menos una persona
            if (cmbPersonas.Text == "")
            {
                MessageBox.Show("Seleccione al menos 1 persona", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPersonas.Focus();
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTipo.Focus();
                return;
            }
          





            Dias = int.Parse(txtDias.Text);
                //control del tipo de cabaña
                if (cmbTipo.SelectedIndex == 0)
                {
                    PrecioBase = Cabaña.TipoA;
                }
                else
                {
                    PrecioBase = Cabaña.TipoB;
                }
                Opcionales = 0;
                if (chkCocina.Checked == true)
                {
                    Opcionales = Opcionales + Cabaña.Cocina;
                }
                if (chkHeladera.Checked == true)
                {
                    Opcionales = Opcionales + Cabaña.Heladera;
                }
                if (chkTelevisor.Checked == true)
                {
                    Opcionales = Opcionales + Cabaña.Televisor;
                }
                // determinar el total por la cantidad de dìas
                Total = (PrecioBase + Opcionales) * Dias;



                if (optTarjeta.Checked == true)
                {
                    if (cmbTarjetas.SelectedIndex == 0)
                    {
                        Recargo = Total * 10 / 100;
                    }
                    else
                    {
                        Recargo = Total * 20 / 100;
                    }
                    Total = Total + Recargo;
                }
                // mostrar el resultado
                MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


                cmbTipo.SelectedIndex = 0;
                txtDias.Text = "1";
                chkCocina.Checked = false;
                chkHeladera.Checked = false;
                chkTelevisor.Checked = false;
                cmbPersonas.Items.Clear();
                optEfectivo.Checked = false;
                txtNombre.Text = "";
                txtTeléfonos.Text = "";
            }
        }
    }
    



