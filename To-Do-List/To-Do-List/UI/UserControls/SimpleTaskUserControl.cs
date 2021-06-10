using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_List.Database.Entities;

namespace To_Do_List.UI.UserControls
{
    public partial class SimpleTaskUserControl : UserControl
    {
        public SimpleTaskUserControl(Color statusColor, TaskEntity task)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 201, 120);
            panel1.BackColor = statusColor;
            nameLabel.Text = task.Name;
        }
    }
}
