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

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            string contactFileData = String.Empty; //These are all the new contacts
            int index = dataGridView.SelectedRows[0].Index; //Gets the index of the deleted row
            string[] contacts = File.ReadAllLines("contacts.dat"); //These are all the old contacts
            for (int i = 0; i < contacts.Count(); i++)
            {
                if (index != i)
                    contactFileData += contacts[i] + System.Environment.NewLine;
            }
            File.WriteAllText("contacts.dat", contactFileData); //Saves the contact file without the removed contact
            dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
        }
    }
}