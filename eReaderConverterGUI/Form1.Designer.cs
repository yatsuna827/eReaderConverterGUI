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
            dropAreaBin2Raw.Location = new Point(12, 118);
            dropAreaBin2Raw.Name = "dropAreaBin2Raw";
            dropAreaBin2Raw.Size = new Size(150, 100);
            dropAreaBin2Raw.TabIndex = 0;
            dropAreaBin2Raw.DragDrop += DropAreaBin2Raw_DragDrop;
            dropAreaBin2Raw.DragEnter += DropArea_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(35, 40);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "BIN to Raw";
            // 
            // dropAreaBin2Bmp
            // 
            dropAreaBin2Bmp.AllowDrop = true;
            dropAreaBin2Bmp.BorderStyle = BorderStyle.FixedSingle;
            dropAreaBin2Bmp.Controls.Add(label2);
            dropAreaBin2Bmp.Location = new Point(12, 12);
            dropAreaBin2Bmp.Name = "dropAreaBin2Bmp";
            dropAreaBin2Bmp.Size = new Size(312, 100);
            dropAreaBin2Bmp.TabIndex = 1;
            dropAreaBin2Bmp.DragDrop += DropAreaBin2Bmp_DragDrop;
            dropAreaBin2Bmp.DragEnter += DropArea_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(112, 40);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "BIN to Bitmap";
            // 
            // dropAreaRaw2Bmp
            // 
            dropAreaRaw2Bmp.AllowDrop = true;
            dropAreaRaw2Bmp.BorderStyle = BorderStyle.FixedSingle;
            dropAreaRaw2Bmp.Controls.Add(label3);
            dropAreaRaw2Bmp.Location = new Point(174, 118);
            dropAreaRaw2Bmp.Name = "dropAreaRaw2Bmp";
            dropAreaRaw2Bmp.Size = new Size(150, 100);
            dropAreaRaw2Bmp.TabIndex = 2;
            dropAreaRaw2Bmp.DragDrop += DropAreaRaw2Bmp_DragDrop;
            dropAreaRaw2Bmp.DragEnter += DropArea_DragEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(34, 40);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 0;
            label3.Text = "Raw to Bitmap";
            // 
            // loggerBox
            // 
            loggerBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loggerBox.Location = new Point(12, 224);
            loggerBox.Multiline = true;
            loggerBox.Name = "loggerBox";
            loggerBox.ScrollBars = ScrollBars.Vertical;
            loggerBox.Size = new Size(519, 164);
            loggerBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(bitmapMargin);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(350, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 206);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 29);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 2;
            label5.Text = "pt";
            // 
            // bitmapMargin
            // 
            bitmapMargin.Location = new Point(68, 27);
            bitmapMargin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            bitmapMargin.Name = "bitmapMargin";
            bitmapMargin.Size = new Size(59, 23);
            bitmapMargin.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 29);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Margin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 400);
            Controls.Add(groupBox1);
            Controls.Add(loggerBox);
            Controls.Add(dropAreaRaw2Bmp);
            Controls.Add(dropAreaBin2Bmp);
            Controls.Add(dropAreaBin2Raw);
            MinimumSize = new Size(355, 241);
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
    }
}