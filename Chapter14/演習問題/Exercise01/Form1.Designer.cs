namespace Exercise01 {
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
            tb_SelectedText = new TextBox();
            OpenFileDialog = new OpenFileDialog();
            tb_FileName = new TextBox();
            bt_Read = new Button();
            bt_FileSelect = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_SelectedText
            // 
            tb_SelectedText.AcceptsReturn = true;
            tb_SelectedText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_SelectedText.Location = new Point(12, 52);
            tb_SelectedText.Multiline = true;
            tb_SelectedText.Name = "tb_SelectedText";
            tb_SelectedText.ScrollBars = ScrollBars.Both;
            tb_SelectedText.Size = new Size(710, 386);
            tb_SelectedText.TabIndex = 0;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // tb_FileName
            // 
            tb_FileName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tb_FileName.Location = new Point(96, 14);
            tb_FileName.Name = "tb_FileName";
            tb_FileName.ReadOnly = true;
            tb_FileName.Size = new Size(434, 29);
            tb_FileName.TabIndex = 1;
            // 
            // bt_Read
            // 
            bt_Read.Font = new Font("Yu Gothic UI", 12F);
            bt_Read.Location = new Point(626, 8);
            bt_Read.Name = "bt_Read";
            bt_Read.Size = new Size(96, 35);
            bt_Read.TabIndex = 2;
            bt_Read.Text = "読込";
            bt_Read.UseVisualStyleBackColor = true;
            bt_Read.Click += bt_Read_Click;
            // 
            // bt_FileSelect
            // 
            bt_FileSelect.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bt_FileSelect.Location = new Point(536, 9);
            bt_FileSelect.Name = "bt_FileSelect";
            bt_FileSelect.Size = new Size(84, 35);
            bt_FileSelect.TabIndex = 3;
            bt_FileSelect.Text = "ファイル選択";
            bt_FileSelect.UseVisualStyleBackColor = true;
            bt_FileSelect.Click += bt_FileSelect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 4;
            label1.Text = "ファイル名 :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(label1);
            Controls.Add(bt_FileSelect);
            Controls.Add(bt_Read);
            Controls.Add(tb_FileName);
            Controls.Add(tb_SelectedText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_SelectedText;
        private OpenFileDialog OpenFileDialog;
        private TextBox tb_FileName;
        private Button bt_Read;
        private Button bt_FileSelect;
        private Label label1;
    }
}
