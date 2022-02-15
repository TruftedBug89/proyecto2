using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class FormKPI : Form
    {
        private int skillId;
        public FormKPI(int skillId)
        {
            this.skillId = skillId;
            InitializeComponent();
        }

        private void FormKPI_Load(object sender, EventArgs e)
        {
            bindingSourceKPI.DataSource = Models.KpisOrm.Select(true, this.skillId);
            lblKPIName.Text = "Flexibilitat";
        }

        private void btnAddKpi_Click(object sender, EventArgs e)
        {
            Models.kpis _kpi = new Models.kpis();
            _kpi.nom = txtNewKPI.Text;
            _kpi.actiu = true;

            bindingSourceKPI.Add(_kpi);
            
        }
    }
}
