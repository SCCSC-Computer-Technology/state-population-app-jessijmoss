namespace JMossCPT206Lab2pt2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnter = new System.Windows.Forms.Button();
            this.cmbStates = new System.Windows.Forms.ComboBox();
            this.lblDirections = new System.Windows.Forms.Label();
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
            this.btnExitMain = new System.Windows.Forms.Button();
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnter = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jMossCPT206StateDB_NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingNavigator)).BeginInit();
            this.usStatesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(334, 295);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(97, 39);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "&Enter";
            this.toolTipEnter.SetToolTip(this.btnEnter, "Shows Selected States Information");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cmbStates
            // 
            this.cmbStates.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStates.FormattingEnabled = true;
            this.cmbStates.Location = new System.Drawing.Point(265, 211);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(256, 29);
            this.cmbStates.TabIndex = 3;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.BackColor = System.Drawing.Color.White;
            this.lblDirections.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(178, 113);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(457, 56);
            this.lblDirections.TabIndex = 4;
            this.lblDirections.Text = "Please select a State from the \r\ndrop down menu below to view its Stats";
            this.lblDirections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.usStatesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.usStatesBindingNavigator.TabIndex = 5;
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
            // btnExitMain
            // 
            this.btnExitMain.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMain.Location = new System.Drawing.Point(334, 349);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(97, 40);
            this.btnExitMain.TabIndex = 6;
            this.btnExitMain.Text = "E&xit";
            this.toolTipExit.SetToolTip(this.btnExitMain, "Closes Application");
            this.btnExitMain.UseVisualStyleBackColor = false;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.usStatesBindingNavigator);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.cmbStates);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jMossCPT206StateDB_NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usStatesBindingNavigator)).EndInit();
            this.usStatesBindingNavigator.ResumeLayout(false);
            this.usStatesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cmbStates;
        private System.Windows.Forms.Label lblDirections;
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
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipEnter;
    }
}

