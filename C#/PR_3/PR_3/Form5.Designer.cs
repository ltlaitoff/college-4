namespace PR_3
{
	partial class Form5
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.Scale});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(250, 340);
			this.dataGridView1.TabIndex = 0;
			// 
			// City
			// 
			this.City.HeaderText = "City";
			this.City.Name = "City";
			// 
			// Scale
			// 
			this.Scale.HeaderText = "Scale";
			this.Scale.Name = "Scale";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(305, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Update scales";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(305, 107);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
			this.numericUpDown1.TabIndex = 2;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 364);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form5";
			this.Text = "PR 3.4";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn City;
		private DataGridViewTextBoxColumn Scale;
		private Button button1;
		private NumericUpDown numericUpDown1;
	}
}