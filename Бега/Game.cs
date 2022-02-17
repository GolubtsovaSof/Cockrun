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
	class Game
	{
		public int r_num;
		private Form1 Form1 { get; set; }
		public List<Roach> Roaches = new List<Roach>();
		public Game(int ar_num, Form1 f)
		{
			Random rnd = new Random();
			r_num = ar_num;
			Form1 = f;
			for (int i=0; i<r_num; i++)
			{
				Roach r = new Roach(10, 10 + i * 150, rnd.Next(2,15), Form1);
				Roaches.Add(r);
				r.Draw();
			}
		}
		public void Run()
		{
			foreach (Roach x in Roaches)
			{
				x.Move();
			}
		}
		public void Update()
		{
			foreach (Roach x in Roaches)
			{
				x.ReDraw();
			}
		}
		public int Has_won()
		{
			foreach (Roach x in Roaches)
			{
				if (x.x >= Form1.Width)
				{
					return Roaches.IndexOf(x) + 1;
				}
			}
			return 0;
		}

	}
}
