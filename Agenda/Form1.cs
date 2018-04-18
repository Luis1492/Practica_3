using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        Contactos persona = new Contactos();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {


            persona.Nombre = txtNombre.Text;
            persona.Appaterno = txtApepaterno.Text;
            persona.Apmaterno = txtApmaterno.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Edad = txtEdad.Text;
            persona.Email = txtEmail.Text;
            agenda.Agregar(persona);

            if (agenda.contador < agenda.total)
            {
                MessageBox.Show("Contacto agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ah superado el limite maximo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            txtNombre.Clear();
            txtApepaterno.Clear();
            txtApmaterno.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (agenda.Buscar(persona.Telefono) == null)
            {
                txtListar.Clear();

                persona.Telefono = txtTelefono.Text;

                MessageBox.Show("Contacto encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contacto no enctrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            txtListar.Clear();
            persona.Nombre = txtNombre.Text;
            persona.Appaterno = txtApepaterno.Text;
            persona.Apmaterno = txtApmaterno.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Edad = txtEdad.Text;
            persona.Email = txtEmail.Text;
            agenda.Eliminar(persona);
            MessageBox.Show("Contacto eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            int pso = Convert.ToInt32 (txtposicion.Text);
            txtListar.Clear();
            persona.Nombre = txtNombre.Text;
            persona.Appaterno = txtApepaterno.Text;
            persona.Apmaterno = txtApmaterno.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Edad = txtEdad.Text;
            persona.Email = txtEmail.Text;
            agenda.Insertar(persona, pso);
            MessageBox.Show("Contacto insertado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            txtListar.Clear();
            txtListar.Text = agenda.Listar();
        }
    }
}
