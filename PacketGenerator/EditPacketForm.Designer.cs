namespace PacketGenerator
{
	partial class EditPacketForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PacketRadioButton = new System.Windows.Forms.RadioButton();
			this.StructRadioButton = new System.Windows.Forms.RadioButton();
			this.PacketNameTextBox = new System.Windows.Forms.TextBox();
			this.PacketIDTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.AddMemberButton = new System.Windows.Forms.Button();
			this.RemoveMemberButton = new System.Windows.Forms.Button();
			this.UpdateMemberButton = new System.Windows.Forms.Button();
			this.MemberListBox = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.MemberNameTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.MemberTypeComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(215, 429);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(164, 48);
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "ＯＫ";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(661, 429);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(164, 48);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "キャンセル";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "パケット名";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "タイプ";
			// 
			// PacketRadioButton
			// 
			this.PacketRadioButton.AutoSize = true;
			this.PacketRadioButton.Checked = true;
			this.PacketRadioButton.Location = new System.Drawing.Point(204, 61);
			this.PacketRadioButton.Name = "PacketRadioButton";
			this.PacketRadioButton.Size = new System.Drawing.Size(72, 19);
			this.PacketRadioButton.TabIndex = 4;
			this.PacketRadioButton.TabStop = true;
			this.PacketRadioButton.Text = "パケット";
			this.PacketRadioButton.UseVisualStyleBackColor = true;
			this.PacketRadioButton.CheckedChanged += new System.EventHandler(this.PacketRadioButton_CheckedChanged);
			// 
			// StructRadioButton
			// 
			this.StructRadioButton.AutoSize = true;
			this.StructRadioButton.Location = new System.Drawing.Point(336, 61);
			this.StructRadioButton.Name = "StructRadioButton";
			this.StructRadioButton.Size = new System.Drawing.Size(73, 19);
			this.StructRadioButton.TabIndex = 5;
			this.StructRadioButton.Text = "構造体";
			this.StructRadioButton.UseVisualStyleBackColor = true;
			// 
			// PacketNameTextBox
			// 
			this.PacketNameTextBox.Location = new System.Drawing.Point(204, 25);
			this.PacketNameTextBox.Name = "PacketNameTextBox";
			this.PacketNameTextBox.Size = new System.Drawing.Size(346, 22);
			this.PacketNameTextBox.TabIndex = 6;
			// 
			// PacketIDTextBox
			// 
			this.PacketIDTextBox.Location = new System.Drawing.Point(204, 101);
			this.PacketIDTextBox.Name = "PacketIDTextBox";
			this.PacketIDTextBox.Size = new System.Drawing.Size(346, 22);
			this.PacketIDTextBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "パケットID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(288, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "メンバ";
			// 
			// AddMemberButton
			// 
			this.AddMemberButton.Location = new System.Drawing.Point(382, 344);
			this.AddMemberButton.Name = "AddMemberButton";
			this.AddMemberButton.Size = new System.Drawing.Size(145, 35);
			this.AddMemberButton.TabIndex = 11;
			this.AddMemberButton.Text = "追加";
			this.AddMemberButton.UseVisualStyleBackColor = true;
			this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
			// 
			// RemoveMemberButton
			// 
			this.RemoveMemberButton.Enabled = false;
			this.RemoveMemberButton.Location = new System.Drawing.Point(748, 344);
			this.RemoveMemberButton.Name = "RemoveMemberButton";
			this.RemoveMemberButton.Size = new System.Drawing.Size(145, 35);
			this.RemoveMemberButton.TabIndex = 12;
			this.RemoveMemberButton.Text = "削除";
			this.RemoveMemberButton.UseVisualStyleBackColor = true;
			this.RemoveMemberButton.Click += new System.EventHandler(this.RemoveMemberButton_Click);
			// 
			// UpdateMemberButton
			// 
			this.UpdateMemberButton.Enabled = false;
			this.UpdateMemberButton.Location = new System.Drawing.Point(570, 344);
			this.UpdateMemberButton.Name = "UpdateMemberButton";
			this.UpdateMemberButton.Size = new System.Drawing.Size(145, 35);
			this.UpdateMemberButton.TabIndex = 13;
			this.UpdateMemberButton.Text = "更新";
			this.UpdateMemberButton.UseVisualStyleBackColor = true;
			this.UpdateMemberButton.Click += new System.EventHandler(this.UpdateMemberButton_Click);
			// 
			// MemberListBox
			// 
			this.MemberListBox.FormattingEnabled = true;
			this.MemberListBox.ItemHeight = 15;
			this.MemberListBox.Location = new System.Drawing.Point(90, 180);
			this.MemberListBox.Name = "MemberListBox";
			this.MemberListBox.Size = new System.Drawing.Size(239, 199);
			this.MemberListBox.TabIndex = 10;
			this.MemberListBox.SelectedIndexChanged += new System.EventHandler(this.MemberListBox_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(435, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 15);
			this.label5.TabIndex = 14;
			this.label5.Text = "メンバ名";
			// 
			// MemberNameTextBox
			// 
			this.MemberNameTextBox.Enabled = false;
			this.MemberNameTextBox.Location = new System.Drawing.Point(542, 222);
			this.MemberNameTextBox.Name = "MemberNameTextBox";
			this.MemberNameTextBox.Size = new System.Drawing.Size(217, 22);
			this.MemberNameTextBox.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(435, 272);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "データ型";
			// 
			// MemberTypeComboBox
			// 
			this.MemberTypeComboBox.Enabled = false;
			this.MemberTypeComboBox.FormattingEnabled = true;
			this.MemberTypeComboBox.Items.AddRange(new object[] {
            "int",
            "unsigned int",
            "short",
            "unsigned short",
            "char",
            "unsigned char",
            "string"});
			this.MemberTypeComboBox.Location = new System.Drawing.Point(542, 272);
			this.MemberTypeComboBox.Name = "MemberTypeComboBox";
			this.MemberTypeComboBox.Size = new System.Drawing.Size(217, 23);
			this.MemberTypeComboBox.TabIndex = 17;
			// 
			// EditPacketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 504);
			this.Controls.Add(this.MemberTypeComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.MemberNameTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.UpdateMemberButton);
			this.Controls.Add(this.RemoveMemberButton);
			this.Controls.Add(this.AddMemberButton);
			this.Controls.Add(this.MemberListBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.PacketIDTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PacketNameTextBox);
			this.Controls.Add(this.StructRadioButton);
			this.Controls.Add(this.PacketRadioButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditPacketForm";
			this.Text = "パケット編集";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton PacketRadioButton;
		private System.Windows.Forms.RadioButton StructRadioButton;
		private System.Windows.Forms.TextBox PacketNameTextBox;
		private System.Windows.Forms.TextBox PacketIDTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button AddMemberButton;
		private System.Windows.Forms.Button RemoveMemberButton;
		private System.Windows.Forms.Button UpdateMemberButton;
		private System.Windows.Forms.ListBox MemberListBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox MemberNameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox MemberTypeComboBox;
	}
}