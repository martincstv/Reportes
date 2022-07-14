using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Form_Reporte : Form
    {
        public Form_Reporte()
        {
            InitializeComponent();
        }

        private void Form_Reporte_Load(object sender, EventArgs e)
        {
            CargarValoresIniciales();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void CargarValoresIniciales()
        {
            CargarComboState();
            CargarComboType();
        }

        private void CargarComboType()
        {
            comboBox_Type.DataSource = TitlesNegocio.ListaTitles();
            comboBox_Type.DisplayMember = "type";
        }

        private void CargarComboState()
        {
            comboBox_State.DataSource = AuthorsNegocio.ListaStates();
            comboBox_State.DisplayMember = "state";
        }
    }
}
