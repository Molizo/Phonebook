using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists("contacts.dat"))
                loadContacts();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
            loadContacts();
        }

        private void loadContacts()
        {
            string[] contacts = File.ReadAllLines("contacts.dat");
            dataGridView.Rows.Clear();
            foreach (string contact in contacts)
            {
                string[] contactInfo = contact.Split('|');
                dataGridView.Rows.Add(contactInfo);
            }
        }
    }
}