namespace JMossCPT206Lab2pt2
{
    partial class AllStatesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllStatesForm));
            this.jMossCPT206StateDB_NewDataSet = new JMossCPT206Lab2pt2.JMossCPT206StateDB_NewDataSet();
            this.usStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usStatesTableAdapter = new JMossCPT206Lab2pt2.JMossCPT206StateDB_NewDataSetTableAdapters.UsStatesTableAdapter();
            this.tableAdapterManager = new JMossCPT206Lab2pt2.JMossCPT206StateDB_NewDataSetTableAdapters.TableAdapterManager();
            this.usStatesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.usStatesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usStatesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.Label();
            this.txtFlagDesc = new System.Windows.Forms.TextBox();
            this.labelStateFlower = new System.Windows.Forms.Label();
            this.txtStateFlower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStateBird = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStateColor = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFilter = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClear = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jMossCPT206StateDB_NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingNavigator)).BeginInit();
            this.usStatesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jMossCPT206StateDB_NewDataSet
            // 
            this.jMossCPT206StateDB_NewDataSet.DataSetName = "JMossCPT206StateDB_NewDataSet";
            this.jMossCPT206StateDB_NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usStatesBindingSource
            // 
            this.usStatesBindingSource.DataMember = "UsStates";
            this.usStatesBindingSource.DataSource = this.jMossCPT206StateDB_NewDataSet;
            // 
            // usStatesTableAdapter
            // 
            this.usStatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = JMossCPT206Lab2pt2.JMossCPT206StateDB_NewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsStatesTableAdapter = this.usStatesTableAdapter;
            // 
            // usStatesBindingNavigator
            // 
            this.usStatesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usStatesBindingNavigator.BindingSource = this.usStatesBindingSource;
            this.usStatesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usStatesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usStatesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usStatesBindingNavigatorSaveItem});
            this.usStatesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usStatesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usStatesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usStatesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usStatesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usStatesBindingNavigator.Name = "usStatesBindingNavigator";
            this.usStatesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usStatesBindingNavigator.Size = new System.Drawing.Size(1201, 25);
            this.usStatesBindingNavigator.TabIndex = 0;
            this.usStatesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // usStatesBindingNavigatorSaveItem
            // 
            this.usStatesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usStatesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usStatesBindingNavigatorSaveItem.Image")));
            this.usStatesBindingNavigatorSaveItem.Name = "usStatesBindingNavigatorSaveItem";
            this.usStatesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usStatesBindingNavigatorSaveItem.Text = "Save Data";
            this.usStatesBindingNavigatorSaveItem.Click += new System.EventHandler(this.usStatesBindingNavigatorSaveItem_Click);
            // 
            // usStatesDataGridView
            // 
            this.usStatesDataGridView.AutoGenerateColumns = false;
            this.usStatesDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.usStatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usStatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.usStatesDataGridView.DataSource = this.usStatesBindingSource;
            this.usStatesDataGridView.Location = new System.Drawing.Point(0, 28);
            this.usStatesDataGridView.Name = "usStatesDataGridView";
            this.usStatesDataGridView.Size = new System.Drawing.Size(1169, 156);
            this.usStatesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StateID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StateID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StateName";
            this.dataGridViewTextBoxColumn2.HeaderText = "StateName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CurrentPopulation";
            this.dataGridViewTextBoxColumn3.HeaderText = "CurrentPopulation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FlagDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "FlagDescription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StateFlower";
            this.dataGridViewTextBoxColumn5.HeaderText = "StateFlower";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StateBird";
            this.dataGridViewTextBoxColumn6.HeaderText = "StateBird";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StateColors";
            this.dataGridViewTextBoxColumn7.HeaderText = "StateColors";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TopThreeCities";
            this.dataGridViewTextBoxColumn8.HeaderText = "TopThreeCities";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StateCapital";
            this.dataGridViewTextBoxColumn9.HeaderText = "StateCapital";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MedianIncome";
            this.dataGridViewTextBoxColumn10.HeaderText = "MedianIncome";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TechCareerPercentage";
            this.dataGridViewTextBoxColumn11.HeaderText = "TechCareerPercentage";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(12, 272);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(230, 17);
            this.c.TabIndex = 3;
            this.c.Text = "Flag Description to include Keyword:";
            // 
            // txtFlagDesc
            // 
            this.txtFlagDesc.Location = new System.Drawing.Point(66, 292);
            this.txtFlagDesc.Name = "txtFlagDesc";
            this.txtFlagDesc.Size = new System.Drawing.Size(176, 20);
            this.txtFlagDesc.TabIndex = 4;
            // 
            // labelStateFlower
            // 
            this.labelStateFlower.AutoSize = true;
            this.labelStateFlower.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStateFlower.Location = new System.Drawing.Point(300, 272);
            this.labelStateFlower.Name = "labelStateFlower";
            this.labelStateFlower.Size = new System.Drawing.Size(215, 17);
            this.labelStateFlower.TabIndex = 5;
            this.labelStateFlower.Text = "State Flower to include Keyword:";
            this.labelStateFlower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStateFlower
            // 
            this.txtStateFlower.Location = new System.Drawing.Point(339, 292);
            this.txtStateFlower.Name = "txtStateFlower";
            this.txtStateFlower.Size = new System.Drawing.Size(176, 20);
            this.txtStateFlower.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "State Bird to include Keyword:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStateBird
            // 
            this.txtStateBird.Location = new System.Drawing.Point(657, 292);
            this.txtStateBird.Name = "txtStateBird";
            this.txtStateBird.Size = new System.Drawing.Size(176, 20);
            this.txtStateBird.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(917, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "State Color to include Keyword:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStateColor
            // 
            this.txtStateColor.Location = new System.Drawing.Point(948, 292);
            this.txtStateColor.Name = "txtStateColor";
            this.txtStateColor.Size = new System.Drawing.Size(176, 20);
            this.txtStateColor.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(369, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.toolTipClear.SetToolTip(this.btnClear, "Clears Filters");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(697, 341);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(118, 35);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "&Filter";
            this.toolTipFilter.SetToolTip(this.btnFilter, "Uses text box\'s above to filter information");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(369, 402);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(118, 35);
            this.btnMainMenu.TabIndex = 13;
            this.btnMainMenu.Text = "&Main Menu";
            this.toolTipMenu.SetToolTip(this.btnMainMenu, "Returns to the Main Menu");
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(697, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.toolTipExit.SetToolTip(this.btnExit, "Closes Application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AllStatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtStateColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStateBird);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStateFlower);
            this.Controls.Add(this.labelStateFlower);
            this.Controls.Add(this.txtFlagDesc);
            this.Controls.Add(this.c);
            this.Controls.Add(this.usStatesDataGridView);
            this.Controls.Add(this.usStatesBindingNavigator);
            this.Name = "AllStatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllStatesForm";
            this.Load += new System.EventHandler(this.AllStatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jMossCPT206StateDB_NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingNavigator)).EndInit();
            this.usStatesBindingNavigator.ResumeLayout(false);
            this.usStatesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMossCPT206StateDB_NewDataSet jMossCPT206StateDB_NewDataSet;
        private System.Windows.Forms.BindingSource usStatesBindingSource;
        private JMossCPT206StateDB_NewDataSetTableAdapters.UsStatesTableAdapter usStatesTableAdapter;
        private JMossCPT206StateDB_NewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usStatesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usStatesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView usStatesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox txtFlagDesc;
        private System.Windows.Forms.Label labelStateFlower;
        private System.Windows.Forms.TextBox txtStateFlower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStateBird;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStateColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTipMenu;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipClear;
        private System.Windows.Forms.ToolTip toolTipFilter;
    }
}