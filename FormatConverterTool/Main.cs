using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FormatConverterTool
{
    public partial class Main : Form
    {
        delegate void RunTaskHandler(string from, string target);
        public Main()
        {
            InitializeComponent();
            InitParameter();
        }

        private void InitParameter()
        {
            var defaultFolder = Properties.Settings.Default.singleSavePath;
            defaultFolder = string.IsNullOrEmpty(defaultFolder) ? ConfigurationManager.AppSettings["DefaultFolder"] : defaultFolder;
            if (!Directory.Exists(defaultFolder)){
                defaultFolder = @"D:\";
            }
            if (!Directory.Exists(defaultFolder))
            {
                defaultFolder = @"E:\";
            }
            if (!Directory.Exists(defaultFolder))
            {
                defaultFolder = @"C:\";
            }
            saveConvertedFilePath.Text = defaultFolder;
            multiFileTarPathTxb.Text = Properties.Settings.Default.multiTarPath;
            multiFileSrcPathTxb.Text = Properties.Settings.Default.multiSrcPath;
            var format = ConfigurationManager.AppSettings["DefaultFormat"];
            format = format.Length == 0 ? ".mp4" : format;
            formatName.Text = format;
            multiFileFormat.Text = format;
        }
        private void browserSaveFilePathBtn_Click(object sender, EventArgs e)
        {
            saveConvertedFilePath.Text = this.selectedFolderPos(saveConvertedFilePath.Text, "请选择转换后视频保存的文件夹");
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();       //获得路径
            fileSrcPath.Text = path;
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void startToConvertBtn_Click(object sender, EventArgs e)
        {
            var savePathFolder = saveConvertedFilePath.Text;
            if(savePathFolder.Length == 0)
            {
                MessageBox.Show("请选择视频转换后的保存路径；", "操作提示：",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saveConvertedFilePath.Focus();
                return;
            }
            if (!Directory.Exists(savePathFolder))
            {
                Directory.CreateDirectory(savePathFolder);
            }
            var srcFilePath = fileSrcPath.Text;
            if (srcFilePath.Length == 0)
            {
                MessageBox.Show("请将您要转换的文件拖拽到此处；", "操作提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var file = new FileInfo(srcFilePath);
            if(false == file.Exists)
            {
                MessageBox.Show("您要转换的文件不存在，请重新拖拽文件。", "操作提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var format = formatName.Text;
            Properties.Settings.Default.singleSavePath = savePathFolder;
            var tarFilePath = Path.Combine(savePathFolder, file.Name.Replace(file.Extension, format));
            if (File.Exists(tarFilePath))
            {
                var confirmBox = MessageBox.Show(tarFilePath + "文件已存在，是否需要覆盖？\n确认（OK）表示覆盖；\n取消（Cancel）表示不覆盖；", "文件存在提醒", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(confirmBox == DialogResult.Cancel)
                {
                    tarFilePath = Path.Combine(savePathFolder, file.Name.Replace(file.Extension,"_")+Guid.NewGuid().ToString().Replace("-", "")+ format);
                }
                else
                {
                    try
                    {
                        File.Delete(tarFilePath);
                    }
                    catch (FieldAccessException faEx)
                    {
                        MessageBox.Show("转换异常：" + Environment.NewLine + faEx.Message + Environment.NewLine + faEx.StackTrace, "转换错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            RunTaskHandler handler = new RunTaskHandler(this.SingleRun);
            this.Invoke(handler, new object[] { srcFilePath, tarFilePath });
        }

        private string selectedFolderPos(string defaultPath, string title)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = title;
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = defaultPath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                defaultPath = dialog.SelectedPath;
            }
            return defaultPath;
        }

        private void multiFileSrcPathBtn_Click(object sender, EventArgs e)
        {
            multiFileSrcPathTxb.Text = this.selectedFolderPos(multiFileSrcPathTxb.Text, "请选择转换前文件夹位置");
        }

        private void multiFileTarPathBtn_Click(object sender, EventArgs e)
        {
            multiFileTarPathTxb.Text = this.selectedFolderPos(multiFileTarPathTxb.Text, "请选择转换后视频保存位置");
        }

        private void multiConvertBtn_Click(object sender, EventArgs e)
        {
            if(multiFileSrcPathTxb.Text.Length == 0)
            {
                MessageBox.Show("请选择您要转换的文件夹；", "操作提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (multiFileTarPathTxb.Text.Length == 0)
            {
                MessageBox.Show("请选择转换后视频保存的位置；", "操作提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(multiFileTarPathTxb.Text))
            {
                Directory.CreateDirectory(multiFileTarPathTxb.Text);
            }
            convertResult.Text = "";
            RunTaskHandler handler = new RunTaskHandler(this.MultiRun);
            this.Invoke(handler, new object[] { multiFileSrcPathTxb.Text, multiFileTarPathTxb.Text });
        }

        #region Delegate
        private ProcessStartInfo NewProcessInfo()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = true;
            startInfo.FileName = @".\lib\ffmpeg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            return startInfo;
        }
        private void SingleRun(string from, string target)
        {
            try
            {
                saveConvertedFilePath.Enabled = false;
                browserSaveFilePathBtn.Enabled = false;
                startToConvertBtn.Enabled = false;
                startToConvertBtn.Text = "正在转换中...";
                ProcessStartInfo startInfo = NewProcessInfo();
                startInfo.Arguments = "-i \"" + from + "\" -c copy \"" + target + "\"";

                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    MessageBox.Show("转换成功", "操作提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(target.Substring(0,target.LastIndexOf(@"\")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("转换异常：" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace, "转换错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                saveConvertedFilePath.Enabled = true;
                browserSaveFilePathBtn.Enabled = true;
                startToConvertBtn.Enabled = true;
                startToConvertBtn.Text = "开始转换";
            }
        }
        private void MultiRun(string from, string target)
        {
            Properties.Settings.Default.multiSrcPath = from;
            Properties.Settings.Default.multiTarPath = target;
            try
            {
                multiFileSrcPathTxb.Enabled = false;
                multiFileSrcPathBtn.Enabled = false;
                multiFileTarPathBtn.Enabled = false;
                multiFileTarPathTxb.Enabled = false;
                multiConvertBtn.Enabled = false;
                multiConvertBtn.Text = "正在转换中...";

                var list = Directory.GetFiles(from, "*.flv", SearchOption.AllDirectories);
                StringBuilder result = new StringBuilder();
                var format = multiFileFormat.Text;
                ProcessStartInfo startInfo = NewProcessInfo();
                foreach (var file in list)
                {
                    var _file = new FileInfo(file);
                    var tarFilePath = Path.Combine(target, _file.Name.Replace(_file.Extension, format));
                    if (File.Exists(tarFilePath))
                    {
                        tarFilePath = Path.Combine(target, _file.Name.Replace(_file.Extension, "_") + Guid.NewGuid().ToString().Replace("-", "") + format);
                    }
                    startInfo.Arguments = "-i \"" + file + "\" -c copy \"" + tarFilePath + "\"";
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                        result.Append($"文件转换成功：{tarFilePath}{Environment.NewLine}");
                        convertResult.Text = result.ToString();
                    }
                }
                Process.Start(target);
                MessageBox.Show("转换成功", "操作提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("转换异常：" + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace, "转换错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                multiFileSrcPathTxb.Enabled = true;
                multiFileSrcPathBtn.Enabled = true;
                multiFileTarPathBtn.Enabled = true;
                multiFileTarPathTxb.Enabled = true;
                multiConvertBtn.Enabled = true;
                multiConvertBtn.Text = "开始转换";
            }
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {
            var weibo = "@innerpeaceGuan";
            Clipboard.SetDataObject(weibo);
            MessageBox.Show($"已将{weibo}复制到剪贴板", "操作提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
