using System;
using System.Windows.Forms;

namespace CSC_330_Project_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (User.checkIfRegistered(textBox1.Text) == true)
                {
                    User.addNewUser(textBox1.Text, textBox2.Text);
                    MessageBox.Show(textBox1.Text + " has been added to the database.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid registration!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User "+"\""+textBox1.Text+"\" is not valid.");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }
    }
}
