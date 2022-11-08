namespace PR_7
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Курс";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ціна(USD)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(99, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 33);
			this.button1.TabIndex = 3;
			this.button1.Text = "Конвертувати";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(99, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 4;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(99, 54);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 23);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(302, 22);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 23);
			this.textBox3.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(302, 100);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 33);
			this.button2.TabIndex = 7;
			this.button2.Text = "Конвертувати";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ціна(EUR)";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(302, 56);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 23);
			this.textBox4.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(227, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Курс";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(248, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "label6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 180);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Конвертор";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button2;
		private Label label4;
		private TextBox textBox4;
		private Label label5;
		private Label label6;
	}
}