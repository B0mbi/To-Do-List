using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initComponent();
        }

        private void initComponent()
        {
            this.BackColor = Color.FromArgb(35, 47, 52);
            leftSideMenuPanel.BackColor = Color.FromArgb(52, 73, 85);
            foreach (Control item in leftSideMenuPanel.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.FromArgb(74, 101, 114);
                }
            }
            tasksPanel.BackColor = Color.FromArgb(138, 176, 194);
            calendarOperatorPanel.BackColor = Color.FromArgb(52, 73, 85);
        }

    }
}
