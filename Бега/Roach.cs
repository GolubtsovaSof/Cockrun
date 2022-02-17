using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бега
{
	class Roach
	{
		public float x, y;
		public int speed;
		public Image im;
		private Form1 Form1 { get; set; }
		PictureBox p;


		public Roach(float ax, float ay, int aspeed, Form1 f)
		{
			x = ax; y = ay;
			speed = aspeed;
			im = Properties.Resources.png_transparent_brown_and_black_cockroach_insect_cockroach_pest_control_ant_roach_insects_bed_bug_true_bugs;
			Form1 = f;
		}
		public void Move()
		{
			x += speed;
		}

		public void Draw()
		{
			PictureBox PicturesBox = new PictureBox()
			{
				Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y)),
				Image = im,
				BackColor = Color.Transparent,
				SizeMode = PictureBoxSizeMode.StretchImage,
				Size = new Size(200, 150)
			};
			p = PicturesBox;
			Form1.Controls.Add(PicturesBox);
		}
		public void ReDraw()
		{
			p.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
		}
	}
}
