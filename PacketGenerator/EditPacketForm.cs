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
	/// パケット編集フォーム
	/// </summary>
	public partial class EditPacketForm : Form
	{
		/// <summary>
		/// データ
		/// </summary>
		public PacketData Data { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public EditPacketForm()
		{
			InitializeComponent();
			Data = new PacketData();
			MemberListBox.DisplayMember = "Name";
		}

		// ＯＫボタンが押された。
		private void OKButton_Click(object sender, EventArgs e)
		{
			if(PacketNameTextBox.Text == "")
			{
				MessageBox.Show("パケット名を入力して下さい。");
				return;
			}

			Data.Name = PacketNameTextBox.Text;

			if(PacketRadioButton.Checked && PacketIDTextBox.Text == "")
			{
				MessageBox.Show("パケットＩＤを入力して下さい。");
				return;
			}

			Data.IsPacket = PacketRadioButton.Checked;
			if(Data.IsPacket)
			{
				Data.ID = PacketIDTextBox.Text;
			}

			foreach(var Member in MemberListBox.Items)
			{
				Data.Member.Add((PacketMemberData) Member);
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		// キャンセルボタンが押された。
		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		// 「パケット」のラジオボタンのチェック状態が変更された。
		private void PacketRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			PacketIDTextBox.Enabled = PacketRadioButton.Checked;
		}

		// メンバリストボックスの選択状態が変更された。
		private void MemberListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool bSelected = (MemberListBox.SelectedIndex != -1);

			MemberNameTextBox.Enabled = bSelected;
			MemberTypeComboBox.Enabled = bSelected;
			UpdateMemberButton.Enabled = bSelected;
			RemoveMemberButton.Enabled = bSelected;

			if (!bSelected) { return; }

			var Item = (PacketMemberData)MemberListBox.SelectedItem;
			MemberNameTextBox.Text = Item.Name;
			MemberTypeComboBox.Text = Item.Type;
		}

		// メンバ追加ボタンが押された。
		private void AddMemberButton_Click(object sender, EventArgs e)
		{
			PacketMemberData Member = new PacketMemberData();
			Member.Name = "NewMember";
			Member.Type = "int";
			MemberListBox.Items.Add(Member);
		}

		// メンバ更新ボタンが押された。
		private void UpdateMemberButton_Click(object sender, EventArgs e)
		{
			var Item = (PacketMemberData)MemberListBox.SelectedItem;
			Item.Name = MemberNameTextBox.Text;
			Item.Type = MemberTypeComboBox.Text;
			MemberListBox.Items[MemberListBox.SelectedIndex] = Item;
		}

		// メンバ削除ボタンが押された。
		private void RemoveMemberButton_Click(object sender, EventArgs e)
		{
			var Item = (PacketMemberData) MemberListBox.SelectedItem;
			MemberListBox.Items.Remove(Item);
		}
	}
}
