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
	public partial class inputForm : Form
	{
		private bool drag = false;
		private Point startPoint = new Point(0, 0);

		public inputForm()
		{
			InitializeComponent();
			cardOptions_tabControl.Appearance = TabAppearance.FlatButtons;
			cardOptions_tabControl.ItemSize = new Size(0, 1);
			cardOptions_tabControl.SizeMode = TabSizeMode.Fixed;
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

		private void generate_button_Click(object sender, EventArgs e)
		{
			switch(cardChooser_comboBox.SelectedIndex)
			{
				case 0:
					Form excusedCardForm = new ExcusedCardForm(
						excused_date_textBox.Text,
						excused_name_textBox.Text,
						excused_adjective_textBox.Text,
						excused_noun_textBox.Text,
						excused_signed_textBox.Text);
					excusedCardForm.Show();
					break;
				case 1:
					Form hallPassCardForm = new HallPassCardForm();/* (
						excused_date_textBox.Text,
						excused_name_textBox.Text,
						excused_adjective_textBox.Text,
						excused_noun_textBox.Text,
						excused_signed_textBox.Text);*/
					break;

			}
		}

		private void cardChooser_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			cardOptions_tabControl.SelectedIndex = cardChooser_comboBox.SelectedIndex;
		}
	}
}
