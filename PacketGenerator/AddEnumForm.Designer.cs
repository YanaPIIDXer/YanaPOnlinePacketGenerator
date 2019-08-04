namespace PacketGenerator
{
	partial class AddEnumForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.EnumNameTextBox = new System.Windows.Forms.TextBox();
			this.Output1PathTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Output1LanguageList = new System.Windows.Forms.ComboBox();
			this.Output2LanguageList = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Output2PathTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "enum名";
			// 
			// EnumNameTextBox
			// 
			this.EnumNameTextBox.Location = new System.Drawing.Point(199, 38);
			this.EnumNameTextBox.Name = "EnumNameTextBox";
			this.EnumNameTextBox.Size = new System.Drawing.Size(229, 22);
			this.EnumNameTextBox.TabIndex = 1;
			// 
			// Output1PathTextBox
			// 
			this.Output1PathTextBox.Location = new System.Drawing.Point(199, 90);
			this.Output1PathTextBox.Name = "Output1PathTextBox";
			this.Output1PathTextBox.Size = new System.Drawing.Size(229, 22);
			this.Output1PathTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(83, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "出力先１パス";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(83, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "出力先１言語";
			// 
			// Output1LanguageList
			// 
			this.Output1LanguageList.FormattingEnabled = true;
			this.Output1LanguageList.Items.AddRange(new object[] {
            "C++",
            "C#"});
			this.Output1LanguageList.Location = new System.Drawing.Point(226, 139);
			this.Output1LanguageList.Name = "Output1LanguageList";
			this.Output1LanguageList.Size = new System.Drawing.Size(121, 23);
			this.Output1LanguageList.TabIndex = 5;
			this.Output1LanguageList.Text = "C++";
			// 
			// Output2LanguageList
			// 
			this.Output2LanguageList.FormattingEnabled = true;
			this.Output2LanguageList.Items.AddRange(new object[] {
            "C++",
            "C#"});
			this.Output2LanguageList.Location = new System.Drawing.Point(226, 233);
			this.Output2LanguageList.Name = "Output2LanguageList";
			this.Output2LanguageList.Size = new System.Drawing.Size(121, 23);
			this.Output2LanguageList.TabIndex = 9;
			this.Output2LanguageList.Text = "C++";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "出力先２言語";
			// 
			// Output2PathTextBox
			// 
			this.Output2PathTextBox.Location = new System.Drawing.Point(199, 184);
			this.Output2PathTextBox.Name = "Output2PathTextBox";
			this.Output2PathTextBox.Size = new System.Drawing.Size(229, 22);
			this.Output2PathTextBox.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(83, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "出力先２パス";
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(114, 288);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(149, 50);
			this.OKButton.TabIndex = 10;
			this.OKButton.Text = "ＯＫ";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(381, 288);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(149, 50);
			this.CancelButton.TabIndex = 11;
			this.CancelButton.Text = "キャンセル";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// AddEnumForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 350);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.Output2LanguageList);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Output2PathTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Output1LanguageList);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Output1PathTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.EnumNameTextBox);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddEnumForm";
			this.Text = "パケットＩＤenum追加";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox EnumNameTextBox;
		private System.Windows.Forms.TextBox Output1PathTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox Output1LanguageList;
		private System.Windows.Forms.ComboBox Output2LanguageList;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Output2PathTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button CancelButton;
	}
}