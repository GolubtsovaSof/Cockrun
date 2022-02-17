
namespace Бега
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Peru;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(501, 569);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(423, 94);
			this.button1.TabIndex = 0;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::Бега.Properties.Resources._1612957906_42_p_rozovii_fon_s_dengami_70;
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(317, 107);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(819, 396);
			this.panel1.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(479, 216);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(93, 84);
			this.button4.TabIndex = 3;
			this.button4.Text = "3";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(362, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 84);
			this.button3.TabIndex = 2;
			this.button3.Text = "2";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(242, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 84);
			this.button2.TabIndex = 1;
			this.button2.Text = "1";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(143, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(538, 69);
			this.label1.TabIndex = 0;
			this.label1.Text = "СДЕЛАЙ СТАВКУ";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Location = new System.Drawing.Point(189, 578);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(268, 75);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(101, 38);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "заново";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button6);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(953, 578);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(232, 75);
			this.panel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(18, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(202, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "С карты списано 100 рублей.";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(63, 38);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 1;
			this.button6.Text = "заново";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "На карту начислено 100 рублей.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(1441, 675);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.MaximumSize = new System.Drawing.Size(1459, 722);
			this.MinimumSize = new System.Drawing.Size(1459, 722);
			this.Name = "Form1";
			this.Text = "cockrun";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

