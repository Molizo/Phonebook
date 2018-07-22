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

            if (textBoxFirstName.Text == String.Empty)
                contactFileContents += "<EMPTY>|";
            else
                contactFileContents += textBoxFirstName.Text + "|";

            if (textBoxMiddleName.Text == String.Empty)
                contactFileContents += "<EMPTY>|";
            else
                contactFileContents += textBoxMiddleName.Text + "|";

            if (textBoxLastName.Text == String.Empty)
                contactFileContents += "<EMPTY>|";
            else
                contactFileContents += textBoxLastName.Text + "|";

            if (textBoxMobilePhone.Text == String.Empty)
                contactFileContents += "<EMPTY>|";
            else
                contactFileContents += textBoxMobilePhone.Text + "|";

            if (textBoxHomePhone.Text == String.Empty)
                contactFileContents += "<EMPTY>|";
            else
                contactFileContents += textBoxHomePhone.Text + "|";

            if (textBoxFaxPhone.Text == String.Empty)
                contactFileContents += "<EMPTY>|";
            else
                contactFileContents += textBoxFaxPhone.Text + "|";

            if (textBoxWorkPhone.Text == String.Empty)
                contactFileContents += "<EMPTY>|";
            else
                contactFileContents += textBoxWorkPhone.Text + "|";

            if (textBoxEmail.Text == String.Empty)
                contactFileContents += "<EMPTY>";
            else
                contactFileContents += textBoxEmail.Text;

            File.WriteAllText("contacts.dat", contactFileContents);
            this.Close();
        }
    }
}