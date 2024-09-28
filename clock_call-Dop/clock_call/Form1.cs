using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock_call
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButtonClock_Click(object sender, EventArgs e)
        {
            FormClock formClock = new FormClock();
            formClock.ShowDialog();
        }

        private void ButtonAlClock_Click(object sender, EventArgs e)
        {
            FormAlClock formAlClock = new FormAlClock();    
            formAlClock.ShowDialog();
        }
    }

}
