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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this loads data into form
            this.usStatesTableAdapter.Fill(this.jMossCPT206StateDB_NewDataSet.UsStates);


            // clear combo box and add all states option 
            cmbStates.Items.Clear();
            cmbStates.Items.Add("All States");

            // each state name from database to the dropdown
            foreach (var row in this.jMossCPT206StateDB_NewDataSet.UsStates)
            {
                cmbStates.Items.Add(row.StateName);
            }

            // Default to All States if user doesn't pick one
            cmbStates.SelectedIndex = 0;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = cmbStates.SelectedItem.ToString();

                if (selected == "All States")
                {
                    AllStatesForm allForm = new AllStatesForm();
                    allForm.Show();
                }
                else
                {
                    //instance of selected state form
                    SelectedStateForm detailForm = new SelectedStateForm();
                    //pass the selected state to the new form
                    detailForm.SelectedStateName = selected;
                    //show the form
                    detailForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void usStatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usStatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jMossCPT206StateDB_NewDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jMossCPT206StateDB_NewDataSet.UsStates' table. You can move, or remove it, as needed.
            this.usStatesTableAdapter.Fill(this.jMossCPT206StateDB_NewDataSet.UsStates);

        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
