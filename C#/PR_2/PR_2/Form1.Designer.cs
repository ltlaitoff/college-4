namespace PR_2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Open Form2";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(147, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Resize form";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.GridColor = System.Drawing.Color.SaddleBrown;
			this.dataGridView1.Location = new System.Drawing.Point(12, 59);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 60;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(535, 118);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column1.Frozen = true;
			this.Column1.HeaderText = "First";
			this.Column1.Name = "Column1";
			this.Column1.Width = 15;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.Frozen = true;
			this.Column2.HeaderText = "Second";
			this.Column2.Name = "Column2";
			this.Column2.Width = 99;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Third";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Four";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Five";
			this.Column5.Name = "Column5";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(269, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Change 1;0 and 1;1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 183);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(116, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Visibility 1";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(559, 216);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 150);
			this.Name = "Form1";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Practice work 2 Main";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Button button1;
		private Button button2;
		private DataGridView dataGridView1;
		private Button button3;
		private Button button4;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
	}
}