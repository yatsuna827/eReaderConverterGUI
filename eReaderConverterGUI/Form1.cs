using eReaderConverter;

namespace eReaderConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                        var bmp = File.ReadAllBytes(filename).Bin2Bmp((int)bitmapMargin.Value);
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
                        var bmp = File.ReadAllBytes(filename).Raw2Bmp((int)bitmapMargin.Value);
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
    }
}
