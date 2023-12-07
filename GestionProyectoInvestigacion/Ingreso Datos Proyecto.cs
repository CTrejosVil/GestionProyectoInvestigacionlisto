using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectoInvestigacion
{
    public partial class Ingreso_Datos_Proyecto : Form
    {
        public Ingreso_Datos_Proyecto()
        {
            InitializeComponent();
        }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            /// <summary>
            /// Evento que permite guardar los datos de un investigador
            /// </summary>
            /// <param name="sender">Control que desencadena el evento</param>
            /// <param name="e">Datos del evento</param>
            /// <remarks></remarks>
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                try
                {
                    //TODO: 1. Recuperar los datos del formulario
                    /*
                     En este paso asignamos los valores de los controles a
                     variables locales
                     */
                    var nombre = txtNombre.Text;
                    dynamic grupoInvestigacion = txtGrupoInvestigacion.Text;
                    var lineaInvestigacion = cboLineaInvestigacion.Text;
                    var enteFinanciero = cboEnteFinanciero.Text;
                    String convocatoria = txtConvocatoria.Text;
                    String entidadesCooperantes = txtEntidadesCooperantes.Text;
                    String duracion = txtDuracion.Text;
                    String actividades = txtActividades.Text;
                    String objetivos = txtObjetivos.Text;
                    String comentarios = txtComentarios.Text;
                    var requiereAjuste = cboRequiereAjuste.Text;
                    String ajustes= txtAjustes.Text;


                //TODO: 2. Validar los datos del formulario
                if (ValidarIngreso())
                    {
                        //TODO: 3. Guardar los datos del formulario en un repositorio

                        //TODO: 4. Mostrar mensaje de confirmación/negación de la operación

                        var datos = @"Nombre: " + nombre + "\n" + "Grupo de Investigación: " + grupoInvestigacion + "\n" + "Linea de investigación: " + lineaInvestigacion + "\n" + "Ente financiero: " + enteFinanciero + "\n" + "Convocatoria: " + convocatoria + "\n" + "Entidades Cooperantes: " + entidadesCooperantes + "\n" + "Duración: " + duracion + "\n" + "Actividades: " + actividades + "\n" + "Objetivos: " + objetivos + "\n" + "Comentarios: " + comentarios + "\n" + "Requiere Ajuste: " + requiereAjuste + "\n" + "Ajustes: " + ajustes + "\n";
                        MessageBox.Show(datos, "Datos Ingreso Convocatoria",
                            MessageBoxButtons.OK);
                    }

                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Por ahora el sistema tiene dificultades. Volveremos pronto.  " +
                        "El error presentado es: " + ex.Message,
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }

            /// <summary>
            ///
            /// </summary>
            /// <returns></returns>
            private bool ValidarIngreso()
            {
            var nombre = txtNombre.Text;
            dynamic grupoInvestigacion = txtGrupoInvestigacion.Text;
            var lineaInvestigacion = cboLineaInvestigacion.Text;
            var enteFinanciero = cboEnteFinanciero.Text;
            String convocatoria = txtConvocatoria.Text;
            String entidadesCooperantes = txtEntidadesCooperantes.Text;
            String duracion = txtDuracion.Text;
            String actividades = txtActividades.Text;
            String objetivos = txtObjetivos.Text;
            String comentarios = txtComentarios.Text;
            var requiereAjuste = cboRequiereAjuste.Text;
            String ajustes = txtAjustes.Text;

            if (nombre.Trim() == "")
                {
                    MessageBox.Show("El nombre no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(grupoInvestigacion.Trim()))
                {
                    MessageBox.Show("El grupo de investigación no debe estar vacío",
                       this.Text,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(lineaInvestigacion))
                {
                    MessageBox.Show("Seleccione la linea de investigación ",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(enteFinanciero))
                {
                    MessageBox.Show("Seleccione el ente financiero",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(convocatoria))
                {
                    MessageBox.Show("La convocatoria no debe estar vacía",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(entidadesCooperantes))
                {
                    MessageBox.Show("Las entidades cooperantes no deben estar vacías",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }
            if (string.IsNullOrEmpty(duracion))
            {
                MessageBox.Show("La duración no debe estar vacía",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(actividades))
            {
                MessageBox.Show("Las actividades no deben estar vacías",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(objetivos))
            {
                MessageBox.Show("Los objetivos no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(comentarios))
            {
                MessageBox.Show("Los comentarios no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(requiereAjuste))
            {
                MessageBox.Show("Seleccione si requiere ajuste",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(ajustes))
            {
                MessageBox.Show("Los ajustes no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            return true;


            }
            private void tbcDatosComplementarios_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblComenatrios_Click(object sender, EventArgs e)
        {

        }
    }
}
