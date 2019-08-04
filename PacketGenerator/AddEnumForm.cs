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
	/// パケットＩＤenum追加フォーム
	/// </summary>
	public partial class AddEnumForm : Form
	{
		/// <summary>
		/// enum名
		/// </summary>
		public string EnumName { get; private set; }

		/// <summary>
		/// 出力先１
		/// </summary>
		public EnumOutputData Output1 { get; private set; }

		/// <summary>
		/// 出力先２
		/// </summary>
		public EnumOutputData Output2 { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public AddEnumForm()
		{
			InitializeComponent();
			EnumName = "";
			Output1 = null;
			Output2 = null;
		}

		// OKボタンが押された。
		private void OKButton_Click(object sender, EventArgs e)
		{
			if(EnumNameTextBox.Text == "")
			{
				MessageBox.Show("enum名を入力して下さい。");
				return;
			}

			EnumName = EnumNameTextBox.Text;

			if(Output1PathTextBox.Text == "")
			{
				MessageBox.Show("出力先１のパスを指定して下さい。");
				return;
			}

			Output1 = new EnumOutputData(Output1PathTextBox.Text, Output1LanguageList.Text);

			if(Output2PathTextBox.Text == "")
			{
				MessageBox.Show("出力先２のパスを指定して下さい。");
				return;
			}

			Output2 = new EnumOutputData(Output2PathTextBox.Text, Output2LanguageList.Text);

			DialogResult = DialogResult.OK;
			Close();
		}

		// キャンセルボタンが押された。
		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		// パス１選択ボタンが押された。
		private void Path1SelectButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog Dialog = new FolderBrowserDialog();
			var Result = Dialog.ShowDialog();
			if(Result != DialogResult.OK) { return; }
			Uri CurrentUri = new Uri(Directory.GetCurrentDirectory());
			Uri SelectedUri = new Uri(Dialog.SelectedPath);
			string RelativePath = CurrentUri.MakeRelativeUri(SelectedUri).ToString().Replace("/", "\\");
			Output1PathTextBox.Text = RelativePath;
		}

		// パス２選択ボタンが押された。
		private void Path2SelectButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog Dialog = new FolderBrowserDialog();
			var Result = Dialog.ShowDialog();
			if (Result != DialogResult.OK) { return; }
			Uri CurrentUri = new Uri(Directory.GetCurrentDirectory());
			Uri SelectedUri = new Uri(Dialog.SelectedPath);
			string RelativePath = CurrentUri.MakeRelativeUri(SelectedUri).ToString().Replace("/", "\\");
			Output2PathTextBox.Text = RelativePath;
		}
	}
}
