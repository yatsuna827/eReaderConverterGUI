using eReaderConverter;
using System.Drawing.Printing;

namespace eReaderConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 型が StringCollection なのでToArrayすらできない。地獄か？
            foreach (var name in PrinterSettings.InstalledPrinters)
                comboBox1.Items.Add(name);

            comboBox1.SelectedIndex = 0;

        }

        private void Log(string msg) => this.loggerBox.AppendText(msg + Environment.NewLine);
        private void LogError(string msg) => this.loggerBox.AppendText($"Error: {msg}{Environment.NewLine}");
        private void LogSeparator() => this.loggerBox.AppendText("------------" + Environment.NewLine);

        private void DropArea_DragEnter(object sender, DragEventArgs e)
        {
            if (e is null) return;

            e.Effect = e.Data is not null && e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }
        private void PrintDropArea_DragEnter(object sender, DragEventArgs e)
        {
            if (e is null) return;

            e.Effect = e.Data is not null && e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }

        private void DropAreaBin2Raw_DragDrop(object sender, DragEventArgs e)
        {
            if (e is null) return;

            if (e.Data?.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var filename in files)
                {
                    Log(filename);
                    try
                    {
                        var raw = File.ReadAllBytes(filename).Bin2Raw();
                        var newFilename = Path.ChangeExtension(filename, "raw");
                        File.WriteAllBytes(newFilename, raw);
                        Log($"Save as {newFilename}");
                    }
                    catch (Exception err)
                    {
                        LogError(err.Message);
                    }
                }
            }

            LogSeparator();
        }

        private void DropAreaBin2Bmp_DragDrop(object sender, DragEventArgs e)
        {
            if (e is null) return;

            if (e.Data?.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var filename in files)
                {
                    Log(filename);
                    try
                    {
                        using var bmp = File.ReadAllBytes(filename).Bin2Bmp((int)bitmapMargin.Value, checkBox1.Checked);
                        var newFilename = Path.ChangeExtension(filename, "bmp");
                        bmp.Save(newFilename);
                        Log($"Save as {newFilename}");
                    }
                    catch (Exception err)
                    {
                        LogError(err.Message);
                    }
                }
            }

            LogSeparator();
        }

        private void DropAreaRaw2Bmp_DragDrop(object sender, DragEventArgs e)
        {
            if (e is null) return;

            if (e.Data?.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var filename in files)
                {
                    Log(filename);
                    try
                    {
                        using var bmp = File.ReadAllBytes(filename).Raw2Bmp((int)bitmapMargin.Value, checkBox1.Checked);
                        var newFilename = Path.ChangeExtension(filename, "bmp");
                        bmp.Save(newFilename);
                        Log($"Save as {newFilename}");
                    }
                    catch (Exception err)
                    {
                        LogError(err.Message);
                    }
                }
            }

            LogSeparator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //印刷を開始する
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (bitmapFilename is null) return;

            //画像を読み込む
            using var img = Image.FromFile(bitmapFilename);
            //画像を描画する
            e.Graphics!.DrawImage(img, (int)offsetX.Value, (int)offsetY.Value, (int)(img.Width * (double)numericUpDown1.Value / 100), (int)(img.Height * (double)numericUpDown1.Value / 100));
            //次のページがないことを通知する
            e.HasMorePages = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = comboBox1.Text;
            foreach (PaperSize ps in printDocument1.PrinterSettings.PaperSizes)
            {
                comboBox2.Items.Add(ps.PaperName);
            }

            if (comboBox2.Items.Count > 0 && comboBox2.SelectedIndex < 0) comboBox2.SelectedIndex = 0;
        }

        private string? bitmapFilename;

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e is null) return;

            if (e.Data?.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                bitmapFilename = files.First();
                foreach (var filename in files)
                {
                    Log(filename);
                    try
                    {
                        //印刷を開始する
                        printDocument1.Print();
                    }
                    catch (Exception err)
                    {
                        LogError(err.Message);
                    }
                }
            }
        }
    }
}
