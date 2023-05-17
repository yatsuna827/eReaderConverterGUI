namespace eReaderConverterGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dropAreaBin2Raw = new Panel();
            label1 = new Label();
            dropAreaBin2Bmp = new Panel();
            label2 = new Label();
            dropAreaRaw2Bmp = new Panel();
            label3 = new Label();
            loggerBox = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            offsetY = new NumericUpDown();
            label10 = new Label();
            label7 = new Label();
            offsetX = new NumericUpDown();
            label8 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            bitmapMargin = new NumericUpDown();
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1 = new Panel();
            label6 = new Label();
            dropAreaBin2Raw.SuspendLayout();
            dropAreaBin2Bmp.SuspendLayout();
            dropAreaRaw2Bmp.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bitmapMargin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dropAreaBin2Raw
            // 
            dropAreaBin2Raw.AllowDrop = true;
            dropAreaBin2Raw.BorderStyle = BorderStyle.FixedSingle;
            dropAreaBin2Raw.Controls.Add(label1);
            dropAreaBin2Raw.Location = new Point(22, 252);
            dropAreaBin2Raw.Margin = new Padding(6);
            dropAreaBin2Raw.Name = "dropAreaBin2Raw";
            dropAreaBin2Raw.Size = new Size(277, 211);
            dropAreaBin2Raw.TabIndex = 0;
            dropAreaBin2Raw.DragDrop += DropAreaBin2Raw_DragDrop;
            dropAreaBin2Raw.DragEnter += DropArea_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(65, 85);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 0;
            label1.Text = "BIN to Raw";
            // 
            // dropAreaBin2Bmp
            // 
            dropAreaBin2Bmp.AllowDrop = true;
            dropAreaBin2Bmp.BorderStyle = BorderStyle.FixedSingle;
            dropAreaBin2Bmp.Controls.Add(label2);
            dropAreaBin2Bmp.Location = new Point(22, 26);
            dropAreaBin2Bmp.Margin = new Padding(6);
            dropAreaBin2Bmp.Name = "dropAreaBin2Bmp";
            dropAreaBin2Bmp.Size = new Size(277, 211);
            dropAreaBin2Bmp.TabIndex = 1;
            dropAreaBin2Bmp.DragDrop += DropAreaBin2Bmp_DragDrop;
            dropAreaBin2Bmp.DragEnter += DropArea_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(65, 82);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 0;
            label2.Text = "BIN to Bitmap";
            // 
            // dropAreaRaw2Bmp
            // 
            dropAreaRaw2Bmp.AllowDrop = true;
            dropAreaRaw2Bmp.BorderStyle = BorderStyle.FixedSingle;
            dropAreaRaw2Bmp.Controls.Add(label3);
            dropAreaRaw2Bmp.Location = new Point(311, 26);
            dropAreaRaw2Bmp.Margin = new Padding(6);
            dropAreaRaw2Bmp.Name = "dropAreaRaw2Bmp";
            dropAreaRaw2Bmp.Size = new Size(277, 211);
            dropAreaRaw2Bmp.TabIndex = 2;
            dropAreaRaw2Bmp.DragDrop += DropAreaRaw2Bmp_DragDrop;
            dropAreaRaw2Bmp.DragEnter += DropArea_DragEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(63, 85);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 0;
            label3.Text = "Raw to Bitmap";
            // 
            // loggerBox
            // 
            loggerBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loggerBox.Location = new Point(22, 478);
            loggerBox.Margin = new Padding(6);
            loggerBox.Multiline = true;
            loggerBox.Name = "loggerBox";
            loggerBox.ScrollBars = ScrollBars.Vertical;
            loggerBox.Size = new Size(960, 345);
            loggerBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(offsetY);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(offsetX);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(bitmapMargin);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(650, 26);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(336, 439);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 383);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(62, 32);
            label12.TabIndex = 14;
            label12.Text = "倍率";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(276, 385);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(34, 32);
            label11.TabIndex = 13;
            label11.Text = "%";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(155, 383);
            numericUpDown1.Margin = new Padding(6);
            numericUpDown1.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(110, 39);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(276, 336);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 32);
            label9.TabIndex = 11;
            label9.Text = "pt";
            // 
            // offsetY
            // 
            offsetY.Location = new Point(155, 332);
            offsetY.Margin = new Padding(6);
            offsetY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            offsetY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            offsetY.Name = "offsetY";
            offsetY.Size = new Size(110, 39);
            offsetY.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 334);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 32);
            label10.TabIndex = 9;
            label10.Text = "Offset Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 285);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 32);
            label7.TabIndex = 8;
            label7.Text = "pt";
            // 
            // offsetX
            // 
            offsetX.Location = new Point(155, 281);
            offsetX.Margin = new Padding(6);
            offsetX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            offsetX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            offsetX.Name = "offsetX";
            offsetX.Size = new Size(110, 39);
            offsetX.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 283);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 32);
            label8.TabIndex = 6;
            label8.Text = "Offset X";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(32, 230);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(295, 40);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 40);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(32, 125);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 36);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "2x";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 62);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 32);
            label5.TabIndex = 2;
            label5.Text = "pt";
            // 
            // bitmapMargin
            // 
            bitmapMargin.Location = new Point(126, 58);
            bitmapMargin.Margin = new Padding(6);
            bitmapMargin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            bitmapMargin.Name = "bitmapMargin";
            bitmapMargin.Size = new Size(110, 39);
            bitmapMargin.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 62);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 0;
            label4.Text = "Margin";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(311, 252);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 211);
            panel1.TabIndex = 5;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += PrintDropArea_DragEnter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(65, 85);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 0;
            label6.Text = "Print Bitmap";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 853);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(loggerBox);
            Controls.Add(dropAreaRaw2Bmp);
            Controls.Add(dropAreaBin2Bmp);
            Controls.Add(dropAreaBin2Raw);
            Margin = new Padding(6);
            MinimumSize = new Size(637, 434);
            Name = "Form1";
            Text = "eReaderConverter";
            dropAreaBin2Raw.ResumeLayout(false);
            dropAreaBin2Raw.PerformLayout();
            dropAreaBin2Bmp.ResumeLayout(false);
            dropAreaBin2Bmp.PerformLayout();
            dropAreaRaw2Bmp.ResumeLayout(false);
            dropAreaRaw2Bmp.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetY).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetX).EndInit();
            ((System.ComponentModel.ISupportInitialize)bitmapMargin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel dropAreaBin2Raw;
        private Label label1;
        private Panel dropAreaBin2Bmp;
        private Label label2;
        private Panel dropAreaRaw2Bmp;
        private Label label3;
        private TextBox loggerBox;
        private GroupBox groupBox1;
        private Label label5;
        private NumericUpDown bitmapMargin;
        private Label label4;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panel1;
        private Label label6;
        private Label label12;
        private Label label11;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private NumericUpDown offsetY;
        private Label label10;
        private Label label7;
        private NumericUpDown offsetX;
        private Label label8;
    }
}