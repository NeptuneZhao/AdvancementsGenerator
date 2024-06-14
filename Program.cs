using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancementsGenerator
{
	internal static class Program
	{
		static readonly FileStream _Config = new FileStream("config.ini", FileMode.OpenOrCreate, FileAccess.ReadWrite);

		static readonly StreamReader IReader = new StreamReader(_Config);
		static readonly StreamWriter IWriter = new StreamWriter(_Config);
		public static Dictionary<string, string> Configure = new Dictionary<string, string>()
		{
			{"language", "zh-cn" },
			{"default_path", "desktop" }
		};

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			string config = IReader.ReadToEnd().Remove(' ');
			if (config == "")
			{
				IWriter.WriteLine("language = zh-cn");
				IWriter.WriteLine("default_path = desktop");
				IWriter.Flush();
			}
			string[] config_split = config.Split('\n');
			config_split.ToList().ForEach(x => Configure.Add(x.Split('=')[0], x.Split('=')[1]));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
