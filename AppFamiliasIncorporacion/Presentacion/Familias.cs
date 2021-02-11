using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Cargando las Capas de Logica y Datos a la Capa de Presentacion
using AppFamiliasIncorporacion.Logica;
using AppFamiliasIncorporacion.Datos;

namespace AppFamiliasIncorporacion.Presentacion
{
    public partial class Familias : Form
    {
        public Familias()
        {
            InitializeComponent();
            //Cargando la Vista de la Familia
            vista_Familia();
        }

        //Metodos para Visualizacion de los Datos de las Capas de Logica y Datos
        private void vista_Familia() {
            DataTable dtFamilias;
            dFamilias metodos = new dFamilias();
            dtFamilias = metodos.vistaDB();
            gdtgFamilias.DataSource = dtFamilias;
        }
        //Metodo para Insertar los DAtos en la DB
        private void insertar_Familia()
        {
            lFamIncorporacion dtFamilia = new lFamIncorporacion();
            dFamilias metodos = new dFamilias();

            dtFamilia.familiaId =Convert.ToInt32( gtxtFamiliaId.Text);
            dtFamilia.folioEncuesta = gtxtFolioEncuesta.Text;
            dtFamilia.tutora = gtxtNombreTutora.Text;
            dtFamilia.tutoraPaterno = gtxtApellidoPTutora.Text;
            dtFamilia.tutoraMaterno = gtxtApellidoMTutora.Text;
            dtFamilia.tutoraCurp = gtxtCurp.Text;
            dtFamilia.folioAvisoCobro = gtxtFolioAvisoCobro.Text;
            dtFamilia.obsCris = gtxtCris.Text;
            dtFamilia.obsNoti = gtxtNoti.Text;
            dtFamilia.obsAviso = gtxtAviso.Text;


            if (metodos.insertarDB (dtFamilia))
            {
                MessageBox.Show("Familia Registrada", "Registro Correcto");
                pnlFamilia.Visible = false;
                pnlFamilia.Dock = DockStyle.None;
                gdtgFamilias.Visible = true;
            }

        }
        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            gtxtSearch.Text = null;
        }

        private void Familias_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            pnlFamilia.Visible = true;
            pnlFamilia.Dock = DockStyle.Fill;
            gdtgFamilias.Visible = false;
            gbtnGuardar.Visible = true;
            gbtnActualizar.Visible = false;
            gtxtFamiliaId.Clear();
            gtxtFolioEncuesta.Clear();
            gtxtFolioAvisoCobro.Clear();
            gtxtNombreTutora.Clear();
            gtxtApellidoPTutora.Clear();
            gtxtApellidoMTutora.Clear();
            gtxtCurp.Clear();
            gtxtAviso.Clear();
            gtxtCris.Clear();
            gtxtNoti.Clear();
            gtxtAviso.Clear();
            
        }

        private void gbtnRegresar_Click(object sender, EventArgs e)
        {
            pnlFamilia.Visible = false;
            pnlFamilia.Dock = DockStyle.None;
            gdtgFamilias.Visible = true;
        }

        private void gbtnGuardar_Click(object sender, EventArgs e)
        {
            if (gtxtFamiliaId.Text != "")
            {
                insertar_Familia();
                vista_Familia();
            }
            else
            {
                MessageBox.Show("Ingresa Familia Id", "Sin Familia Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
