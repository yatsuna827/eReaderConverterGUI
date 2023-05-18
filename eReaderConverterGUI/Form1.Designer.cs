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
            dropAreaConvert = new Panel();
            label2 = new Label();
            loggerBox = new TextBox();
            groupBox1 = new GroupBox();
            dotBlur = new CheckBox();
            bitmap2x = new CheckBox();
            label5 = new Label();
            bitmapMargin = new NumericUpDown();
            label4 = new Label();
            label12 = new Label();
            label11 = new Label();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            offsetY = new NumericUpDown();
            label10 = new Label();
            label7 = new Label();
            offsetX = new NumericUpDown();
            label8 = new Label();
            paperBox = new ComboBox();
            printerBox = new ComboBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            dropAreaPrint = new Panel();
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            convertMode = new ComboBox();
            tabPage2 = new TabPage();
            label3 = new Label();
            label1 = new Label();
            printMode = new ComboBox();
            dropAreaConvert.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bitmapMargin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetX).BeginInit();
            dropAreaPrint.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dropAreaConvert
            // 
            dropAreaConvert.AllowDrop = true;
            dropAreaConvert.BorderStyle = BorderStyle.FixedSingle;
            dropAreaConvert.Controls.Add(label2);
            dropAreaConvert.Location = new Point(24, 77);
            dropAreaConvert.Margin = new Padding(6);
            dropAreaConvert.Name = "dropAreaConvert";
            dropAreaConvert.Size = new Size(277, 211);
            dropAreaConvert.TabIndex = 1;
            dropAreaConvert.DragDrop += DropAreaConvert_DragDrop;
            dropAreaConvert.DragEnter += DropAreaConvert_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(45, 76);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 64);
            label2.TabIndex = 0;
            label2.Text = "Drop file here \r\nto convert";
            // 
            // loggerBox
            // 
            loggerBox.Location = new Point(363, 33);
            loggerBox.Margin = new Padding(6);
            loggerBox.Multiline = true;
            loggerBox.Name = "loggerBox";
            loggerBox.ScrollBars = ScrollBars.Vertical;
            loggerBox.Size = new Size(572, 220);
            loggerBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dotBlur);
            groupBox1.Controls.Add(bitmap2x);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(bitmapMargin);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(336, 238);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "ドットコード設定";
            // 
            // dotBlur
            // 
            dotBlur.AutoSize = true;
            dotBlur.Location = new Point(32, 167);
            dotBlur.Name = "dotBlur";
            dotBlur.Size = new Size(222, 36);
            dotBlur.TabIndex = 15;
            dotBlur.Text = "中間色を配置する";
            dotBlur.UseVisualStyleBackColor = true;
            // 
            // bitmap2x
            // 
            bitmap2x.AutoSize = true;
            bitmap2x.Checked = true;
            bitmap2x.CheckState = CheckState.Checked;
            bitmap2x.Location = new Point(32, 125);
            bitmap2x.Name = "bitmap2x";
            bitmap2x.Size = new Size(177, 36);
            bitmap2x.TabIndex = 1;
            bitmap2x.Text = "解像度200%";
            bitmap2x.UseVisualStyleBackColor = true;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(384, 245);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(62, 32);
            label12.TabIndex = 14;
            label12.Text = "倍率";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(592, 245);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(34, 32);
            label11.TabIndex = 13;
            label11.Text = "%";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(471, 243);
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
            label9.Location = new Point(592, 196);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 32);
            label9.TabIndex = 11;
            label9.Text = "pt";
            // 
            // offsetY
            // 
            offsetY.Location = new Point(471, 192);
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
            label10.Location = new Point(348, 194);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 32);
            label10.TabIndex = 9;
            label10.Text = "Offset Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(592, 145);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 32);
            label7.TabIndex = 8;
            label7.Text = "pt";
            // 
            // offsetX
            // 
            offsetX.Location = new Point(471, 141);
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
            label8.Location = new Point(348, 143);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 32);
            label8.TabIndex = 6;
            label8.Text = "Offset X";
            // 
            // paperBox
            // 
            paperBox.DropDownStyle = ComboBoxStyle.DropDownList;
            paperBox.FormattingEnabled = true;
            paperBox.Location = new Point(471, 90);
            paperBox.Name = "paperBox";
            paperBox.Size = new Size(426, 40);
            paperBox.TabIndex = 5;
            // 
            // printerBox
            // 
            printerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            printerBox.FormattingEnabled = true;
            printerBox.Location = new Point(471, 44);
            printerBox.Name = "printerBox";
            printerBox.Size = new Size(426, 40);
            printerBox.TabIndex = 3;
            printerBox.SelectedIndexChanged += PrinterBox_SelectedIndexChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += PrintDotcode;
            // 
            // dropAreaPrint
            // 
            dropAreaPrint.AllowDrop = true;
            dropAreaPrint.BorderStyle = BorderStyle.FixedSingle;
            dropAreaPrint.Controls.Add(label6);
            dropAreaPrint.Location = new Point(24, 77);
            dropAreaPrint.Margin = new Padding(6);
            dropAreaPrint.Name = "dropAreaPrint";
            dropAreaPrint.Size = new Size(277, 211);
            dropAreaPrint.TabIndex = 5;
            dropAreaPrint.DragDrop += DropAreaPrint_DragDrop;
            dropAreaPrint.DragEnter += DropAreaPrint_DragEnter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(45, 76);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(188, 64);
            label6.TabIndex = 0;
            label6.Text = "Drop file here\r\nto print dotcode\r\n";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 259);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(928, 369);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(convertMode);
            tabPage1.Controls.Add(dropAreaConvert);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(912, 315);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "変換";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // convertMode
            // 
            convertMode.DropDownStyle = ComboBoxStyle.DropDownList;
            convertMode.FormattingEnabled = true;
            convertMode.Items.AddRange(new object[] { "BIN → Raw", "BIN → Bitmap", "Raw → Bitmap" });
            convertMode.Location = new Point(24, 28);
            convertMode.Name = "convertMode";
            convertMode.Size = new Size(277, 40);
            convertMode.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(printerBox);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(printMode);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(dropAreaPrint);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(offsetY);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(paperBox);
            tabPage2.Controls.Add(offsetX);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(912, 315);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "印刷";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 47);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 16;
            label3.Text = "プリンタ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(384, 90);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 15;
            label1.Text = "用紙";
            // 
            // printMode
            // 
            printMode.DropDownStyle = ComboBoxStyle.DropDownList;
            printMode.FormattingEnabled = true;
            printMode.Items.AddRange(new object[] { "BINから変換して印刷", "Rawから変換して印刷", "Bitmapファイルを印刷" });
            printMode.Location = new Point(24, 28);
            printMode.Name = "printMode";
            printMode.Size = new Size(277, 40);
            printMode.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 647);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(loggerBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MinimumSize = new Size(637, 434);
            Name = "Form1";
            Text = "eReaderConverter";
            dropAreaConvert.ResumeLayout(false);
            dropAreaConvert.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bitmapMargin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetY).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetX).EndInit();
            dropAreaPrint.ResumeLayout(false);
            dropAreaPrint.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel dropAreaConvert;
        private Label label2;
        private TextBox loggerBox;
        private GroupBox groupBox1;
        private Label label5;
        private NumericUpDown bitmapMargin;
        private Label label4;
        private CheckBox bitmap2x;
        private ComboBox printerBox;
        private ComboBox paperBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel dropAreaPrint;
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
        private CheckBox dotBlur;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox convertMode;
        private TabPage tabPage2;
        private ComboBox printMode;
        private Label label3;
        private Label label1;
    }
}