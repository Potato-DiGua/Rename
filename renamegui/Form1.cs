using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renamegui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void choose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            string folderPath = dialog.SelectedPath.Trim();
            theFolder = new DirectoryInfo(folderPath);
            if (theFolder.Exists)
            {
                //操作
                //MessageBox.Show(theFolder.FullName);
                FileInfo[] files = theFolder.GetFiles();
                if (files.Length != 0)
                {
                    //MessageBox.Show("test");
                    if (fileList.Items.Count != 0)
                    {
                        fileList.Items.Clear();
                    }
                    int length = files.Length;
                    for (int i = 0; i < length; i++)
                    {
                        fileList.Items.Add(files[i].Name);
                    }
                    fileList.Update();
                    pathLable.Text = theFolder.FullName;
                }

            }

        }

        private void FullSelectcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < fileList.Items.Count; i++)
            {
                if (fullSelectcheckBox.Checked == true)
                {
                    fileList.SetItemChecked(i, true);
                }
                else
                {
                    fileList.SetItemChecked(i, false);
                }
            }
        }

        private void ScreenBtn_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str != null && str != string.Empty)
            {
                fileList.Items.Clear();
                FileInfo[] files = theFolder.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (/*file.Name.Contains(str)*/Regex.IsMatch(file.Name, str))//正则筛选
                        fileList.Items.Add(file.Name);
                }
            }
            if (str == null || str == string.Empty || fileList.Items.Count == 0)
            {
                FileInfo[] files = theFolder.GetFiles();
                foreach (FileInfo file in files)
                {
                    fileList.Items.Add(file.Name);
                }
            }
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int count = 0;
            int digit=getDigit();
            if(digit==-2)
            {
                MessageBox.Show("错误：位数输入了非数字字符");
            }

            if (str != null && str != string.Empty)
            {
                for (int i = 0; i < fileList.Items.Count; i++)
                {
                    if (fileList.GetItemChecked(i))
                    {
                        String newname = fileList.Items[i].ToString() + "--->" + str.Replace("{id}", handleNum(++count, digit));
                        fileList.Items.RemoveAt(i);
                        fileList.Items.Insert(i, newname);
                        fileList.SetItemChecked(i, true);
                    }
                }
                fileList.Update();
            }
        }
        private string handleNum(int num, int digit)
        {
            if (digit == -1)
                return num.ToString();

            int loop = digit - num.ToString().Length;
            String str = num.ToString();
            for (int i = 0; i < loop; i++)
            {
                str = "0" + str;
            }
            return str;
        }
        private int getDigit()
        {
            int digit;
            if (numtextBox.Text == null || numtextBox.Text == string.Empty)
                digit = -1;
            else if (Regex.IsMatch(numtextBox.Text, "[^0-9]"))
            {
                digit = -2;//错误
            }
            else
                digit = int.Parse(numtextBox.Text);
            return digit;
        }
        private void RenameBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要重命名吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            String str = textBox1.Text;
            int count = 0;

            int digit = getDigit();
            if (digit == -2)
            {
                MessageBox.Show("错误：位数输入了非数字字符");
            }


            if (str != null && str != string.Empty)
            {
                for (int i = 0; i < fileList.Items.Count; i++)
                {
                    if (fileList.GetItemChecked(i))
                    {
                        String newpath = theFolder.FullName + Path.DirectorySeparatorChar + str.Replace("{id}", handleNum(++count, digit));
                        String oldpath = theFolder.FullName + Path.DirectorySeparatorChar + Regex.Split(fileList.Items[i].ToString(), "--->")[0];
                        //MessageBox.Show(oldpath);
                        FileInfo file = new FileInfo(oldpath);
                        file.MoveTo(newpath);
                    }
                }
                FileInfo[] files = theFolder.GetFiles();
                fileList.Items.Clear();
                int length = files.Length;
                for (int i = 0; i < length; i++)
                {
                    fileList.Items.Add(files[i].Name);
                }
                fileList.Update();
                fullSelectcheckBox.Checked = false;
            }

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用教程\n首先点击浏览找到想要重命名的目录，然后在第一个输入框内输入批量重命名的格式（特殊字符{id}会被替换为序号，需用英文半角输入）,第二个位数输入框会将序号补0至所需位数,为空则不补全,然后点击预览查看是否符合期望情况，最后点击重命名即可完成批量重命名。\n筛选会根据第一个输入框来匹配文件名，可以用来选择特定类型的文件（支持正则表达式）");
        }
    }
}
