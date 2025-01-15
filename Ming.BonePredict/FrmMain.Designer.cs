namespace Ming.BonePredict
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.lblSolarYear = new System.Windows.Forms.Label();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPredictResult = new System.Windows.Forms.TextBox();
            this.cbLunarHour = new System.Windows.Forms.ComboBox();
            this.cbLunarMonth = new System.Windows.Forms.ComboBox();
            this.cbLunarDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "称重";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSolarYear
            // 
            this.lblSolarYear.AutoSize = true;
            this.lblSolarYear.Location = new System.Drawing.Point(61, 14);
            this.lblSolarYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolarYear.Name = "lblSolarYear";
            this.lblSolarYear.Size = new System.Drawing.Size(19, 15);
            this.lblSolarYear.TabIndex = 1;
            this.lblSolarYear.Text = "年";
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.Location = new System.Drawing.Point(12, 10);
            this.tbBirthYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(49, 23);
            this.tbBirthYear.TabIndex = 2;
            this.tbBirthYear.Text = "1983";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = " ";
            // 
            // tbPredictResult
            // 
            this.tbPredictResult.Location = new System.Drawing.Point(12, 40);
            this.tbPredictResult.Multiline = true;
            this.tbPredictResult.Name = "tbPredictResult";
            this.tbPredictResult.Size = new System.Drawing.Size(457, 155);
            this.tbPredictResult.TabIndex = 9;
            // 
            // cbLunarHour
            // 
            this.cbLunarHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLunarHour.FormattingEnabled = true;
            this.cbLunarHour.Location = new System.Drawing.Point(283, 10);
            this.cbLunarHour.Name = "cbLunarHour";
            this.cbLunarHour.Size = new System.Drawing.Size(104, 23);
            this.cbLunarHour.TabIndex = 11;
            // 
            // cbLunarMonth
            // 
            this.cbLunarMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLunarMonth.FormattingEnabled = true;
            this.cbLunarMonth.Location = new System.Drawing.Point(87, 10);
            this.cbLunarMonth.Name = "cbLunarMonth";
            this.cbLunarMonth.Size = new System.Drawing.Size(96, 23);
            this.cbLunarMonth.TabIndex = 12;
            // 
            // cbLunarDay
            // 
            this.cbLunarDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLunarDay.FormattingEnabled = true;
            this.cbLunarDay.Location = new System.Drawing.Point(189, 10);
            this.cbLunarDay.Name = "cbLunarDay";
            this.cbLunarDay.Size = new System.Drawing.Size(88, 23);
            this.cbLunarDay.TabIndex = 13;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 207);
            this.Controls.Add(this.cbLunarDay);
            this.Controls.Add(this.cbLunarMonth);
            this.Controls.Add(this.cbLunarHour);
            this.Controls.Add(this.tbPredictResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.lblSolarYear);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鬼谷子-称重";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSolarYear;
        private System.Windows.Forms.TextBox tbBirthYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPredictResult;
        private System.Windows.Forms.ComboBox cbLunarHour;
        private System.Windows.Forms.ComboBox cbLunarMonth;
        private System.Windows.Forms.ComboBox cbLunarDay;
    }
}

