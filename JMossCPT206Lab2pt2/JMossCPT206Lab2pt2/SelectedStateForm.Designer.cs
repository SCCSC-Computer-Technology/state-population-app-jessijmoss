namespace JMossCPT206Lab2pt2
{
    partial class SelectedStateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedStateForm));
            System.Windows.Forms.Label stateIDLabel;
            System.Windows.Forms.Label stateNameLabel;
            System.Windows.Forms.Label currentPopulationLabel;
            System.Windows.Forms.Label flagDescriptionLabel;
            System.Windows.Forms.Label stateFlowerLabel;
            System.Windows.Forms.Label stateBirdLabel;
            System.Windows.Forms.Label stateColorsLabel;
            System.Windows.Forms.Label topThreeCitiesLabel;
            System.Windows.Forms.Label stateCapitalLabel;
            System.Windows.Forms.Label medianIncomeLabel;
            System.Windows.Forms.Label techCareerPercentageLabel;
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
            this.stateIDTextBox = new System.Windows.Forms.TextBox();
            this.stateNameTextBox = new System.Windows.Forms.TextBox();
            this.currentPopulationTextBox = new System.Windows.Forms.TextBox();
            this.flagDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.stateFlowerTextBox = new System.Windows.Forms.TextBox();
            this.stateBirdTextBox = new System.Windows.Forms.TextBox();
            this.stateColorsTextBox = new System.Windows.Forms.TextBox();
            this.topThreeCitiesTextBox = new System.Windows.Forms.TextBox();
            this.stateCapitalTextBox = new System.Windows.Forms.TextBox();
            this.medianIncomeTextBox = new System.Windows.Forms.TextBox();
            this.techCareerPercentageTextBox = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            stateIDLabel = new System.Windows.Forms.Label();
            stateNameLabel = new System.Windows.Forms.Label();
            currentPopulationLabel = new System.Windows.Forms.Label();
            flagDescriptionLabel = new System.Windows.Forms.Label();
            stateFlowerLabel = new System.Windows.Forms.Label();
            stateBirdLabel = new System.Windows.Forms.Label();
            stateColorsLabel = new System.Windows.Forms.Label();
            topThreeCitiesLabel = new System.Windows.Forms.Label();
            stateCapitalLabel = new System.Windows.Forms.Label();
            medianIncomeLabel = new System.Windows.Forms.Label();
            techCareerPercentageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jMossCPT206StateDB_NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingNavigator)).BeginInit();
            this.usStatesBindingNavigator.SuspendLayout();
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
            this.usStatesBindingNavigator.Size = new System.Drawing.Size(892, 25);
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
            // stateIDLabel
            // 
            stateIDLabel.AutoSize = true;
            stateIDLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateIDLabel.Location = new System.Drawing.Point(12, 37);
            stateIDLabel.Name = "stateIDLabel";
            stateIDLabel.Size = new System.Drawing.Size(75, 17);
            stateIDLabel.TabIndex = 1;
            stateIDLabel.Text = "State ID:";
            stateIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateIDTextBox
            // 
            this.stateIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "StateID", true));
            this.stateIDTextBox.Location = new System.Drawing.Point(205, 34);
            this.stateIDTextBox.Name = "stateIDTextBox";
            this.stateIDTextBox.Size = new System.Drawing.Size(628, 20);
            this.stateIDTextBox.TabIndex = 2;
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateNameLabel.Location = new System.Drawing.Point(12, 63);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(97, 17);
            stateNameLabel.TabIndex = 3;
            stateNameLabel.Text = "State Name:";
            stateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateNameTextBox
            // 
            this.stateNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "StateName", true));
            this.stateNameTextBox.Location = new System.Drawing.Point(205, 60);
            this.stateNameTextBox.Name = "stateNameTextBox";
            this.stateNameTextBox.Size = new System.Drawing.Size(628, 20);
            this.stateNameTextBox.TabIndex = 4;
            // 
            // currentPopulationLabel
            // 
            currentPopulationLabel.AutoSize = true;
            currentPopulationLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentPopulationLabel.Location = new System.Drawing.Point(12, 89);
            currentPopulationLabel.Name = "currentPopulationLabel";
            currentPopulationLabel.Size = new System.Drawing.Size(148, 17);
            currentPopulationLabel.TabIndex = 5;
            currentPopulationLabel.Text = "Current Population:";
            currentPopulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPopulationTextBox
            // 
            this.currentPopulationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "CurrentPopulation", true));
            this.currentPopulationTextBox.Location = new System.Drawing.Point(205, 86);
            this.currentPopulationTextBox.Name = "currentPopulationTextBox";
            this.currentPopulationTextBox.Size = new System.Drawing.Size(628, 20);
            this.currentPopulationTextBox.TabIndex = 6;
            // 
            // flagDescriptionLabel
            // 
            flagDescriptionLabel.AutoSize = true;
            flagDescriptionLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            flagDescriptionLabel.Location = new System.Drawing.Point(12, 115);
            flagDescriptionLabel.Name = "flagDescriptionLabel";
            flagDescriptionLabel.Size = new System.Drawing.Size(124, 17);
            flagDescriptionLabel.TabIndex = 7;
            flagDescriptionLabel.Text = "Flag Description:";
            flagDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flagDescriptionTextBox
            // 
            this.flagDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "FlagDescription", true));
            this.flagDescriptionTextBox.Location = new System.Drawing.Point(205, 112);
            this.flagDescriptionTextBox.Name = "flagDescriptionTextBox";
            this.flagDescriptionTextBox.Size = new System.Drawing.Size(628, 20);
            this.flagDescriptionTextBox.TabIndex = 8;
            // 
            // stateFlowerLabel
            // 
            stateFlowerLabel.AutoSize = true;
            stateFlowerLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateFlowerLabel.Location = new System.Drawing.Point(12, 141);
            stateFlowerLabel.Name = "stateFlowerLabel";
            stateFlowerLabel.Size = new System.Drawing.Size(105, 17);
            stateFlowerLabel.TabIndex = 9;
            stateFlowerLabel.Text = "State Flower:";
            stateFlowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateFlowerTextBox
            // 
            this.stateFlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "StateFlower", true));
            this.stateFlowerTextBox.Location = new System.Drawing.Point(205, 138);
            this.stateFlowerTextBox.Name = "stateFlowerTextBox";
            this.stateFlowerTextBox.Size = new System.Drawing.Size(628, 20);
            this.stateFlowerTextBox.TabIndex = 10;
            // 
            // stateBirdLabel
            // 
            stateBirdLabel.AutoSize = true;
            stateBirdLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateBirdLabel.Location = new System.Drawing.Point(12, 167);
            stateBirdLabel.Name = "stateBirdLabel";
            stateBirdLabel.Size = new System.Drawing.Size(88, 17);
            stateBirdLabel.TabIndex = 11;
            stateBirdLabel.Text = "State Bird:";
            stateBirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateBirdTextBox
            // 
            this.stateBirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "StateBird", true));
            this.stateBirdTextBox.Location = new System.Drawing.Point(205, 164);
            this.stateBirdTextBox.Name = "stateBirdTextBox";
            this.stateBirdTextBox.Size = new System.Drawing.Size(628, 20);
            this.stateBirdTextBox.TabIndex = 12;
            // 
            // stateColorsLabel
            // 
            stateColorsLabel.AutoSize = true;
            stateColorsLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateColorsLabel.Location = new System.Drawing.Point(12, 193);
            stateColorsLabel.Name = "stateColorsLabel";
            stateColorsLabel.Size = new System.Drawing.Size(102, 17);
            stateColorsLabel.TabIndex = 13;
            stateColorsLabel.Text = "State Colors:";
            stateColorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateColorsTextBox
            // 
            this.stateColorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "StateColors", true));
            this.stateColorsTextBox.Location = new System.Drawing.Point(205, 190);
            this.stateColorsTextBox.Name = "stateColorsTextBox";
            this.stateColorsTextBox.Size = new System.Drawing.Size(628, 20);
            this.stateColorsTextBox.TabIndex = 14;
            // 
            // topThreeCitiesLabel
            // 
            topThreeCitiesLabel.AutoSize = true;
            topThreeCitiesLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            topThreeCitiesLabel.Location = new System.Drawing.Point(12, 219);
            topThreeCitiesLabel.Name = "topThreeCitiesLabel";
            topThreeCitiesLabel.Size = new System.Drawing.Size(129, 17);
            topThreeCitiesLabel.TabIndex = 15;
            topThreeCitiesLabel.Text = "Top Three Cities:";
            topThreeCitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topThreeCitiesTextBox
            // 
            this.topThreeCitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "TopThreeCities", true));
            this.topThreeCitiesTextBox.Location = new System.Drawing.Point(205, 216);
            this.topThreeCitiesTextBox.Name = "topThreeCitiesTextBox";
            this.topThreeCitiesTextBox.Size = new System.Drawing.Size(628, 20);
            this.topThreeCitiesTextBox.TabIndex = 16;
            // 
            // stateCapitalLabel
            // 
            stateCapitalLabel.AutoSize = true;
            stateCapitalLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateCapitalLabel.Location = new System.Drawing.Point(12, 245);
            stateCapitalLabel.Name = "stateCapitalLabel";
            stateCapitalLabel.Size = new System.Drawing.Size(107, 17);
            stateCapitalLabel.TabIndex = 17;
            stateCapitalLabel.Text = "State Capital:";
            stateCapitalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateCapitalTextBox
            // 
            this.stateCapitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "StateCapital", true));
            this.stateCapitalTextBox.Location = new System.Drawing.Point(205, 242);
            this.stateCapitalTextBox.Name = "stateCapitalTextBox";
            this.stateCapitalTextBox.Size = new System.Drawing.Size(628, 20);
            this.stateCapitalTextBox.TabIndex = 18;
            // 
            // medianIncomeLabel
            // 
            medianIncomeLabel.AutoSize = true;
            medianIncomeLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medianIncomeLabel.Location = new System.Drawing.Point(12, 271);
            medianIncomeLabel.Name = "medianIncomeLabel";
            medianIncomeLabel.Size = new System.Drawing.Size(115, 17);
            medianIncomeLabel.TabIndex = 19;
            medianIncomeLabel.Text = "Median Income:";
            medianIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medianIncomeTextBox
            // 
            this.medianIncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "MedianIncome", true));
            this.medianIncomeTextBox.Location = new System.Drawing.Point(205, 268);
            this.medianIncomeTextBox.Name = "medianIncomeTextBox";
            this.medianIncomeTextBox.Size = new System.Drawing.Size(628, 20);
            this.medianIncomeTextBox.TabIndex = 20;
            // 
            // techCareerPercentageLabel
            // 
            techCareerPercentageLabel.AutoSize = true;
            techCareerPercentageLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            techCareerPercentageLabel.Location = new System.Drawing.Point(12, 297);
            techCareerPercentageLabel.Name = "techCareerPercentageLabel";
            techCareerPercentageLabel.Size = new System.Drawing.Size(178, 17);
            techCareerPercentageLabel.TabIndex = 21;
            techCareerPercentageLabel.Text = "Tech Career Percentage:";
            techCareerPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // techCareerPercentageTextBox
            // 
            this.techCareerPercentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usStatesBindingSource, "TechCareerPercentage", true));
            this.techCareerPercentageTextBox.Location = new System.Drawing.Point(205, 294);
            this.techCareerPercentageTextBox.Name = "techCareerPercentageTextBox";
            this.techCareerPercentageTextBox.Size = new System.Drawing.Size(628, 20);
            this.techCareerPercentageTextBox.TabIndex = 22;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(343, 350);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(110, 38);
            this.btnMainMenu.TabIndex = 24;
            this.btnMainMenu.Text = "&Main Menu";
            this.toolTipMenu.SetToolTip(this.btnMainMenu, "Returns to the Main Menu");
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(559, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "E&xit";
            this.toolTipExit.SetToolTip(this.btnExit, "Closes Application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SelectedStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(stateIDLabel);
            this.Controls.Add(this.stateIDTextBox);
            this.Controls.Add(stateNameLabel);
            this.Controls.Add(this.stateNameTextBox);
            this.Controls.Add(currentPopulationLabel);
            this.Controls.Add(this.currentPopulationTextBox);
            this.Controls.Add(flagDescriptionLabel);
            this.Controls.Add(this.flagDescriptionTextBox);
            this.Controls.Add(stateFlowerLabel);
            this.Controls.Add(this.stateFlowerTextBox);
            this.Controls.Add(stateBirdLabel);
            this.Controls.Add(this.stateBirdTextBox);
            this.Controls.Add(stateColorsLabel);
            this.Controls.Add(this.stateColorsTextBox);
            this.Controls.Add(topThreeCitiesLabel);
            this.Controls.Add(this.topThreeCitiesTextBox);
            this.Controls.Add(stateCapitalLabel);
            this.Controls.Add(this.stateCapitalTextBox);
            this.Controls.Add(medianIncomeLabel);
            this.Controls.Add(this.medianIncomeTextBox);
            this.Controls.Add(techCareerPercentageLabel);
            this.Controls.Add(this.techCareerPercentageTextBox);
            this.Controls.Add(this.usStatesBindingNavigator);
            this.Name = "SelectedStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectedStateForm";
            this.Load += new System.EventHandler(this.SelectedStateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jMossCPT206StateDB_NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingNavigator)).EndInit();
            this.usStatesBindingNavigator.ResumeLayout(false);
            this.usStatesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox stateIDTextBox;
        private System.Windows.Forms.TextBox stateNameTextBox;
        private System.Windows.Forms.TextBox currentPopulationTextBox;
        private System.Windows.Forms.TextBox flagDescriptionTextBox;
        private System.Windows.Forms.TextBox stateFlowerTextBox;
        private System.Windows.Forms.TextBox stateBirdTextBox;
        private System.Windows.Forms.TextBox stateColorsTextBox;
        private System.Windows.Forms.TextBox topThreeCitiesTextBox;
        private System.Windows.Forms.TextBox stateCapitalTextBox;
        private System.Windows.Forms.TextBox medianIncomeTextBox;
        private System.Windows.Forms.TextBox techCareerPercentageTextBox;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTipMenu;
        private System.Windows.Forms.ToolTip toolTipExit;
    }
}