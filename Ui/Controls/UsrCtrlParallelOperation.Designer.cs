namespace Ui.Controls
{
    partial class UsrCtrlParallelOperation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCenterMain = new System.Windows.Forms.Panel();
            this.pnlLeftMain = new System.Windows.Forms.Panel();
            this.dgvFemale = new System.Windows.Forms.DataGridView();
            this.pnlTopMostCommon = new System.Windows.Forms.Panel();
            this.btnLoadFemale = new System.Windows.Forms.Button();
            this.lblAllFemaleRecords = new System.Windows.Forms.Label();
            this.dgvAllRecords = new System.Windows.Forms.DataGridView();
            this.pnlTopAllRecords = new System.Windows.Forms.Panel();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.lblAllRecords = new System.Windows.Forms.Label();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.dgvMostCommon = new System.Windows.Forms.DataGridView();
            this.pnlTopFemale = new System.Windows.Forms.Panel();
            this.btnLoadCommon = new System.Windows.Forms.Button();
            this.lblCommonRecords = new System.Windows.Forms.Label();
            this.dgvMale = new System.Windows.Forms.DataGridView();
            this.pnlTopMale = new System.Windows.Forms.Panel();
            this.btnLoadMale = new System.Windows.Forms.Button();
            this.lblAllMaleRecords = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbOperationResult = new System.Windows.Forms.ListBox();
            this.pnlListTop = new System.Windows.Forms.Panel();
            this.numericValue = new System.Windows.Forms.NumericUpDown();
            this.cbExecutionType = new System.Windows.Forms.ComboBox();
            this.btnExecuteProcess = new System.Windows.Forms.Button();
            this.lblOperationTime = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlLeftMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemale)).BeginInit();
            this.pnlTopMostCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).BeginInit();
            this.pnlTopAllRecords.SuspendLayout();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostCommon)).BeginInit();
            this.pnlTopFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMale)).BeginInit();
            this.pnlTopMale.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlListTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlCenterMain);
            this.pnlMain.Controls.Add(this.pnlLeftMain);
            this.pnlMain.Controls.Add(this.pnlRightMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(732, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1109, 686);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterMain.Location = new System.Drawing.Point(579, 0);
            this.pnlCenterMain.Name = "pnlCenterMain";
            this.pnlCenterMain.Size = new System.Drawing.Size(8, 686);
            this.pnlCenterMain.TabIndex = 5;
            // 
            // pnlLeftMain
            // 
            this.pnlLeftMain.Controls.Add(this.dgvFemale);
            this.pnlLeftMain.Controls.Add(this.pnlTopMostCommon);
            this.pnlLeftMain.Controls.Add(this.dgvAllRecords);
            this.pnlLeftMain.Controls.Add(this.pnlTopAllRecords);
            this.pnlLeftMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMain.Name = "pnlLeftMain";
            this.pnlLeftMain.Size = new System.Drawing.Size(579, 686);
            this.pnlLeftMain.TabIndex = 3;
            // 
            // dgvFemale
            // 
            this.dgvFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFemale.Location = new System.Drawing.Point(0, 372);
            this.dgvFemale.MultiSelect = false;
            this.dgvFemale.Name = "dgvFemale";
            this.dgvFemale.RowHeadersVisible = false;
            this.dgvFemale.RowHeadersWidth = 51;
            this.dgvFemale.RowTemplate.Height = 25;
            this.dgvFemale.Size = new System.Drawing.Size(579, 314);
            this.dgvFemale.TabIndex = 6;
            // 
            // pnlTopMostCommon
            // 
            this.pnlTopMostCommon.Controls.Add(this.btnLoadFemale);
            this.pnlTopMostCommon.Controls.Add(this.lblAllFemaleRecords);
            this.pnlTopMostCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMostCommon.Location = new System.Drawing.Point(0, 322);
            this.pnlTopMostCommon.Name = "pnlTopMostCommon";
            this.pnlTopMostCommon.Size = new System.Drawing.Size(579, 50);
            this.pnlTopMostCommon.TabIndex = 3;
            // 
            // btnLoadFemale
            // 
            this.btnLoadFemale.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadFemale.Location = new System.Drawing.Point(486, 5);
            this.btnLoadFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadFemale.Name = "btnLoadFemale";
            this.btnLoadFemale.Size = new System.Drawing.Size(88, 39);
            this.btnLoadFemale.TabIndex = 2;
            this.btnLoadFemale.Text = "Load";
            this.btnLoadFemale.UseVisualStyleBackColor = true;
            this.btnLoadFemale.Click += new System.EventHandler(this.btnLoadFemale_Click);
            // 
            // lblAllFemaleRecords
            // 
            this.lblAllFemaleRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllFemaleRecords.Location = new System.Drawing.Point(5, 7);
            this.lblAllFemaleRecords.Name = "lblAllFemaleRecords";
            this.lblAllFemaleRecords.Size = new System.Drawing.Size(475, 37);
            this.lblAllFemaleRecords.TabIndex = 1;
            this.lblAllFemaleRecords.Text = "All Female Records";
            this.lblAllFemaleRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAllRecords
            // 
            this.dgvAllRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllRecords.Location = new System.Drawing.Point(0, 50);
            this.dgvAllRecords.MultiSelect = false;
            this.dgvAllRecords.Name = "dgvAllRecords";
            this.dgvAllRecords.RowHeadersVisible = false;
            this.dgvAllRecords.RowHeadersWidth = 51;
            this.dgvAllRecords.RowTemplate.Height = 25;
            this.dgvAllRecords.ShowEditingIcon = false;
            this.dgvAllRecords.Size = new System.Drawing.Size(579, 272);
            this.dgvAllRecords.TabIndex = 2;
            // 
            // pnlTopAllRecords
            // 
            this.pnlTopAllRecords.Controls.Add(this.btnLoadAll);
            this.pnlTopAllRecords.Controls.Add(this.lblAllRecords);
            this.pnlTopAllRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopAllRecords.Location = new System.Drawing.Point(0, 0);
            this.pnlTopAllRecords.Name = "pnlTopAllRecords";
            this.pnlTopAllRecords.Size = new System.Drawing.Size(579, 50);
            this.pnlTopAllRecords.TabIndex = 0;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadAll.Location = new System.Drawing.Point(486, 5);
            this.btnLoadAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(88, 39);
            this.btnLoadAll.TabIndex = 1;
            this.btnLoadAll.Text = "Load";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // lblAllRecords
            // 
            this.lblAllRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllRecords.Location = new System.Drawing.Point(5, 7);
            this.lblAllRecords.Name = "lblAllRecords";
            this.lblAllRecords.Size = new System.Drawing.Size(475, 37);
            this.lblAllRecords.TabIndex = 0;
            this.lblAllRecords.Text = "All Records";
            this.lblAllRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRightMain
            // 
            this.pnlRightMain.Controls.Add(this.dgvMostCommon);
            this.pnlRightMain.Controls.Add(this.pnlTopFemale);
            this.pnlRightMain.Controls.Add(this.dgvMale);
            this.pnlRightMain.Controls.Add(this.pnlTopMale);
            this.pnlRightMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightMain.Location = new System.Drawing.Point(587, 0);
            this.pnlRightMain.Name = "pnlRightMain";
            this.pnlRightMain.Size = new System.Drawing.Size(522, 686);
            this.pnlRightMain.TabIndex = 4;
            // 
            // dgvMostCommon
            // 
            this.dgvMostCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostCommon.Location = new System.Drawing.Point(0, 372);
            this.dgvMostCommon.MultiSelect = false;
            this.dgvMostCommon.Name = "dgvMostCommon";
            this.dgvMostCommon.RowHeadersVisible = false;
            this.dgvMostCommon.RowHeadersWidth = 51;
            this.dgvMostCommon.RowTemplate.Height = 25;
            this.dgvMostCommon.Size = new System.Drawing.Size(522, 314);
            this.dgvMostCommon.TabIndex = 5;
            // 
            // pnlTopFemale
            // 
            this.pnlTopFemale.Controls.Add(this.btnLoadCommon);
            this.pnlTopFemale.Controls.Add(this.lblCommonRecords);
            this.pnlTopFemale.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFemale.Location = new System.Drawing.Point(0, 322);
            this.pnlTopFemale.Name = "pnlTopFemale";
            this.pnlTopFemale.Size = new System.Drawing.Size(522, 50);
            this.pnlTopFemale.TabIndex = 5;
            // 
            // btnLoadCommon
            // 
            this.btnLoadCommon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCommon.Location = new System.Drawing.Point(431, 5);
            this.btnLoadCommon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadCommon.Name = "btnLoadCommon";
            this.btnLoadCommon.Size = new System.Drawing.Size(88, 39);
            this.btnLoadCommon.TabIndex = 3;
            this.btnLoadCommon.Text = "Load";
            this.btnLoadCommon.UseVisualStyleBackColor = true;
            this.btnLoadCommon.Click += new System.EventHandler(this.btnLoadCommon_Click);
            // 
            // lblCommonRecords
            // 
            this.lblCommonRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCommonRecords.Location = new System.Drawing.Point(5, 7);
            this.lblCommonRecords.Name = "lblCommonRecords";
            this.lblCommonRecords.Size = new System.Drawing.Size(421, 37);
            this.lblCommonRecords.TabIndex = 1;
            this.lblCommonRecords.Text = "Common Records (Top 100)";
            this.lblCommonRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMale
            // 
            this.dgvMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMale.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMale.Location = new System.Drawing.Point(0, 50);
            this.dgvMale.MultiSelect = false;
            this.dgvMale.Name = "dgvMale";
            this.dgvMale.RowHeadersVisible = false;
            this.dgvMale.RowHeadersWidth = 51;
            this.dgvMale.RowTemplate.Height = 25;
            this.dgvMale.Size = new System.Drawing.Size(522, 272);
            this.dgvMale.TabIndex = 4;
            // 
            // pnlTopMale
            // 
            this.pnlTopMale.Controls.Add(this.btnLoadMale);
            this.pnlTopMale.Controls.Add(this.lblAllMaleRecords);
            this.pnlTopMale.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMale.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMale.Name = "pnlTopMale";
            this.pnlTopMale.Size = new System.Drawing.Size(522, 50);
            this.pnlTopMale.TabIndex = 3;
            // 
            // btnLoadMale
            // 
            this.btnLoadMale.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadMale.Location = new System.Drawing.Point(424, 5);
            this.btnLoadMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadMale.Name = "btnLoadMale";
            this.btnLoadMale.Size = new System.Drawing.Size(88, 39);
            this.btnLoadMale.TabIndex = 2;
            this.btnLoadMale.Text = "Load";
            this.btnLoadMale.UseVisualStyleBackColor = true;
            this.btnLoadMale.Click += new System.EventHandler(this.btnLoadMale_Click);
            // 
            // lblAllMaleRecords
            // 
            this.lblAllMaleRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllMaleRecords.Location = new System.Drawing.Point(5, 7);
            this.lblAllMaleRecords.Name = "lblAllMaleRecords";
            this.lblAllMaleRecords.Size = new System.Drawing.Size(413, 37);
            this.lblAllMaleRecords.TabIndex = 1;
            this.lblAllMaleRecords.Text = "All Male Records";
            this.lblAllMaleRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbOperationResult);
            this.pnlHeader.Controls.Add(this.pnlListTop);
            this.pnlHeader.Controls.Add(this.lblOperationTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(732, 686);
            this.pnlHeader.TabIndex = 2;
            // 
            // lbOperationResult
            // 
            this.lbOperationResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOperationResult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOperationResult.FormattingEnabled = true;
            this.lbOperationResult.ItemHeight = 28;
            this.lbOperationResult.Location = new System.Drawing.Point(0, 50);
            this.lbOperationResult.Name = "lbOperationResult";
            this.lbOperationResult.Size = new System.Drawing.Size(732, 609);
            this.lbOperationResult.TabIndex = 1;
            // 
            // pnlListTop
            // 
            this.pnlListTop.Controls.Add(this.numericValue);
            this.pnlListTop.Controls.Add(this.cbExecutionType);
            this.pnlListTop.Controls.Add(this.btnExecuteProcess);
            this.pnlListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListTop.Location = new System.Drawing.Point(0, 0);
            this.pnlListTop.Name = "pnlListTop";
            this.pnlListTop.Size = new System.Drawing.Size(732, 50);
            this.pnlListTop.TabIndex = 3;
            // 
            // numericValue
            // 
            this.numericValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericValue.Location = new System.Drawing.Point(308, 10);
            this.numericValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericValue.Name = "numericValue";
            this.numericValue.Size = new System.Drawing.Size(131, 32);
            this.numericValue.TabIndex = 4;
            // 
            // cbExecutionType
            // 
            this.cbExecutionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbExecutionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbExecutionType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbExecutionType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbExecutionType.FormattingEnabled = true;
            this.cbExecutionType.Items.AddRange(new object[] {
            "Synchronous",
            "All Threads",
            "All Tasks",
            "Two Threads Two Tasks"});
            this.cbExecutionType.Location = new System.Drawing.Point(10, 11);
            this.cbExecutionType.Name = "cbExecutionType";
            this.cbExecutionType.Size = new System.Drawing.Size(257, 29);
            this.cbExecutionType.TabIndex = 3;
            // 
            // btnExecuteProcess
            // 
            this.btnExecuteProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExecuteProcess.Location = new System.Drawing.Point(480, 4);
            this.btnExecuteProcess.Name = "btnExecuteProcess";
            this.btnExecuteProcess.Size = new System.Drawing.Size(242, 43);
            this.btnExecuteProcess.TabIndex = 0;
            this.btnExecuteProcess.Text = "Execute Process";
            this.btnExecuteProcess.UseVisualStyleBackColor = true;
            this.btnExecuteProcess.Click += new System.EventHandler(this.btnExecuteProcess_Click);
            // 
            // lblOperationTime
            // 
            this.lblOperationTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOperationTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperationTime.Location = new System.Drawing.Point(0, 659);
            this.lblOperationTime.Name = "lblOperationTime";
            this.lblOperationTime.Size = new System.Drawing.Size(732, 27);
            this.lblOperationTime.TabIndex = 2;
            this.lblOperationTime.Text = "Total Time:";
            this.lblOperationTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsrCtrlParallelOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UsrCtrlParallelOperation";
            this.Size = new System.Drawing.Size(1841, 686);
            this.pnlMain.ResumeLayout(false);
            this.pnlLeftMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemale)).EndInit();
            this.pnlTopMostCommon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).EndInit();
            this.pnlTopAllRecords.ResumeLayout(false);
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostCommon)).EndInit();
            this.pnlTopFemale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMale)).EndInit();
            this.pnlTopMale.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlListTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel pnlHeader;
        private Panel pnlCenterMain;
        private Panel pnlLeftMain;
        private DataGridView dgvMostCommon;
        private Panel pnlTopMostCommon;
        private Label lblAllFemaleRecords;
        private DataGridView dgvAllRecords;
        private Panel pnlTopAllRecords;
        private Label lblAllRecords;
        private Panel pnlRightMain;
        private DataGridView dgvFemale;
        private Panel pnlTopFemale;
        private Label lblCommonRecords;
        private DataGridView dgvMale;
        private Panel pnlTopMale;
        private Label lblAllMaleRecords;
        private Button btnExecuteProcess;
        private ListBox lbOperationResult;
        private Label lblOperationTime;
        private ComboBox cbExecutionType;
        private Panel pnlListTop;
        private Button btnLoadAll;
        private Button btnLoadMale;
        private Button btnLoadFemale;
        private Button btnLoadCommon;
        public NumericUpDown numericValue;
    }
}
