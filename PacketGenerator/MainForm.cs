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
		/// 現在選択されているプロジェクト
		/// </summary>
		private Project CurrentProject = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			ReloadProjectList();
		}

		// フォームが読み込まれた
		private void MainForm_Load(object sender, EventArgs e)
		{
			// プロジェクトデータを放り込むディレクトリが生成されていなければ生成する。
			// 初回起動時の処理。
			Directory.CreateDirectory(Config.ProjectRootDir);
		}

		// プロジェクト新規作成ボタンが押された
		private void CreateProjectButton_Click(object sender, EventArgs e)
		{
			CreateProjectDialog Dialog = new CreateProjectDialog();
			var Result = Dialog.ShowDialog();
			if(Result != DialogResult.OK) { return; }

			if(Project.IsValid(Dialog.ProjectName))
			{
				MessageBox.Show(Dialog.ProjectName + "は既に存在します。");
				return;
			}

			Project.Create(Dialog.ProjectName);
			ReloadProjectList();

			MessageBox.Show("プロジェクトを作成しました。");
		}

		/// <summary>
		/// プロジェクトリストのリロード
		/// </summary>
		private void ReloadProjectList()
		{
			ProjectListBox.Items.Clear();

			var Projects = Directory.GetDirectories(Config.ProjectRootDir, "*", SearchOption.TopDirectoryOnly);
			foreach(var ProjectName in Projects)
			{
				var Name = Path.GetFileNameWithoutExtension(ProjectName);
				if (!Project.IsValid(Name)) { continue; }
				ProjectListBox.Items.Add(Name);
			}
		}

		// プロジェクトが選択された。
		private void ProjectListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(ProjectListBox.SelectedIndex == -1)
			{
				ProjectGroup.Enabled = false;
				return;
			}
			ProjectGroup.Enabled = true;

			try
			{
				CurrentProject = new Project(ProjectListBox.SelectedItem.ToString());
			}
			catch(Exception Ex)
			{
				MessageBox.Show("プロジェクトの読み込みに失敗しました。\n" + Ex.Message);
				CurrentProject = null;
			}
		}

		// パケットＩＤenum追加ボタンが押された。
		private void AddPacketIDEnumButton_Click(object sender, EventArgs e)
		{
			AddEnumForm Dialog = new AddEnumForm();
			var Result = Dialog.ShowDialog();
			if(Result != DialogResult.OK) { return; }

			if(!CurrentProject.AddPacketIDEnum(Dialog.EnumName, Dialog.Output1, Dialog.Output2))
			{
				MessageBox.Show("既に登録されているenum名です。");
				return;
			}

			MessageBox.Show("新規enumを追加しました。");
		}
	}
}
