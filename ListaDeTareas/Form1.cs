using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace ListaDeTareas
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();

            filtrocmb.SelectedIndex = 0;
        }

        Tarea tarea = new Tarea();

        List<Tarea> tareas = new List<Tarea>();

        int indice;

        private void AgregarTareabtn_Click(object sender, EventArgs e)
        {
            if (Agregartareatxt.Text != "" && datatime1.Value >= DateTime.Now)
            {
                tarea.descripcion = Agregartareatxt.Text;
                tarea.fecha = datatime1.Value;
                tarea.check = false;
                tareas.Add(tarea);
                Listadetareaslst.Items.Add(tarea.descripcion + " | Fecha límite: " + tarea.fecha);
                Agregartareatxt.Text = "";
            }

            else MessageBox.Show("Agregar tarea o verificar fecha");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                indice = Listadetareaslst.SelectedIndex;
                Listadetareaslst.Items.RemoveAt(indice);
                tareas.RemoveAt(indice);
            }

            catch
            {
                MessageBox.Show("Seleccione una tarea");
            }
        }

        private void Listadetareaslst_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void filtrocmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
