using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacketGenerator
{
	/// <summary>
	/// プロジェクト新規作成ダイアログ
	/// </summary>
	public partial class CreateProjectDialog : Form
	{
		/// <summary>
		/// プロジェクト名
		/// </summary>
		public string ProjectName { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CreateProjectDialog()
		{
			InitializeComponent();
			ProjectName = "";
		}

		// OKボタンが押された
		private void OKButton_Click(object sender, EventArgs e)
		{
			var Name = ProjectNameTextBox.Text;
			if(string.IsNullOrEmpty(Name))
			{
				MessageBox.Show("プロジェクト名を入力して下さい。");
				return;
			}

			ProjectName = Name;
			DialogResult = DialogResult.OK;
			Close();
		}

		// キャンセルボタンが押された
		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
