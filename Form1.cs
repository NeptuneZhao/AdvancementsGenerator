using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancementsGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{

		}

		private void 打开存档ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.Configure.TryGetValue("default_path", out string value);

			folderBrowserDialog1.SelectedPath = value == "desktop" ? Environment.SpecialFolder.Desktop.ToString() : value;
			while (true)
			{
				folderBrowserDialog1.ShowDialog();
				if (!File.Exists($"{folderBrowserDialog1.SelectedPath}/level.dat"))
					MessageBox.Show("不是正确的存档。", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					Text = $"AdvancementsGenerator - {folderBrowserDialog1.SelectedPath}";
					break;
				}
			}
			// display components
			进度AToolStripMenuItem.Visible = true; // 显示进度选项卡
			
		}

		private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void 选择SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.Configure.TryGetValue("default_path", out string value);

			folderBrowserDialog1.SelectedPath = value == "desktop" ? Environment.SpecialFolder.Desktop.ToString() : value;
			while (true)
			{
				folderBrowserDialog1.ShowDialog();
				if (!File.Exists($"{folderBrowserDialog1.SelectedPath}/level.dat"))
					MessageBox.Show("不是正确的存档。", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					Text = $"AdvancementsGenerator - {folderBrowserDialog1.SelectedPath}";
					break;
				}
			}
			// display components
			进度AToolStripMenuItem.Visible = true; // 显示进度选项卡

		}
	}
}
