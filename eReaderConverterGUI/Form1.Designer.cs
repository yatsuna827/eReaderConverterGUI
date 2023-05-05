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
            label5 = new Label();
            bitmapMargin = new NumericUpDown();
            label4 = new Label();
            checkBox1 = new CheckBox();
            dropAreaBin2Raw.SuspendLayout();
            dropAreaBin2Bmp.SuspendLayout();
            dropAreaRaw2Bmp.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bitmapMargin).BeginInit();
            SuspendLayout();
            // 
            // dropAreaBin2Raw
            // 
            dropAreaBin2Raw.AllowDrop = true;
            dropAreaBin2Raw.BorderStyle = BorderStyle.FixedSingle;
            dropAreaBin2Raw.Controls.Add(label1);
            dropAreaBin2Raw.Location = new Point(22, 252);
            dropAreaBin2Raw.Margin = new Padding(6, 6, 6, 6);
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
            dropAreaBin2Bmp.Margin = new Padding(6, 6, 6, 6);
            dropAreaBin2Bmp.Name = "dropAreaBin2Bmp";
            dropAreaBin2Bmp.Size = new Size(578, 211);
            dropAreaBin2Bmp.TabIndex = 1;
            dropAreaBin2Bmp.DragDrop += DropAreaBin2Bmp_DragDrop;
            dropAreaBin2Bmp.DragEnter += DropArea_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(208, 85);
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
            dropAreaRaw2Bmp.Location = new Point(323, 252);
            dropAreaRaw2Bmp.Margin = new Padding(6, 6, 6, 6);
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
            loggerBox.Margin = new Padding(6, 6, 6, 6);
            loggerBox.Multiline = true;
            loggerBox.Name = "loggerBox";
            loggerBox.ScrollBars = ScrollBars.Vertical;
            loggerBox.Size = new Size(960, 345);
            loggerBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(bitmapMargin);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(650, 26);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(336, 439);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
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
            bitmapMargin.Margin = new Padding(6, 6, 6, 6);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 853);
            Controls.Add(groupBox1);
            Controls.Add(loggerBox);
            Controls.Add(dropAreaRaw2Bmp);
            Controls.Add(dropAreaBin2Bmp);
            Controls.Add(dropAreaBin2Raw);
            Margin = new Padding(6, 6, 6, 6);
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
            ((System.ComponentModel.ISupportInitialize)bitmapMargin).EndInit();
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
    }
}