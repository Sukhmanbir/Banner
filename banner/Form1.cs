using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace banner
{
    public partial class libraryForm : Form
    {
        public libraryForm()
        {
            //create new thread to display splashScreen form
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(3000);

            InitializeComponent();

            //abort the splashScreen
            t.Abort();
        }

        public void splashStart()
        {
            //start splashScreen
            Application.Run(new SplashScreen());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }

        private void libraryForm_Load(object sender, EventArgs e)
        {
            //set the default values
            typeComboBox.SelectedIndex = 0;
            gradeComboBox.SelectedIndex = 0;

            //show the date in the status bar
            dateToolStripStatusLabel.Text = DateTime.Today.ToLongDateString();

            if (typeComboBox.SelectedIndex == 0)
            {
                gradeLabel.Show();
                gradeComboBox.Show();
                idLabel.Show();
                idTextBox.Show();
                teacherLabel.Hide();
                teacherTextBox.Hide();
            }
            else if (typeComboBox.SelectedIndex == 1)
            {
                gradeLabel.Hide();
                gradeComboBox.Hide();
                idLabel.Hide();
                idTextBox.Hide();
                teacherLabel.Show();
                teacherTextBox.Show();
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate object
            Inventory inventoryForm = new Inventory();
            //display the object
            inventoryForm.ShowDialog();
        }

        private void saveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the properties of saveFileDialog
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save file as";
            saveFileDialog.FileName = "Bookings.txt";
            saveFileDialog.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(idTextBox.Text))
                {
                    MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string text = typeComboBox.Text + ", " + idTextBox.Text + ", " + gradeComboBox.Text + ", " + titleTextBox.Text;
                    saveFileDialog.ShowDialog();
                    System.IO.File.WriteAllText(saveFileDialog.FileName, text);
                    MessageBox.Show("Record Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idTextBox.Clear();
                    titleTextBox.Clear();
                }
            }
            else {
                if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(teacherTextBox.Text))
                {
                    MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string text = typeComboBox.Text + ", " + teacherTextBox.Text + ", " + titleTextBox.Text;
                    saveFileDialog.ShowDialog();
                    System.IO.File.WriteAllText(saveFileDialog.FileName, text);
                    MessageBox.Show("Record Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    teacherTextBox.Clear();
                    titleTextBox.Clear();
                }
            }
        }

        private void typeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                gradeLabel.Show();
                gradeComboBox.Show();
                idLabel.Show();
                idTextBox.Show();
                teacherLabel.Hide();
                teacherTextBox.Hide();
            }
            else if (typeComboBox.SelectedIndex == 1)
            {
                gradeLabel.Hide();
                gradeComboBox.Hide();
                idLabel.Hide();
                idTextBox.Hide();
                teacherLabel.Show();
                teacherTextBox.Show();
            }
        }

        /*
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(idTextBox.Text, "  ^ [0-9]"))
            {
                idTextBox.Text = "";
            }
        }
        */
    }
}
