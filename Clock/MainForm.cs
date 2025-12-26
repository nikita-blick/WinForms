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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			SetVisibility(false);

		}
		void SetVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekday.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
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

			notifyIcon.Text = labelTime.Text;

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility(false);
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(tsmiShowControls.Checked = false);
		}

		/*private void labelTime_MouseHover(object sender, EventArgs e)
		{
			SetVisibility(true);

		}*/

		private void tToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (!TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void tsmiTopmost_Click(object sender, EventArgs e) => this.TopMost = tsmiTopmost.Checked;

		private void tsmiShowControls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility((sender as ToolStripMenuItem).Checked);
			// Sender - это отправитель события (Control, который прислал событие).
			// если на элемент окна (Control) воздействует пользователь при помощи клавиатуры или мыши,
			// этот Control отправляет событие свему родителю,
			// а родитель может обрабатывать, или не обрабатывать это событие
		}
		private void tsmiShowDate_CheckedChangedprivate(object sender, EventArgs e) => 
			cbShowDate.Checked = tsmiShowDate.Checked;
		private void cbShowDate_CheckedChanged(object sender, EventArgs e) => 
			tsmiShowDate.Checked = cbShowDate.Checked;

		private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) => 
			cbShowWeekday.Checked = tsmiShowWeekday.Checked;

		private void cbShowWeekday_CheckedChanged(object sender, EventArgs e) => 
			tsmiShowWeekday.Checked = cbShowWeekday.Checked;

		private void tsmiQuit_Click(object sender, EventArgs e) => this.Close();
	}
}
