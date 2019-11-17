using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace FrmListado
{
  public partial class Form1 : Form
  {
    private List<Persona> _personas;
    private DataTable _tabla;
    private AccesoDatoss accesoDatos = new AccesoDatoss();
    public Form1()
    {
      InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this._personas = accesoDatos.TraerTodos();
      this._tabla = accesoDatos.TraerTablaPersonas();
      this.dataGridView1.SelectionMode = new DataGridViewSelectionMode();
      this.dataGridView1.DataSource = this._tabla;
      //foreach (Persona item in this._personas)
      //{
      //  this.dataGridView1.DataSource = item;
      //}
    }
  }
}
