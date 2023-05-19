using eReaderConverter;
using System.Drawing.Printing;

namespace eReaderConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            convertMode.SelectedIndex = 2;
            printMode.SelectedIndex = 1;
        }

        private string? bitmapFilename;

        private void Log(string msg) => this.loggerBox.AppendText(msg + Environment.NewLine);
        private void LogError(string msg) => this.loggerBox.AppendText($"Error: {msg}{Environment.NewLine}");
        private void LogSeparator() => this.loggerBox.AppendText("------------" + Environment.NewLine);

        private void DropAreaConvert_DragEnter(object sender, DragEventArgs e)
        {
            if (e is null) return;

            e.Effect = e.Data is not null && e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }
        private void DropAreaPrint_DragEnter(object sender, DragEventArgs e)
        {
            if (e is null) return;

            e.Effect = e.Data is not null && e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }

        private void DropAreaConvert_DragDrop(object sender, DragEventArgs e)
        {
            if (e is null) return;

            if (e.Data?.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var filename in files)
                {
                    Log(filename);
                    try
                    {
                        var newFilename = Convert(filename);
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
        private string? Convert(string filename) => convertMode.SelectedIndex switch
        {
            0 => Bin2Raw(filename),
            1 => Bin2Bitmap(filename),
            2 => Raw2Bitmap(filename),
            _ => null,
        };
        private string Bin2Raw(string filename)
        {
            var raw = File.ReadAllBytes(filename).Bin2Raw();
            var newFilename = Path.ChangeExtension(filename, "raw");
            File.WriteAllBytes(newFilename, raw);

            return newFilename;
        }
        private string Bin2Bitmap(string filename)
        {
            using var bmp = File.ReadAllBytes(filename).Bin2Bmp((int)bitmapMargin.Value, bitmap2x.Checked);
            var newFilename = Path.ChangeExtension(filename, "bmp");
            bmp.Save(newFilename);

            return newFilename;
        }
        private string Raw2Bitmap(string filename)
        {
            using var bmp = File.ReadAllBytes(filename).Raw2Bmp((int)bitmapMargin.Value, bitmap2x.Checked, dotBlur.Checked);
            var newFilename = Path.ChangeExtension(filename, "bmp");
            bmp.Save(newFilename);

            return newFilename;
        }

        const string TEMP_BITMAP_FILENAME = "./__tmp__.bmp";
        private void DropAreaPrint_DragDrop(object sender, DragEventArgs e)
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
                    finally
                    {
                        if (File.Exists(TEMP_BITMAP_FILENAME))
                            File.Delete(TEMP_BITMAP_FILENAME);
                    }
                }
            }
        }
        private void PrintDotcode(object sender, PrintPageEventArgs e)
        {
            if (bitmapFilename is null) return;

            //画像を読み込む
            using var img = GetImage(bitmapFilename);

            img.RotateFlip(RotateFlipType.Rotate180FlipNone);

            var w = (int)(img.Width * (double)rate.Value / 100);
            var h = (int)(img.Height * (double)rate.Value / 100);

            e.Graphics!.PageUnit = GraphicsUnit.Document;

            //画像を描画する
            e.Graphics!.DrawImage(img, (int)offsetX.Value, (int)offsetY.Value, w, h);
            //次のページがないことを通知する
            e.HasMorePages = false;
        }
        private Image GetImage(string filename)
        {
            if (printMode.SelectedIndex == 0)
            {
                var temp = File.ReadAllBytes(filename).Bin2Raw().Raw2Bmp((int)bitmapMargin.Value, bitmap2x.Checked, dotBlur.Checked);
                temp.Save(TEMP_BITMAP_FILENAME);

                return Image.FromFile(TEMP_BITMAP_FILENAME);
            }

            if (printMode.SelectedIndex == 1)
            {
                var temp = File.ReadAllBytes(filename).Raw2Bmp((int)bitmapMargin.Value, bitmap2x.Checked, dotBlur.Checked);
                temp.Save(TEMP_BITMAP_FILENAME);

                return Image.FromFile(TEMP_BITMAP_FILENAME);
            }

            if (printMode.SelectedIndex == 2)
                return Image.FromFile(filename);

            throw new Exception();
        }

        private void PrinterSettingButton_Click(object sender, EventArgs e)
        {
            //PrintDialogクラスの作成
            var dialog = new PrintDialog
            {
                //PrintDocumentを指定
                Document = printDocument1
            };

            dialog.ShowDialog();
        }
    }
}
