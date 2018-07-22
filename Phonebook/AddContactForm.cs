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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string contactFileContents = String.Empty;
            if (File.Exists("contacts.dat"))
                contactFileContents = File.ReadAllText("contacts.dat") + System.Environment.NewLine;
            contactFileContents += textBoxFirstName.Text + "|" +
                                   textBoxMiddleName.Text + "|" +
                                   textBoxLastName.Text + "|" +
                                   textBoxMobilePhone.Text + "|" +
                                   textBoxHomePhone.Text + "|" +
                                   textBoxFaxPhone.Text + "|" +
                                   textBoxWorkPhone.Text + "|" +
                                   textBoxEmail.Text;
            File.WriteAllText("contacts.dat", contactFileContents);
            this.Close();
        }
    }
}