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
using To_Do_List.Database;
using To_Do_List.UI.UserControls;

namespace To_Do_List
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initComponent();
            initTaskTest();
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


        private void initTaskTest()
        {
            TaskDbContext task = new TaskDbContext();

            SimpleTaskUserControl simpleTask = new SimpleTaskUserControl(Color.LightCoral, task.Tasks.FirstOrDefault());
            simpleTask.Location = new Point(40, 20);
            tasksPanel.Controls.Add(simpleTask);
            //SimpleTaskUserControl simpleTask2 = new SimpleTaskUserControl(Color.LightGreen);
            //simpleTask2.Location = new Point(40, 110);
            //tasksPanel.Controls.Add(simpleTask2);
        }

    }
}
