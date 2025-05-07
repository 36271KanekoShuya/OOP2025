namespace StopWatch {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TimeDispray = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.tmDispTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeDispray
            // 
            this.TimeDispray.BackColor = System.Drawing.Color.DarkRed;
            this.TimeDispray.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDispray.ForeColor = System.Drawing.Color.Yellow;
            this.TimeDispray.Location = new System.Drawing.Point(95, 46);
            this.TimeDispray.Name = "TimeDispray";
            this.TimeDispray.Size = new System.Drawing.Size(302, 59);
            this.TimeDispray.TabIndex = 0;
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Start_Button.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Start_Button.ForeColor = System.Drawing.Color.Goldenrod;
            this.Start_Button.Location = new System.Drawing.Point(39, 138);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(114, 52);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Reset_Button.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset_Button.ForeColor = System.Drawing.Color.Goldenrod;
            this.Reset_Button.Location = new System.Drawing.Point(326, 138);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(114, 52);
            this.Reset_Button.TabIndex = 2;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Stop_Button.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Stop_Button.ForeColor = System.Drawing.Color.Goldenrod;
            this.Stop_Button.Location = new System.Drawing.Point(184, 138);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(114, 52);
            this.Stop_Button.TabIndex = 2;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = false;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // tmDispTimer
            // 
            this.tmDispTimer.Interval = 10;
            this.tmDispTimer.Tick += new System.EventHandler(this.tmDispTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(470, 232);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.TimeDispray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimeDispray;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Timer tmDispTimer;
    }
}

