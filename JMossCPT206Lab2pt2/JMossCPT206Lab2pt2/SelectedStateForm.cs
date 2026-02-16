using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMossCPT206Lab2pt2
{
    public partial class SelectedStateForm : Form
    {
        // property to hold the selected state name passed from the main form
        public string SelectedStateName { get; set; }
        public SelectedStateForm()
        {
            InitializeComponent();
        }

        private void usStatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usStatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jMossCPT206StateDB_NewDataSet);

        }

        private void SelectedStateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jMossCPT206StateDB_NewDataSet.UsStates' table. You can move, or remove it, as needed.
            this.usStatesTableAdapter.Fill(this.jMossCPT206StateDB_NewDataSet.UsStates);
            //filter data have to add the space to prevent missing operand
            this.usStatesBindingSource.Filter = "StateName = '" + SelectedStateName + "'";
            //load date
            this.usStatesTableAdapter.Fill(this.jMossCPT206StateDB_NewDataSet.UsStates);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
