namespace PacketGenerator
{
	partial class CreateProjectDialog
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
			this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(75, 114);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(115, 44);
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(254, 114);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(115, 44);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "キャンセル";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ProjectNameTextBox
			// 
			this.ProjectNameTextBox.Location = new System.Drawing.Point(110, 66);
			this.ProjectNameTextBox.Name = "ProjectNameTextBox";
			this.ProjectNameTextBox.Size = new System.Drawing.Size(211, 22);
			this.ProjectNameTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(169, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "プロジェクト名";
			// 
			// CreateProjectDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 187);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ProjectNameTextBox);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateProjectDialog";
			this.Text = "プロジェクト新規作成";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.TextBox ProjectNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}