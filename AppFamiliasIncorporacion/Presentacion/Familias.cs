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
        //Declaracion de una variable para la cuestion de modificacion de un dato de la DB

        int idIncorporacion;
        public Familias()
        {
            InitializeComponent();
            //Cargando la Vista de la Familia
            vista_Familia();
        }
        /***mETODOS EN LA CAPA DE PRESENTACION***/
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
        //Metodo para Editar los Datos en la DB
        private void editar_familia()
        {
            lFamIncorporacion dtFamilia = new lFamIncorporacion();
            dFamilias metodos = new dFamilias();
            dtFamilia.idIncorporacion = idIncorporacion;
            dtFamilia.familiaId = Convert.ToInt32(gtxtFamiliaId.Text);
            dtFamilia.folioEncuesta = gtxtFolioEncuesta.Text;
            dtFamilia.tutora = gtxtNombreTutora.Text;
            dtFamilia.tutoraPaterno = gtxtApellidoPTutora.Text;
            dtFamilia.tutoraMaterno = gtxtApellidoMTutora.Text;
            dtFamilia.tutoraCurp = gtxtCurp.Text;
            dtFamilia.folioAvisoCobro = gtxtFolioAvisoCobro.Text;
            dtFamilia.obsCris = gtxtCris.Text;
            dtFamilia.obsNoti = gtxtNoti.Text;
            dtFamilia.obsAviso = gtxtAviso.Text;
            if (metodos.EditarDB(dtFamilia))
            {
                MessageBox.Show("Familia Actualizada", "Registro Correcto");
                pnlFamilia.Visible = false;
                pnlFamilia.Dock = DockStyle.None;
            }


        }


        /*** FIN DE METODOS   ***/
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

        private void gbtnActualizar_Click(object sender, EventArgs e)
        {
            editar_familia();
            vista_Familia();
        }

        private void gdtgFamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //para obtener el valor de la celda del DatagriView
            idIncorporacion = Convert.ToInt32(gdtgFamilias.SelectedCells[2].Value.ToString());
            //Validacion de la celda
            if (e.ColumnIndex == this.gdtgFamilias.Columns["Editar"].Index)
            {
                gtxtFamiliaId.Text = gdtgFamilias.SelectedCells[3].Value.ToString();
                gtxtFolioEncuesta.Text = gdtgFamilias.SelectedCells[4].Value.ToString();
                gtxtNombreTutora.Text = gdtgFamilias.SelectedCells[5].Value.ToString();
                gtxtApellidoPTutora.Text = gdtgFamilias.SelectedCells[6].Value.ToString();
                gtxtApellidoMTutora.Text = gdtgFamilias.SelectedCells[7].Value.ToString();
                gtxtCurp.Text = gdtgFamilias.SelectedCells[8].Value.ToString();
                gtxtFolioAvisoCobro.Text = gdtgFamilias.SelectedCells[9].Value.ToString();
                gtxtCris.Text = gdtgFamilias.SelectedCells[10].Value.ToString();
                gtxtNoti.Text = gdtgFamilias.SelectedCells[11].Value.ToString();
                gtxtAviso.Text = gdtgFamilias.SelectedCells[12].Value.ToString();

                pnlFamilia.Visible = true;
                pnlFamilia.Dock = DockStyle.Fill;
                gbtnGuardar.Visible = false;
                gbtnActualizar.Visible = true;
            }
        }
    }
}
