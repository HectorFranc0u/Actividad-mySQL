using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Actividad_mySQL
{
    public partial class frmrecetas : Form
    {
        string actions = "";
        public frmrecetas()
        {
            InitializeComponent();
        }

        private void frmrecetas_Load(object sender, EventArgs e)
        {
            filldgv();
        }
        
        public void filldgv()
        {
            Recetas recetas = new Recetas();

            cleardgv();

            dgv.Columns.Add("_ID", "ID de recerta");
            dgv.Columns.Add("_nombre", "NOMBRE");
            dgv.Columns.Add("_tipo", "TIPO");
            dgv.Columns.Add("_ingredientes", "INGREDIENTES");
            dgv.Columns.Add("_autor", "AUTOR");

            MySqlDataReader dataReader = recetas.getallrecipies();

            while (dataReader.Read())
            {
                dgv.Rows.Add(
                    dataReader.GetValue(0),
                    dataReader.GetValue(1),
                    dataReader.GetValue(2),
                    dataReader.GetValue(3),
                    dataReader.GetValue(4)
                    );
            }

        }

        public void cleardgv()
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
        }

        public void clearcontrols()
        {
            txbname.Text = "";
            txbtipo.Text = "";
            txbingredientes.Text = "";
            txbautor.Text = "";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Recetas recetas = new Recetas();

            if (rdbnuevo.Checked == true)
            {
                actions = "new";
            }
            else if (rdbactualizar.Checked == true)
            {
                actions = "edit";
                recetas._ID = Convert.ToInt32(txbid.Text);
            }
            recetas._nombre = txbname.Text;
            recetas._tipo = txbtipo.Text;
            recetas._ingredientes = txbingredientes.Text;
            recetas._autor = txbautor.Text;

            string mensaje = "esta seguro de que quiere continuar?";
            
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (recetas.newEditrecipe(actions))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Se ha guardado correctamente", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos no se han podido guardar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            cleardgv();
            filldgv();
            clearcontrols();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            txbid.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txbname.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txbtipo.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txbingredientes.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txbautor.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            rdbactualizar.Checked = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Recetas recetas = new Recetas();
                recetas._ID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteBook() de la clase Book
                if (recetas.deleterecipe())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    filldgv();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
