using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }
    }
}