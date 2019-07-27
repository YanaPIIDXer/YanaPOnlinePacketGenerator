using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PacketGenerator
{
	/// <summary>
	/// メインフォーム
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		// フォームが読み込まれた
		private void MainForm_Load(object sender, EventArgs e)
		{
			// プロジェクトデータを放り込むディレクトリが生成されていなければ生成する。
			// 初回起動時の処理。
			Directory.CreateDirectory(Config.ProjectRootDir);
		}
	}
}
