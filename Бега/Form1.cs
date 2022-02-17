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
	public partial class Form1 : Form
	{
		Game game;
		int stavka;
		Random rnd = new Random();
		Timer timer;

		public Form1()
		{
			InitializeComponent();
			BackgroundImage = Properties.Resources.fonstola_ru_79792;
			game = new Game(3, this);
			DoubleBuffered = true;
			panel2.Visible = false;
			panel3.Visible = false;
			panel2.Parent = this;
			panel3.Parent = this;
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			timer = new Timer();
			timer.Interval = 1;
			timer.Tick += Timer1_Tick;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (stavka != 0)
			{
				timer.Start();
				timer.Enabled = true;
				panel1.Visible = false;
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			int result = game.Has_won();
			if (result == 0)
			{
				game.Run();
				game.Update();
			}
			else
			{
				timer.Stop();
				if (stavka == result)
				{
					panel2.Visible = true;
				}
				else
				{
					panel3.Visible = true;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			stavka = 1;
			panel1.Visible = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			stavka = 2;
			panel1.Visible = false;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			stavka = 3;
			panel1.Visible = false;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			stavka = 0;
			foreach (Roach x in game.Roaches)
			{
				x.x = 10;
				x.speed = rnd.Next(2, 15);
			}
			timer.Enabled = false;
			timer.Interval=1;
			panel3.Visible = false;
			panel1.Visible = true;
			game.Update(); 
		}

		private void button5_Click(object sender, EventArgs e)
		{
			stavka = 0;
			foreach (Roach x in game.Roaches)
			{
				x.x = 10;
				x.speed = rnd.Next(2, 15);
			}
			timer.Enabled = false;
			timer.Interval = 1;
			panel2.Visible = false;
			panel1.Visible = true;
			game.Update();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
