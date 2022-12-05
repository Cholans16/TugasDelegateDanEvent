using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCalculator
{
    public partial class form_induk : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public form_induk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmEntry_OnCreate(Calculator cal)
        {
            listOfCalculator.Clear();
            listOfCalculator.Add(cal);
            IstHasil.Items.Add(cal.Hasil);
            
        }

        private void IstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            
            FormEntryData frmEntry = new FormEntryData();
            frmEntry.onCreate += FrmEntry_OnCreate;
            frmEntry.ShowDialog();
        }

        
    }
}
