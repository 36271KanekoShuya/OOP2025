namespace RssReader {
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
            cbUrl = new ComboBox();
            btRssGet = new Button();
            lbTitles = new ListBox();
            label1 = new Label();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            lbErrorCodes = new Label();
            btGoBack = new Button();
            btGoForward = new Button();
            btFavorite = new Button();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // cbUrl
            // 
            cbUrl.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbUrl.Location = new Point(148, 30);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(543, 29);
            cbUrl.TabIndex = 0;
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRssGet.Location = new Point(697, 31);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(80, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbTitles.Font = new Font("Yu Gothic UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 23;
            lbTitles.Location = new Point(12, 64);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(298, 579);
            lbTitles.TabIndex = 2;
            lbTitles.Click += lbTitles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 3;
            label1.Text = "URL :";
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvRssLink.BackColor = SystemColors.ActiveCaption;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = SystemColors.ActiveCaption;
            wvRssLink.Location = new Point(316, 65);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(470, 594);
            wvRssLink.TabIndex = 4;
            wvRssLink.ZoomFactor = 1D;
            // 
            // lbErrorCodes
            // 
            lbErrorCodes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbErrorCodes.AutoSize = true;
            lbErrorCodes.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbErrorCodes.Location = new Point(12, 646);
            lbErrorCodes.Name = "lbErrorCodes";
            lbErrorCodes.Size = new Size(118, 17);
            lbErrorCodes.TabIndex = 5;
            lbErrorCodes.Text = "エラーコードなどがここに";
            // 
            // btGoBack
            // 
            btGoBack.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGoBack.Location = new Point(12, 31);
            btGoBack.Name = "btGoBack";
            btGoBack.Size = new Size(57, 31);
            btGoBack.TabIndex = 6;
            btGoBack.Text = "戻";
            btGoBack.UseVisualStyleBackColor = true;
            btGoBack.Click += btGoBack_Click;
            // 
            // btGoForward
            // 
            btGoForward.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGoForward.Location = new Point(75, 30);
            btGoForward.Name = "btGoForward";
            btGoForward.Size = new Size(57, 31);
            btGoForward.TabIndex = 7;
            btGoForward.Text = "進";
            btGoForward.UseVisualStyleBackColor = true;
            btGoForward.Click += btGoForward_Click;
            // 
            // btFavorite
            // 
            btFavorite.Location = new Point(697, 0);
            btFavorite.Name = "btFavorite";
            btFavorite.Size = new Size(80, 30);
            btFavorite.TabIndex = 8;
            btFavorite.Text = "☆";
            btFavorite.UseVisualStyleBackColor = true;
            btFavorite.Click += btFavorite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(789, 665);
            Controls.Add(btFavorite);
            Controls.Add(btGoForward);
            Controls.Add(btGoBack);
            Controls.Add(lbErrorCodes);
            Controls.Add(wvRssLink);
            Controls.Add(label1);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Controls.Add(cbUrl);
            Name = "Form1";
            Text = "RSSリーダー";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUrl;
        private Button btRssGet;
        private ListBox lbTitles;
        private Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Label lbErrorCodes;
        private Button btGoBack;
        private Button btGoForward;
        private Button btFavorite;
    }
}
