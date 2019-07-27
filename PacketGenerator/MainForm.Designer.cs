﻿namespace PacketGenerator
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.ProjectListBox = new System.Windows.Forms.ListBox();
			this.CreateProjectButton = new System.Windows.Forms.Button();
			this.AddPacketIDEnumButton = new System.Windows.Forms.Button();
			this.PacketIDEnumListBox = new System.Windows.Forms.ListBox();
			this.ProjectGroup = new System.Windows.Forms.GroupBox();
			this.ProjectGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// ProjectListBox
			// 
			this.ProjectListBox.FormattingEnabled = true;
			this.ProjectListBox.ItemHeight = 15;
			this.ProjectListBox.Location = new System.Drawing.Point(46, 23);
			this.ProjectListBox.Name = "ProjectListBox";
			this.ProjectListBox.Size = new System.Drawing.Size(277, 364);
			this.ProjectListBox.TabIndex = 0;
			this.ProjectListBox.SelectedIndexChanged += new System.EventHandler(this.ProjectListBox_SelectedIndexChanged);
			// 
			// CreateProjectButton
			// 
			this.CreateProjectButton.Location = new System.Drawing.Point(99, 394);
			this.CreateProjectButton.Name = "CreateProjectButton";
			this.CreateProjectButton.Size = new System.Drawing.Size(167, 44);
			this.CreateProjectButton.TabIndex = 1;
			this.CreateProjectButton.Text = "プロジェクト新規作成";
			this.CreateProjectButton.UseVisualStyleBackColor = true;
			this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
			// 
			// AddPacketIDEnumButton
			// 
			this.AddPacketIDEnumButton.Location = new System.Drawing.Point(79, 391);
			this.AddPacketIDEnumButton.Name = "AddPacketIDEnumButton";
			this.AddPacketIDEnumButton.Size = new System.Drawing.Size(161, 44);
			this.AddPacketIDEnumButton.TabIndex = 3;
			this.AddPacketIDEnumButton.Text = "パケットＩＤ enum追加";
			this.AddPacketIDEnumButton.UseVisualStyleBackColor = true;
			this.AddPacketIDEnumButton.Click += new System.EventHandler(this.AddPacketIDEnumButton_Click);
			// 
			// PacketIDEnumListBox
			// 
			this.PacketIDEnumListBox.FormattingEnabled = true;
			this.PacketIDEnumListBox.ItemHeight = 15;
			this.PacketIDEnumListBox.Location = new System.Drawing.Point(18, 21);
			this.PacketIDEnumListBox.Name = "PacketIDEnumListBox";
			this.PacketIDEnumListBox.Size = new System.Drawing.Size(276, 364);
			this.PacketIDEnumListBox.TabIndex = 4;
			// 
			// ProjectGroup
			// 
			this.ProjectGroup.Controls.Add(this.PacketIDEnumListBox);
			this.ProjectGroup.Controls.Add(this.AddPacketIDEnumButton);
			this.ProjectGroup.Enabled = false;
			this.ProjectGroup.Location = new System.Drawing.Point(363, 3);
			this.ProjectGroup.Name = "ProjectGroup";
			this.ProjectGroup.Size = new System.Drawing.Size(732, 435);
			this.ProjectGroup.TabIndex = 5;
			this.ProjectGroup.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1107, 450);
			this.Controls.Add(this.ProjectGroup);
			this.Controls.Add(this.CreateProjectButton);
			this.Controls.Add(this.ProjectListBox);
			this.Name = "MainForm";
			this.Text = "PacketGenerator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ProjectGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox ProjectListBox;
		private System.Windows.Forms.Button CreateProjectButton;
		private System.Windows.Forms.Button AddPacketIDEnumButton;
		private System.Windows.Forms.ListBox PacketIDEnumListBox;
		private System.Windows.Forms.GroupBox ProjectGroup;
	}
}

