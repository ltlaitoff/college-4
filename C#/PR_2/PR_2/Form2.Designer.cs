namespace PR_2
{
	partial class Form2
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
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Result:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(36, 179);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Get result";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "a:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "b:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "c:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(48, 29);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown1.TabIndex = 8;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(49, 69);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown2.TabIndex = 9;
			this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(48, 107);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown3.TabIndex = 10;
			this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(200, 234);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "PR2 2";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label label1;
		private Button button1;
		private Label label2;
		private Label label3;
		private Label label4;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown3;
	}
}