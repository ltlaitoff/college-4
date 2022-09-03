namespace PR_3
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(79, 88);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown1.TabIndex = 0;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(79, 119);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Result Y = ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "c = ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "t = ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "b = 0,00845";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(46, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "x = 0,85431";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(46, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 15);
			this.label6.TabIndex = 6;
			this.label6.Text = "a = 2,31";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(50, 188);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 15);
			this.label7.TabIndex = 7;
			this.label7.Text = "Result d = ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(50, 225);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Get Y and d";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(247, 271);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "Form2";
			this.Text = "PR 3.1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Button button1;
	}
}