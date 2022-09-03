namespace PR_4
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number});
			this.dataGridView1.Location = new System.Drawing.Point(47, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(242, 369);
			this.dataGridView1.TabIndex = 0;
			// 
			// Number
			// 
			this.Number.HeaderText = "Number";
			this.Number.Name = "Number";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(344, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Values: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(344, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Length:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(344, 165);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Get";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(344, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Min module:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(344, 205);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Second";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 403);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "PR4";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Number;
		private Label label1;
		private Label label2;
		private Button button1;
		private Label label3;
		private Button button2;
	}
}