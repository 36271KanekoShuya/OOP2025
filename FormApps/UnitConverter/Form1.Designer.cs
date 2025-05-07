namespace UnitConverter {
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
            this.Title = new System.Windows.Forms.Label();
            this.BeforeConversion_tb = new System.Windows.Forms.TextBox();
            this.BeforeConversion_tx = new System.Windows.Forms.Label();
            this.Conversion_Button = new System.Windows.Forms.Button();
            this.AfterConversion_tx = new System.Windows.Forms.Label();
            this.AfterConversion_tb = new System.Windows.Forms.TextBox();
            this.WarareruCount = new System.Windows.Forms.NumericUpDown();
            this.WaruCount = new System.Windows.Forms.NumericUpDown();
            this.Division_Button = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Label();
            this.Remainder_tx = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.NumericUpDown();
            this.Remainder = new System.Windows.Forms.NumericUpDown();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WarareruCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaruCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remainder)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(56, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(243, 37);
            this.Title.TabIndex = 1;
            this.Title.Text = "距離変換アプリ";
            // 
            // BeforeConversion_tb
            // 
            this.BeforeConversion_tb.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BeforeConversion_tb.Location = new System.Drawing.Point(129, 115);
            this.BeforeConversion_tb.Name = "BeforeConversion_tb";
            this.BeforeConversion_tb.Size = new System.Drawing.Size(124, 44);
            this.BeforeConversion_tb.TabIndex = 0;
            // 
            // BeforeConversion_tx
            // 
            this.BeforeConversion_tx.AutoSize = true;
            this.BeforeConversion_tx.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BeforeConversion_tx.Location = new System.Drawing.Point(12, 122);
            this.BeforeConversion_tx.Name = "BeforeConversion_tx";
            this.BeforeConversion_tx.Size = new System.Drawing.Size(111, 33);
            this.BeforeConversion_tx.TabIndex = 1;
            this.BeforeConversion_tx.Text = "変換前";
            // 
            // Conversion_Button
            // 
            this.Conversion_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Conversion_Button.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Conversion_Button.Location = new System.Drawing.Point(129, 183);
            this.Conversion_Button.Name = "Conversion_Button";
            this.Conversion_Button.Size = new System.Drawing.Size(124, 44);
            this.Conversion_Button.TabIndex = 2;
            this.Conversion_Button.Text = "変換";
            this.Conversion_Button.UseVisualStyleBackColor = false;
            this.Conversion_Button.Enter += new System.EventHandler(this.Conversion_Button_Click);
            // 
            // AfterConversion_tx
            // 
            this.AfterConversion_tx.AutoSize = true;
            this.AfterConversion_tx.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AfterConversion_tx.Location = new System.Drawing.Point(12, 272);
            this.AfterConversion_tx.Name = "AfterConversion_tx";
            this.AfterConversion_tx.Size = new System.Drawing.Size(111, 33);
            this.AfterConversion_tx.TabIndex = 1;
            this.AfterConversion_tx.Text = "変換後";
            // 
            // AfterConversion_tb
            // 
            this.AfterConversion_tb.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AfterConversion_tb.Location = new System.Drawing.Point(129, 265);
            this.AfterConversion_tb.Name = "AfterConversion_tb";
            this.AfterConversion_tb.Size = new System.Drawing.Size(124, 44);
            this.AfterConversion_tb.TabIndex = 0;
            // 
            // WarareruCount
            // 
            this.WarareruCount.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WarareruCount.Location = new System.Drawing.Point(51, 417);
            this.WarareruCount.Name = "WarareruCount";
            this.WarareruCount.Size = new System.Drawing.Size(120, 42);
            this.WarareruCount.TabIndex = 4;
            // 
            // WaruCount
            // 
            this.WaruCount.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WaruCount.Location = new System.Drawing.Point(310, 417);
            this.WaruCount.Name = "WaruCount";
            this.WaruCount.Size = new System.Drawing.Size(120, 42);
            this.WaruCount.TabIndex = 4;
            // 
            // Division_Button
            // 
            this.Division_Button.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Division_Button.Location = new System.Drawing.Point(198, 415);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(91, 44);
            this.Division_Button.TabIndex = 5;
            this.Division_Button.Text = "÷";
            this.Division_Button.UseVisualStyleBackColor = true;
            this.Division_Button.Click += new System.EventHandler(this.Division_Button_Click);
            // 
            // Equals
            // 
            this.Equals.AutoSize = true;
            this.Equals.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Equals.Location = new System.Drawing.Point(436, 426);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(31, 33);
            this.Equals.TabIndex = 1;
            this.Equals.Text = "=";
            // 
            // Remainder_tx
            // 
            this.Remainder_tx.AutoSize = true;
            this.Remainder_tx.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Remainder_tx.Location = new System.Drawing.Point(599, 421);
            this.Remainder_tx.Name = "Remainder_tx";
            this.Remainder_tx.Size = new System.Drawing.Size(85, 33);
            this.Remainder_tx.TabIndex = 1;
            this.Remainder_tx.Text = "あまり";
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Answer.Location = new System.Drawing.Point(473, 417);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(120, 42);
            this.Answer.TabIndex = 4;
            // 
            // Remainder
            // 
            this.Remainder.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Remainder.Location = new System.Drawing.Point(690, 415);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(120, 42);
            this.Remainder.TabIndex = 4;
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.Color.DarkRed;
            this.ErrorBox.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ErrorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ErrorBox.Location = new System.Drawing.Point(375, 321);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(124, 44);
            this.ErrorBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 492);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Remainder);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.WaruCount);
            this.Controls.Add(this.WarareruCount);
            this.Controls.Add(this.Conversion_Button);
            this.Controls.Add(this.Remainder_tx);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.AfterConversion_tx);
            this.Controls.Add(this.BeforeConversion_tx);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.AfterConversion_tb);
            this.Controls.Add(this.BeforeConversion_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WarareruCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaruCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remainder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox BeforeConversion_tb;
        private System.Windows.Forms.Label BeforeConversion_tx;
        private System.Windows.Forms.Button Conversion_Button;
        private System.Windows.Forms.Label AfterConversion_tx;
        private System.Windows.Forms.TextBox AfterConversion_tb;
        private System.Windows.Forms.NumericUpDown WarareruCount;
        private System.Windows.Forms.NumericUpDown WaruCount;
        private System.Windows.Forms.Button Division_Button;
        private System.Windows.Forms.Label Equals;
        private System.Windows.Forms.Label Remainder_tx;
        private System.Windows.Forms.NumericUpDown Answer;
        private System.Windows.Forms.NumericUpDown Remainder;
        private System.Windows.Forms.TextBox ErrorBox;
    }
}

