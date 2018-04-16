using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLib_Game_Gen
{
	public partial class HallPassCardForm : Form
	{
		private bool drag = false;
		private Point startPoint = new Point(0, 0);

		public HallPassCardForm()
		{
			InitializeComponent();
		}

		public HallPassCardForm(string date, string name, string adjective, string noun, string signed)
		{
			InitializeComponent();
			/*excused_date_textBox.Text = date;
			excused_name_textBox.Text = name;
			excused_adjective_textBox.Text = adjective;
			excused_noun_textBox.Text = noun;
			excused_signed_textBox.Text = signed;*/
		}

		private void titleBar_MouseUp(object sender, MouseEventArgs e)
		{
			drag = false;
		}

		private void titleBar_MouseDown(object sender, MouseEventArgs e)
		{
			startPoint = e.Location;
			drag = true;
		}

		private void titleBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (drag)
			{
				Point p1 = new Point(e.X, e.Y);
				Point p2 = PointToScreen(p1);
				Point p3 = new Point(p2.X - startPoint.X, p2.Y - startPoint.Y);
				Location = p3;
			}
		}
	}
}
