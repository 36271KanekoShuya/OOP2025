namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Day_label = new Label();
            Writer_label = new Label();
            Maker_label = new Label();
            CarName_label = new Label();
            dtpDate = new DateTimePicker();
            Report_label = new Label();
            ArticleList_label = new Label();
            picture_label = new Label();
            rbToyota = new RadioButton();
            rbNissan = new RadioButton();
            rbHonda = new RadioButton();
            rbSubaru = new RadioButton();
            rbImport = new RadioButton();
            rbOther = new RadioButton();
            cbAuthor = new ComboBox();
            cbCarName = new ComboBox();
            tbReport = new TextBox();
            dgvRecord = new DataGridView();
            groupBox1 = new GroupBox();
            pbPicture = new PictureBox();
            btPicOpen = new Button();
            btPicDelete = new Button();
            btRecordAdd = new Button();
            btRecordModify = new Button();
            btRecordDelete = new Button();
            ofdPicFileOpen = new OpenFileDialog();
            btNewWrite = new Button();
            ssMessageArea = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            tsmiFile = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            tsmiSave = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiColorOption = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiExit = new ToolStripMenuItem();
            tsmiHelp = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            cdColor = new ColorDialog();
            sfdReportFileSave = new SaveFileDialog();
            ofdReportFileOpen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ssMessageArea.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Day_label
            // 
            Day_label.AutoSize = true;
            Day_label.Font = new Font("Yu Gothic UI", 16F);
            Day_label.Location = new Point(47, 42);
            Day_label.Name = "Day_label";
            Day_label.Size = new Size(57, 30);
            Day_label.TabIndex = 1;
            Day_label.Text = "日付";
            // 
            // Writer_label
            // 
            Writer_label.AutoSize = true;
            Writer_label.Font = new Font("Yu Gothic UI", 16F);
            Writer_label.Location = new Point(27, 97);
            Writer_label.Name = "Writer_label";
            Writer_label.Size = new Size(79, 30);
            Writer_label.TabIndex = 1;
            Writer_label.Text = "記録者";
            // 
            // Maker_label
            // 
            Maker_label.AutoSize = true;
            Maker_label.Font = new Font("Yu Gothic UI", 16F);
            Maker_label.Location = new Point(27, 154);
            Maker_label.Name = "Maker_label";
            Maker_label.Size = new Size(73, 30);
            Maker_label.TabIndex = 1;
            Maker_label.Text = "メーカー";
            // 
            // CarName_label
            // 
            CarName_label.AutoSize = true;
            CarName_label.Font = new Font("Yu Gothic UI", 16F);
            CarName_label.Location = new Point(47, 215);
            CarName_label.Name = "CarName_label";
            CarName_label.Size = new Size(57, 30);
            CarName_label.TabIndex = 1;
            CarName_label.Text = "車名";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 16F);
            dtpDate.Location = new Point(123, 42);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(216, 36);
            dtpDate.TabIndex = 2;
            // 
            // Report_label
            // 
            Report_label.AutoSize = true;
            Report_label.Font = new Font("Yu Gothic UI", 16F);
            Report_label.Location = new Point(27, 272);
            Report_label.Name = "Report_label";
            Report_label.Size = new Size(77, 30);
            Report_label.TabIndex = 1;
            Report_label.Text = "レポート";
            // 
            // ArticleList_label
            // 
            ArticleList_label.AutoSize = true;
            ArticleList_label.Font = new Font("Yu Gothic UI", 16F);
            ArticleList_label.Location = new Point(5, 419);
            ArticleList_label.Name = "ArticleList_label";
            ArticleList_label.Size = new Size(101, 30);
            ArticleList_label.TabIndex = 3;
            ArticleList_label.Text = "記事一覧";
            // 
            // picture_label
            // 
            picture_label.AutoSize = true;
            picture_label.Font = new Font("Yu Gothic UI", 16F);
            picture_label.Location = new Point(534, 28);
            picture_label.Name = "picture_label";
            picture_label.Size = new Size(57, 30);
            picture_label.TabIndex = 3;
            picture_label.Text = "画像";
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(7, 22);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 4;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(63, 22);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 4;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(118, 22);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 4;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(177, 22);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 4;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(237, 22);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 4;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(304, 22);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 4;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 16F);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(123, 97);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(216, 38);
            cbAuthor.TabIndex = 5;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 16F);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(123, 212);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(216, 38);
            cbCarName.TabIndex = 5;
            // 
            // tbReport
            // 
            tbReport.Font = new Font("Yu Gothic UI", 12F);
            tbReport.Location = new Point(123, 269);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(405, 132);
            tbReport.TabIndex = 6;
            // 
            // dgvRecord
            // 
            dgvRecord.AllowUserToAddRows = false;
            dgvRecord.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dgvRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(123, 419);
            dgvRecord.MultiSelect = false;
            dgvRecord.Name = "dgvRecord";
            dgvRecord.ReadOnly = true;
            dgvRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecord.Size = new Size(643, 199);
            dgvRecord.TabIndex = 7;
            dgvRecord.Click += dgvRecord_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Location = new Point(123, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 51);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = SystemColors.GradientActiveCaption;
            pbPicture.Location = new Point(534, 61);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(294, 211);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 9;
            pbPicture.TabStop = false;
            // 
            // btPicOpen
            // 
            btPicOpen.Font = new Font("Yu Gothic UI", 12F);
            btPicOpen.Location = new Point(669, 30);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(78, 30);
            btPicOpen.TabIndex = 10;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.Font = new Font("Yu Gothic UI", 12F);
            btPicDelete.ForeColor = Color.Red;
            btPicDelete.Location = new Point(753, 28);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 30);
            btPicDelete.TabIndex = 11;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // btRecordAdd
            // 
            btRecordAdd.Font = new Font("Yu Gothic UI", 12F);
            btRecordAdd.Location = new Point(552, 379);
            btRecordAdd.Name = "btRecordAdd";
            btRecordAdd.Size = new Size(85, 35);
            btRecordAdd.TabIndex = 10;
            btRecordAdd.Text = "記事追加";
            btRecordAdd.UseVisualStyleBackColor = true;
            btRecordAdd.Click += btRecordAdd_Click;
            // 
            // btRecordModify
            // 
            btRecordModify.Font = new Font("Yu Gothic UI", 12F);
            btRecordModify.Location = new Point(643, 379);
            btRecordModify.Name = "btRecordModify";
            btRecordModify.Size = new Size(85, 35);
            btRecordModify.TabIndex = 10;
            btRecordModify.Text = "記事修正";
            btRecordModify.UseVisualStyleBackColor = true;
            btRecordModify.Click += btRecordModify_Click;
            // 
            // btRecordDelete
            // 
            btRecordDelete.Font = new Font("Yu Gothic UI", 12F);
            btRecordDelete.ForeColor = Color.Red;
            btRecordDelete.Location = new Point(734, 379);
            btRecordDelete.Name = "btRecordDelete";
            btRecordDelete.Size = new Size(85, 35);
            btRecordDelete.TabIndex = 10;
            btRecordDelete.Text = "記事削除";
            btRecordDelete.UseVisualStyleBackColor = true;
            btRecordDelete.Click += btRecordDelete_Click;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // btNewWrite
            // 
            btNewWrite.Font = new Font("Yu Gothic UI", 12F);
            btNewWrite.Location = new Point(534, 278);
            btNewWrite.Name = "btNewWrite";
            btNewWrite.Size = new Size(120, 43);
            btNewWrite.TabIndex = 12;
            btNewWrite.Text = "項目クリア";
            btNewWrite.UseVisualStyleBackColor = true;
            btNewWrite.Click += btNewWrite_Click;
            // 
            // ssMessageArea
            // 
            ssMessageArea.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            ssMessageArea.Location = new Point(0, 625);
            ssMessageArea.Name = "ssMessageArea";
            ssMessageArea.Size = new Size(844, 22);
            ssMessageArea.TabIndex = 13;
            ssMessageArea.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile, tsmiHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(844, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            tsmiFile.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpen, tsmiSave, toolStripSeparator2, tsmiColorOption, toolStripSeparator1, tsmiExit });
            tsmiFile.Name = "tsmiFile";
            tsmiFile.Size = new Size(67, 20);
            tsmiFile.Text = "ファイル(&F)";
            // 
            // tsmiOpen
            // 
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new Size(180, 22);
            tsmiOpen.Text = "開く...";
            tsmiOpen.Click += tsmiOpen_Click;
            // 
            // tsmiSave
            // 
            tsmiSave.Name = "tsmiSave";
            tsmiSave.Size = new Size(180, 22);
            tsmiSave.Text = "保存…";
            tsmiSave.Click += tsmiSave_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // tsmiColorOption
            // 
            tsmiColorOption.Name = "tsmiColorOption";
            tsmiColorOption.Size = new Size(180, 22);
            tsmiColorOption.Text = "色設定…";
            tsmiColorOption.Click += tsmiColorOption_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmiExit.Size = new Size(180, 22);
            tsmiExit.Text = "終了";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // tsmiHelp
            // 
            tsmiHelp.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbout });
            tsmiHelp.Name = "tsmiHelp";
            tsmiHelp.Size = new Size(65, 20);
            tsmiHelp.Text = "ヘルプ(&H)";
            // 
            // tsmiAbout
            // 
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(164, 22);
            tsmiAbout.Text = "このアプリについて…";
            tsmiAbout.Click += tsmiAbout_Click;
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 647);
            Controls.Add(ssMessageArea);
            Controls.Add(menuStrip1);
            Controls.Add(btNewWrite);
            Controls.Add(btPicDelete);
            Controls.Add(btRecordDelete);
            Controls.Add(btRecordModify);
            Controls.Add(btRecordAdd);
            Controls.Add(btPicOpen);
            Controls.Add(pbPicture);
            Controls.Add(groupBox1);
            Controls.Add(dgvRecord);
            Controls.Add(tbReport);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(picture_label);
            Controls.Add(ArticleList_label);
            Controls.Add(dtpDate);
            Controls.Add(Report_label);
            Controls.Add(CarName_label);
            Controls.Add(Writer_label);
            Controls.Add(Maker_label);
            Controls.Add(Day_label);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ssMessageArea.ResumeLayout(false);
            ssMessageArea.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Day_label;
        private Label Writer_label;
        private Label Maker_label;
        private Label CarName_label;
        private DateTimePicker dtpDate;
        private Label Report_label;
        private Label ArticleList_label;
        private Label picture_label;
        private RadioButton rbToyota;
        private RadioButton rbNissan;
        private RadioButton rbHonda;
        private RadioButton rbSubaru;
        private RadioButton rbImport;
        private RadioButton rbOther;
        private ComboBox cbAuthor;
        private ComboBox cbCarName;
        private TextBox tbReport;
        private DataGridView dgvRecord;
        private GroupBox groupBox1;
        private PictureBox pbPicture;
        private Button btPicOpen;
        private Button btPicDelete;
        private Button btRecordAdd;
        private Button btRecordModify;
        private Button btRecordDelete;
        private OpenFileDialog ofdPicFileOpen;
        private Button btNewWrite;
        private StatusStrip ssMessageArea;
        private ToolStripStatusLabel tsslbMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem tsmiAbout;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiSave;
        private ToolStripMenuItem tsmiColorOption;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiExit;
        private ColorDialog cdColor;
        private SaveFileDialog sfdReportFileSave;
        private OpenFileDialog ofdReportFileOpen;
    }
}
