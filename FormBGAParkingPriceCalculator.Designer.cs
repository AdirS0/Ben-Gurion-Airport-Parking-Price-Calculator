namespace BenGurionAirportParkingPriceCalculator
{
    partial class FormBGAParkingPriceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBGAParkingPriceCalculator));
            this.buttonShortRange = new System.Windows.Forms.Button();
            this.buttonLongRange = new System.Windows.Forms.Button();
            this.buttonTerminalOne = new System.Windows.Forms.Button();
            this.buttonTerminalThree = new System.Windows.Forms.Button();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.labelDash = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelLongRangeInfo = new System.Windows.Forms.Label();
            this.labelShortRangeInfo = new System.Windows.Forms.Label();
            this.buttonWithCover = new System.Windows.Forms.Button();
            this.buttonWithoutCover = new System.Windows.Forms.Button();
            this.labelWithCoverInfo = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShortRange
            // 
            this.buttonShortRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShortRange.Location = new System.Drawing.Point(28, 45);
            this.buttonShortRange.Name = "buttonShortRange";
            this.buttonShortRange.Size = new System.Drawing.Size(110, 23);
            this.buttonShortRange.TabIndex = 0;
            this.buttonShortRange.Text = "Short Range";
            this.buttonShortRange.UseVisualStyleBackColor = true;
            this.buttonShortRange.Click += new System.EventHandler(this.buttonShortRange_Click);
            // 
            // buttonLongRange
            // 
            this.buttonLongRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLongRange.Location = new System.Drawing.Point(247, 45);
            this.buttonLongRange.Name = "buttonLongRange";
            this.buttonLongRange.Size = new System.Drawing.Size(110, 23);
            this.buttonLongRange.TabIndex = 1;
            this.buttonLongRange.Text = "Long Range";
            this.buttonLongRange.UseVisualStyleBackColor = true;
            this.buttonLongRange.Click += new System.EventHandler(this.buttonLongRange_Click);
            // 
            // buttonTerminalOne
            // 
            this.buttonTerminalOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTerminalOne.Location = new System.Drawing.Point(88, 90);
            this.buttonTerminalOne.Name = "buttonTerminalOne";
            this.buttonTerminalOne.Size = new System.Drawing.Size(87, 23);
            this.buttonTerminalOne.TabIndex = 2;
            this.buttonTerminalOne.Text = "Terminal 1";
            this.buttonTerminalOne.UseVisualStyleBackColor = true;
            this.buttonTerminalOne.Visible = false;
            this.buttonTerminalOne.Click += new System.EventHandler(this.buttonTerminalOne_Click);
            // 
            // buttonTerminalThree
            // 
            this.buttonTerminalThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTerminalThree.Location = new System.Drawing.Point(202, 90);
            this.buttonTerminalThree.Name = "buttonTerminalThree";
            this.buttonTerminalThree.Size = new System.Drawing.Size(87, 23);
            this.buttonTerminalThree.TabIndex = 3;
            this.buttonTerminalThree.Text = "Terminal 3";
            this.buttonTerminalThree.UseVisualStyleBackColor = true;
            this.buttonTerminalThree.Visible = false;
            this.buttonTerminalThree.Click += new System.EventHandler(this.buttonTerminalThree_Click);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStartTime.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateTimePickerStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerStartTime.Enabled = false;
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(12, 146);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerStartTime.TabIndex = 4;
            this.dateTimePickerStartTime.Value = new System.DateTime(2023, 7, 3, 16, 13, 21, 0);
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEndTime.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateTimePickerEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerEndTime.Enabled = false;
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(247, 146);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerEndTime.TabIndex = 5;
            this.dateTimePickerEndTime.Value = new System.DateTime(2023, 7, 3, 16, 13, 21, 0);
            // 
            // labelDash
            // 
            this.labelDash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDash.AutoSize = true;
            this.labelDash.Enabled = false;
            this.labelDash.Location = new System.Drawing.Point(186, 146);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(10, 13);
            this.labelDash.TabIndex = 6;
            this.labelDash.Text = "-";
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFrom.AutoSize = true;
            this.labelFrom.Enabled = false;
            this.labelFrom.Location = new System.Drawing.Point(9, 130);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTo.AutoSize = true;
            this.labelTo.Enabled = false;
            this.labelTo.Location = new System.Drawing.Point(244, 130);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 13);
            this.labelTo.TabIndex = 8;
            this.labelTo.Text = "To:";
            // 
            // labelLongRangeInfo
            // 
            this.labelLongRangeInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLongRangeInfo.AutoSize = true;
            this.labelLongRangeInfo.Location = new System.Drawing.Point(222, 29);
            this.labelLongRangeInfo.Name = "labelLongRangeInfo";
            this.labelLongRangeInfo.Size = new System.Drawing.Size(153, 13);
            this.labelLongRangeInfo.TabIndex = 9;
            this.labelLongRangeInfo.Text = "(Same price for both Terminals)";
            // 
            // labelShortRangeInfo
            // 
            this.labelShortRangeInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelShortRangeInfo.AutoSize = true;
            this.labelShortRangeInfo.Location = new System.Drawing.Point(0, 30);
            this.labelShortRangeInfo.Name = "labelShortRangeInfo";
            this.labelShortRangeInfo.Size = new System.Drawing.Size(164, 13);
            this.labelShortRangeInfo.TabIndex = 10;
            this.labelShortRangeInfo.Text = "(Different price for each Terminal)";
            // 
            // buttonWithCover
            // 
            this.buttonWithCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWithCover.Location = new System.Drawing.Point(74, 90);
            this.buttonWithCover.Name = "buttonWithCover";
            this.buttonWithCover.Size = new System.Drawing.Size(101, 23);
            this.buttonWithCover.TabIndex = 11;
            this.buttonWithCover.Text = "With Cover";
            this.buttonWithCover.UseVisualStyleBackColor = true;
            this.buttonWithCover.Visible = false;
            this.buttonWithCover.Click += new System.EventHandler(this.buttonWithCover_Click);
            // 
            // buttonWithoutCover
            // 
            this.buttonWithoutCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWithoutCover.Location = new System.Drawing.Point(199, 90);
            this.buttonWithoutCover.Name = "buttonWithoutCover";
            this.buttonWithoutCover.Size = new System.Drawing.Size(101, 23);
            this.buttonWithoutCover.TabIndex = 12;
            this.buttonWithoutCover.Text = "Without Cover";
            this.buttonWithoutCover.UseVisualStyleBackColor = true;
            this.buttonWithoutCover.Visible = false;
            this.buttonWithoutCover.Click += new System.EventHandler(this.buttonWithoutCover_Click);
            // 
            // labelWithCoverInfo
            // 
            this.labelWithCoverInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWithCoverInfo.AutoSize = true;
            this.labelWithCoverInfo.Location = new System.Drawing.Point(71, 74);
            this.labelWithCoverInfo.Name = "labelWithCoverInfo";
            this.labelWithCoverInfo.Size = new System.Drawing.Size(104, 13);
            this.labelWithCoverInfo.TabIndex = 13;
            this.labelWithCoverInfo.Text = "(Only for Terminal 3!)";
            this.labelWithCoverInfo.Visible = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.Location = new System.Drawing.Point(332, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(43, 26);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(138, 176);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(104, 23);
            this.buttonCalculate.TabIndex = 15;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInfo.Location = new System.Drawing.Point(3, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(25, 25);
            this.buttonInfo.TabIndex = 16;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormBGAParkingPriceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 211);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelWithCoverInfo);
            this.Controls.Add(this.buttonWithoutCover);
            this.Controls.Add(this.buttonWithCover);
            this.Controls.Add(this.labelShortRangeInfo);
            this.Controls.Add(this.labelLongRangeInfo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelDash);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.buttonTerminalThree);
            this.Controls.Add(this.buttonTerminalOne);
            this.Controls.Add(this.buttonLongRange);
            this.Controls.Add(this.buttonShortRange);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBGAParkingPriceCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ben Gurion Airport Parking Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShortRange;
        private System.Windows.Forms.Button buttonLongRange;
        private System.Windows.Forms.Button buttonTerminalOne;
        private System.Windows.Forms.Button buttonTerminalThree;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label labelDash;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelLongRangeInfo;
        private System.Windows.Forms.Label labelShortRangeInfo;
        private System.Windows.Forms.Button buttonWithCover;
        private System.Windows.Forms.Button buttonWithoutCover;
        private System.Windows.Forms.Label labelWithCoverInfo;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonInfo;
    }
}
