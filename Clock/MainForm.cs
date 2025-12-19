using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

		}

		private void labelTime_Click(object sender, EventArgs e)
		{

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString
				(
				"HH:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture
				);
			if (cbShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			if (cbShowWeekday.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			cbShowDate.Visible = false;
			cbShowWeekday.Visible = false;
			btnHideControls.Visible = false;
			this.ShowInTaskbar = false;
		}
	}
}
