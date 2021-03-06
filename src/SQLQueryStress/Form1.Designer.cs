using System.Windows.Forms;

namespace SQLQueryStress
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
            if (backgroundWorker1.CancellationPending)
                System.Windows.Forms.MessageBox.Show("Please wait while background threads are cancelled.");
            else if (backgroundWorker1.IsBusy)
            {
                if (System.Windows.Forms.MessageBox.Show(
                "A test is currently running.  Cancel and shut down?",
                "Really Close?",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cancel_button_Click(new System.String(' ', 0), null);
                }
            }
            else
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainUITimer = new System.Windows.Forms.Timer(this.components);
            this.perfCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.db_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logicalReads_textBox = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iterations_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.threads_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.database_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cpuTime_textBox = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.totalExceptions_textBox = new System.Windows.Forms.Label();
            this.exceptions_button = new System.Windows.Forms.Button();
            this.actualSeconds_textBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.avgSeconds_textBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationsSecond_textBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.elapsedTime_textBox = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.go_button = new System.Windows.Forms.Button();
            this.param_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFreeCache = new System.Windows.Forms.Button();
            this.btnCleanBuffer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.queryDelay_textBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ColumnI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIterations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThreads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActualAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPUAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReadsAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExceptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.sqlControl1 = new SQLQueryStress.SqlControl();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads_numericUpDown)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.loadSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadSettingsToolStripMenuItem.Text = "Load Settings";
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // mainUITimer
            // 
            this.mainUITimer.Tick += new System.EventHandler(this.mainUITimer_Tick);
            // 
            // perfCounterTimer
            // 
            this.perfCounterTimer.Interval = 2500;
            // 
            // db_label
            // 
            this.db_label.AutoSize = true;
            this.db_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_label.Location = new System.Drawing.Point(55, 32);
            this.db_label.Name = "db_label";
            this.db_label.Size = new System.Drawing.Size(0, 13);
            this.db_label.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearGridToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // clearGridToolStripMenuItem
            // 
            this.clearGridToolStripMenuItem.Name = "clearGridToolStripMenuItem";
            this.clearGridToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clearGridToolStripMenuItem.Text = "Clear Grid";
            this.clearGridToolStripMenuItem.Click += new System.EventHandler(this.clearGridToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnI,
            this.ColumnQuery,
            this.ColumnIterations,
            this.ColumnThreads,
            this.ColumnDelay,
            this.ColumnTime,
            this.ColumnCompleted,
            this.ColumnClientAvg,
            this.ColumnActualAvg,
            this.ColumnCPUAvg,
            this.ColumnReadsAvg,
            this.ColumnExceptions});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 132);
            this.dataGridView1.TabIndex = 34;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.elementHost1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(845, 414);
            this.tableLayoutPanel3.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.Controls.Add(this.logicalReads_textBox, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.database_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.param_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cpuTime_textBox, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.iterations_numericUpDown, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.threads_numericUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.actualSeconds_textBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.queryDelay_textBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.avgSeconds_textBox, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.iterationsSecond_textBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.elapsedTime_textBox, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(438, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 404);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // logicalReads_textBox
            // 
            this.logicalReads_textBox.BackColor = System.Drawing.Color.Black;
            this.logicalReads_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.logicalReads_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logicalReads_textBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logicalReads_textBox.ForeColor = System.Drawing.Color.Lime;
            this.logicalReads_textBox.Location = new System.Drawing.Point(205, 303);
            this.logicalReads_textBox.Margin = new System.Windows.Forms.Padding(3);
            this.logicalReads_textBox.Name = "logicalReads_textBox";
            this.logicalReads_textBox.Size = new System.Drawing.Size(196, 30);
            this.logicalReads_textBox.TabIndex = 29;
            this.logicalReads_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(205, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 14);
            this.label12.TabIndex = 30;
            this.label12.Text = "Logical Reads/Iteration (Avg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Iterations";
            // 
            // iterations_numericUpDown
            // 
            this.iterations_numericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iterations_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterations_numericUpDown.Location = new System.Drawing.Point(3, 103);
            this.iterations_numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iterations_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterations_numericUpDown.Name = "iterations_numericUpDown";
            this.iterations_numericUpDown.Size = new System.Drawing.Size(196, 20);
            this.iterations_numericUpDown.TabIndex = 3;
            this.iterations_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // threads_numericUpDown
            // 
            this.threads_numericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threads_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threads_numericUpDown.Location = new System.Drawing.Point(205, 103);
            this.threads_numericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.threads_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threads_numericUpDown.Name = "threads_numericUpDown";
            this.threads_numericUpDown.Size = new System.Drawing.Size(196, 20);
            this.threads_numericUpDown.TabIndex = 4;
            this.threads_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Threads";
            // 
            // database_button
            // 
            this.database_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.database_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_button.Location = new System.Drawing.Point(3, 3);
            this.database_button.Name = "database_button";
            this.database_button.Size = new System.Drawing.Size(196, 30);
            this.database_button.TabIndex = 1;
            this.database_button.Text = "Database";
            this.database_button.UseVisualStyleBackColor = true;
            this.database_button.Click += new System.EventHandler(this.database_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 14);
            this.label9.TabIndex = 26;
            this.label9.Text = "CPU Seconds/Iteration (Avg)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(205, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 14);
            this.label10.TabIndex = 28;
            this.label10.Text = "Actual Seconds/Iteration (Avg)";
            // 
            // cpuTime_textBox
            // 
            this.cpuTime_textBox.BackColor = System.Drawing.Color.Black;
            this.cpuTime_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpuTime_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuTime_textBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTime_textBox.ForeColor = System.Drawing.Color.Lime;
            this.cpuTime_textBox.Location = new System.Drawing.Point(3, 303);
            this.cpuTime_textBox.Margin = new System.Windows.Forms.Padding(3);
            this.cpuTime_textBox.Name = "cpuTime_textBox";
            this.cpuTime_textBox.Size = new System.Drawing.Size(196, 30);
            this.cpuTime_textBox.TabIndex = 25;
            this.cpuTime_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.totalExceptions_textBox);
            this.flowLayoutPanel1.Controls.Add(this.exceptions_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 353);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 48);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // totalExceptions_textBox
            // 
            this.totalExceptions_textBox.BackColor = System.Drawing.Color.Black;
            this.totalExceptions_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalExceptions_textBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExceptions_textBox.ForeColor = System.Drawing.Color.Red;
            this.totalExceptions_textBox.Location = new System.Drawing.Point(3, 3);
            this.totalExceptions_textBox.Margin = new System.Windows.Forms.Padding(3);
            this.totalExceptions_textBox.Name = "totalExceptions_textBox";
            this.totalExceptions_textBox.Size = new System.Drawing.Size(155, 30);
            this.totalExceptions_textBox.TabIndex = 17;
            this.totalExceptions_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalExceptions_textBox.Click += new System.EventHandler(this.totalExceptions_textBox_Click);
            // 
            // exceptions_button
            // 
            this.exceptions_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exceptions_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exceptions_button.Location = new System.Drawing.Point(164, 3);
            this.exceptions_button.Name = "exceptions_button";
            this.exceptions_button.Size = new System.Drawing.Size(27, 30);
            this.exceptions_button.TabIndex = 10;
            this.exceptions_button.Text = "...";
            this.exceptions_button.UseVisualStyleBackColor = true;
            this.exceptions_button.Click += new System.EventHandler(this.exceptions_button_Click);
            // 
            // actualSeconds_textBox
            // 
            this.actualSeconds_textBox.BackColor = System.Drawing.Color.Black;
            this.actualSeconds_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.actualSeconds_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actualSeconds_textBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualSeconds_textBox.ForeColor = System.Drawing.Color.Lime;
            this.actualSeconds_textBox.Location = new System.Drawing.Point(205, 253);
            this.actualSeconds_textBox.Margin = new System.Windows.Forms.Padding(3);
            this.actualSeconds_textBox.Name = "actualSeconds_textBox";
            this.actualSeconds_textBox.Size = new System.Drawing.Size(196, 30);
            this.actualSeconds_textBox.TabIndex = 27;
            this.actualSeconds_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Exceptions";
            // 
            // avgSeconds_textBox
            // 
            this.avgSeconds_textBox.BackColor = System.Drawing.Color.Black;
            this.avgSeconds_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.avgSeconds_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgSeconds_textBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgSeconds_textBox.ForeColor = System.Drawing.Color.Lime;
            this.avgSeconds_textBox.Location = new System.Drawing.Point(3, 253);
            this.avgSeconds_textBox.Margin = new System.Windows.Forms.Padding(3);
            this.avgSeconds_textBox.Name = "avgSeconds_textBox";
            this.avgSeconds_textBox.Size = new System.Drawing.Size(196, 30);
            this.avgSeconds_textBox.TabIndex = 13;
            this.avgSeconds_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Client Seconds/Iteration (Avg)";
            // 
            // iterationsSecond_textBox
            // 
            this.iterationsSecond_textBox.BackColor = System.Drawing.Color.Black;
            this.iterationsSecond_textBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iterationsSecond_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iterationsSecond_textBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationsSecond_textBox.ForeColor = System.Drawing.Color.Lime;
            this.iterationsSecond_textBox.Location = new System.Drawing.Point(205, 203);
            this.iterationsSecond_textBox.Margin = new System.Windows.Forms.Padding(3);
            this.iterationsSecond_textBox.Name = "iterationsSecond_textBox";
            this.iterationsSecond_textBox.Size = new System.Drawing.Size(196, 30);
            this.iterationsSecond_textBox.TabIndex = 23;
            this.iterationsSecond_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Iterations Completed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Progress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Elapsed Time";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(205, 153);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 30);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            // 
            // elapsedTime_textBox
            // 
            this.elapsedTime_textBox.BackColor = System.Drawing.Color.Black;
            this.elapsedTime_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.elapsedTime_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elapsedTime_textBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTime_textBox.ForeColor = System.Drawing.Color.Lime;
            this.elapsedTime_textBox.Location = new System.Drawing.Point(3, 203);
            this.elapsedTime_textBox.Margin = new System.Windows.Forms.Padding(3);
            this.elapsedTime_textBox.Name = "elapsedTime_textBox";
            this.elapsedTime_textBox.Size = new System.Drawing.Size(196, 30);
            this.elapsedTime_textBox.TabIndex = 19;
            this.elapsedTime_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cancel_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.go_button, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(205, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 44);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // cancel_button
            // 
            this.cancel_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel_button.Enabled = false;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(101, 3);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(92, 38);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // go_button
            // 
            this.go_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.go_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_button.Location = new System.Drawing.Point(3, 3);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(92, 38);
            this.go_button.TabIndex = 6;
            this.go_button.Text = "GO";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // param_button
            // 
            this.param_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.param_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_button.Location = new System.Drawing.Point(205, 3);
            this.param_button.Name = "param_button";
            this.param_button.Size = new System.Drawing.Size(196, 30);
            this.param_button.TabIndex = 2;
            this.param_button.Text = "Parameter Substitution";
            this.param_button.UseVisualStyleBackColor = true;
            this.param_button.Click += new System.EventHandler(this.param_button_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnFreeCache, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCleanBuffer, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(196, 44);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // btnFreeCache
            // 
            this.btnFreeCache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFreeCache.Location = new System.Drawing.Point(101, 3);
            this.btnFreeCache.Name = "btnFreeCache";
            this.btnFreeCache.Size = new System.Drawing.Size(92, 38);
            this.btnFreeCache.TabIndex = 9;
            this.btnFreeCache.Text = "Free Cache";
            this.btnFreeCache.UseVisualStyleBackColor = true;
            this.btnFreeCache.Click += new System.EventHandler(this.btnFreeCache_Click);
            // 
            // btnCleanBuffer
            // 
            this.btnCleanBuffer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCleanBuffer.Location = new System.Drawing.Point(3, 3);
            this.btnCleanBuffer.Name = "btnCleanBuffer";
            this.btnCleanBuffer.Size = new System.Drawing.Size(92, 38);
            this.btnCleanBuffer.TabIndex = 8;
            this.btnCleanBuffer.Text = "Clean Buffers";
            this.btnCleanBuffer.UseVisualStyleBackColor = true;
            this.btnCleanBuffer.Click += new System.EventHandler(this.btnCleanBuffer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(3, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 14);
            this.label11.TabIndex = 34;
            this.label11.Text = "Delay between queries (ms)";
            // 
            // queryDelay_textBox
            // 
            this.queryDelay_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDelay_textBox.Location = new System.Drawing.Point(3, 153);
            this.queryDelay_textBox.Name = "queryDelay_textBox";
            this.queryDelay_textBox.Size = new System.Drawing.Size(196, 20);
            this.queryDelay_textBox.TabIndex = 5;
            this.queryDelay_textBox.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1MinSize = 405;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(845, 550);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 36;
            // 
            // ColumnI
            // 
            this.ColumnI.HeaderText = "i";
            this.ColumnI.Name = "ColumnI";
            this.ColumnI.ReadOnly = true;
            this.ColumnI.Width = 30;
            // 
            // ColumnQuery
            // 
            this.ColumnQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnQuery.HeaderText = "Query";
            this.ColumnQuery.MinimumWidth = 80;
            this.ColumnQuery.Name = "ColumnQuery";
            this.ColumnQuery.ReadOnly = true;
            // 
            // ColumnIterations
            // 
            this.ColumnIterations.HeaderText = "Iterations";
            this.ColumnIterations.Name = "ColumnIterations";
            this.ColumnIterations.ReadOnly = true;
            this.ColumnIterations.Width = 60;
            // 
            // ColumnThreads
            // 
            this.ColumnThreads.HeaderText = "Threads";
            this.ColumnThreads.Name = "ColumnThreads";
            this.ColumnThreads.ReadOnly = true;
            this.ColumnThreads.Width = 60;
            // 
            // ColumnDelay
            // 
            this.ColumnDelay.HeaderText = "Delay";
            this.ColumnDelay.Name = "ColumnDelay";
            this.ColumnDelay.ReadOnly = true;
            this.ColumnDelay.Width = 50;
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 55;
            // 
            // ColumnCompleted
            // 
            this.ColumnCompleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCompleted.HeaderText = "Completed";
            this.ColumnCompleted.Name = "ColumnCompleted";
            this.ColumnCompleted.ReadOnly = true;
            this.ColumnCompleted.Width = 82;
            // 
            // ColumnClientAvg
            // 
            this.ColumnClientAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnClientAvg.HeaderText = "ClientAvg";
            this.ColumnClientAvg.Name = "ColumnClientAvg";
            this.ColumnClientAvg.ReadOnly = true;
            this.ColumnClientAvg.Width = 77;
            // 
            // ColumnActualAvg
            // 
            this.ColumnActualAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnActualAvg.HeaderText = "ActualAvg";
            this.ColumnActualAvg.Name = "ColumnActualAvg";
            this.ColumnActualAvg.ReadOnly = true;
            this.ColumnActualAvg.Width = 81;
            // 
            // ColumnCPUAvg
            // 
            this.ColumnCPUAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCPUAvg.HeaderText = "CPUAvg";
            this.ColumnCPUAvg.Name = "ColumnCPUAvg";
            this.ColumnCPUAvg.ReadOnly = true;
            this.ColumnCPUAvg.Width = 73;
            // 
            // ColumnReadsAvg
            // 
            this.ColumnReadsAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnReadsAvg.HeaderText = "ReadsAvg";
            this.ColumnReadsAvg.Name = "ColumnReadsAvg";
            this.ColumnReadsAvg.ReadOnly = true;
            this.ColumnReadsAvg.Width = 82;
            // 
            // ColumnExceptions
            // 
            this.ColumnExceptions.HeaderText = "Exceptions";
            this.ColumnExceptions.Name = "ColumnExceptions";
            this.ColumnExceptions.ReadOnly = true;
            this.ColumnExceptions.Width = 65;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(429, 408);
            this.elementHost1.TabIndex = 33;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.sqlControl1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(845, 596);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.db_label);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.Text = "SQLQueryStress";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads_numericUpDown)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer mainUITimer;
        private System.Windows.Forms.Timer perfCounterTimer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label db_label;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem clearGridToolStripMenuItem;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label logicalReads_textBox;
        private Label label12;
        private Label label2;
        private NumericUpDown iterations_numericUpDown;
        private NumericUpDown threads_numericUpDown;
        private Label label3;
        private Button database_button;
        private Label label9;
        private Label label10;
        private Label cpuTime_textBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label totalExceptions_textBox;
        private Button exceptions_button;
        private Label actualSeconds_textBox;
        private Label label7;
        private Label avgSeconds_textBox;
        private Label label5;
        private Label iterationsSecond_textBox;
        private Label label4;
        private Label label6;
        private Label label8;
        private ProgressBar progressBar1;
        private Label elapsedTime_textBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button cancel_button;
        private Button go_button;
        private Button param_button;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnFreeCache;
        private Button btnCleanBuffer;
        private Label label11;
        private TextBox queryDelay_textBox;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SqlControl sqlControl1;
        private SplitContainer splitContainer1;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnI;
        private DataGridViewTextBoxColumn ColumnQuery;
        private DataGridViewTextBoxColumn ColumnIterations;
        private DataGridViewTextBoxColumn ColumnThreads;
        private DataGridViewTextBoxColumn ColumnDelay;
        private DataGridViewTextBoxColumn ColumnTime;
        private DataGridViewTextBoxColumn ColumnCompleted;
        private DataGridViewTextBoxColumn ColumnClientAvg;
        private DataGridViewTextBoxColumn ColumnActualAvg;
        private DataGridViewTextBoxColumn ColumnCPUAvg;
        private DataGridViewTextBoxColumn ColumnReadsAvg;
        private DataGridViewTextBoxColumn ColumnExceptions;
    }
}

