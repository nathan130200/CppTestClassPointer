namespace TestCallback_App
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnGetNumber = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnSetNumber = new System.Windows.Forms.Button();
			this.btnGetName = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			// 
			// btnGetNumber
			// 
			this.btnGetNumber.Location = new System.Drawing.Point(118, 10);
			this.btnGetNumber.Name = "btnGetNumber";
			this.btnGetNumber.Size = new System.Drawing.Size(75, 23);
			this.btnGetNumber.TabIndex = 1;
			this.btnGetNumber.Text = "GetNumber";
			this.btnGetNumber.UseVisualStyleBackColor = true;
			this.btnGetNumber.Click += new System.EventHandler(this.btnGetNumber_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 41);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 2;
			// 
			// btnSetNumber
			// 
			this.btnSetNumber.Location = new System.Drawing.Point(118, 39);
			this.btnSetNumber.Name = "btnSetNumber";
			this.btnSetNumber.Size = new System.Drawing.Size(75, 23);
			this.btnSetNumber.TabIndex = 3;
			this.btnSetNumber.Text = "SetNumber";
			this.btnSetNumber.UseVisualStyleBackColor = true;
			this.btnSetNumber.Click += new System.EventHandler(this.btnSetNumber_Click);
			// 
			// btnGetName
			// 
			this.btnGetName.Location = new System.Drawing.Point(12, 67);
			this.btnGetName.Name = "btnGetName";
			this.btnGetName.Size = new System.Drawing.Size(181, 23);
			this.btnGetName.TabIndex = 4;
			this.btnGetName.Text = "GetName";
			this.btnGetName.UseVisualStyleBackColor = true;
			this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(203, 104);
			this.Controls.Add(this.btnGetName);
			this.Controls.Add(this.btnSetNumber);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.btnGetNumber);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnGetNumber;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnSetNumber;
		private System.Windows.Forms.Button btnGetName;
	}
}

