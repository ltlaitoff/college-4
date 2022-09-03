namespace PR_3
{
	partial class Form3
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Result: ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 117);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Get result";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(96, 34);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Litres = ";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 165);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form3";
			this.Text = "PR 3.2";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Button button1;
		private NumericUpDown numericUpDown1;
		private Label label2;
	}
}