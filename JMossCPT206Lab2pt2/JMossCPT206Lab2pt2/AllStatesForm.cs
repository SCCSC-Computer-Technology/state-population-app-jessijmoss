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
    public partial class AllStatesForm : Form
    {
        public AllStatesForm()
        {
            InitializeComponent();
        }

        private void usStatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usStatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jMossCPT206StateDB_NewDataSet);

        }

        private void AllStatesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jMossCPT206StateDB_NewDataSet.UsStates' table. You can move, or remove it, as needed.
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the boxes so they can try again
            ClearFilterBoxes();

            //clear previous filters
            this.usStatesBindingSource.RemoveFilter();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // list to store user filter options
            List<string> activeFilters = new List<string>();

            // only applies filter if txt box not empty
            if (!string.IsNullOrWhiteSpace(txtFlagDesc.Text))
                activeFilters.Add("FlagDescription LIKE '%" + txtFlagDesc.Text.Trim() + "%'");

            if (!string.IsNullOrWhiteSpace(txtStateBird.Text))
                activeFilters.Add("StateBird LIKE '%" + txtStateBird.Text.Trim() + "%'");

            if (!string.IsNullOrWhiteSpace(txtStateColor.Text))
                activeFilters.Add("StateColors LIKE '%" + txtStateColor.Text.Trim() + "%'");

            if (!string.IsNullOrWhiteSpace(txtStateFlower.Text))
                activeFilters.Add("StateFlower LIKE '%" + txtStateFlower.Text.Trim() + "%'");

            // applies filter
            this.usStatesBindingSource.Filter = string.Join(" AND ", activeFilters);

            // Validating if the the user filter options found matching options
            if (this.usStatesBindingSource.Count == 0 && activeFilters.Count > 0)
            {
                MessageBox.Show("No results found with the criteria. Please try different keywords.");
                this.usStatesBindingSource.RemoveFilter();

                //Clear the boxes so they can try again
                ClearFilterBoxes();
            }
        }
        // method to clear txtbox
        private void ClearFilterBoxes()
        {
            txtFlagDesc.Clear();
            txtStateBird.Clear();
            txtStateColor.Clear();
            txtStateFlower.Clear();
        }
    }
}
