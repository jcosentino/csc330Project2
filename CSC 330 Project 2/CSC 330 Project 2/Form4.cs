using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSC_330_Project_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {}
            else
            {
                if (radioButton1.Checked && !radioButton2.Checked)
                {
                    string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                    MySqlConnection proj2 = new MySqlConnection(connection);
                    proj2.Open();

                    try
                    {
                        var addQuery = "SELECT SUM(price)FROM carriers WHERE idhouseholds = @idhouse";
                        MySqlCommand cmdAdd = new MySqlCommand(addQuery, proj2);
                        cmdAdd.Parameters.AddWithValue("@idhouse", Double.Parse(textBox1.Text));
                        var countQuery = "SELECT COUNT(idhouseholds) FROM carriers where idhouseholds = @idhouse;";
                        MySqlCommand cmdCount = new MySqlCommand(countQuery, proj2);

                        cmdCount.Parameters.AddWithValue("@idhouse", Int32.Parse(textBox1.Text));
                        priceLabel.Text = "$" + cmdAdd.ExecuteScalar().ToString();
                        totalLabel.Text = cmdCount.ExecuteScalar().ToString();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please type a number.");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("One of the fields has a number that is too big.");
                    }
                    proj2.Close();
                }
                else if (!radioButton1.Checked && radioButton2.Checked)
                {
                    string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                    MySqlConnection proj2 = new MySqlConnection(connection);
                    proj2.Open();

                    try
                    {
                        var addQuery = "SELECT SUM(price)FROM carriers WHERE idpublications = @idpub";
                        MySqlCommand cmdAdd = new MySqlCommand(addQuery, proj2);
                        cmdAdd.Parameters.AddWithValue("@idpub", Double.Parse(textBox1.Text));

                        var countQuery = "SELECT COUNT(idpublications) FROM carriers where idpublications = @idpub;";
                        MySqlCommand cmdCount = new MySqlCommand(countQuery, proj2);
                        cmdCount.Parameters.AddWithValue("@idpub", Int32.Parse(textBox1.Text));

                        priceLabel.Text = "$" + cmdAdd.ExecuteScalar().ToString();
                        totalLabel.Text = cmdCount.ExecuteScalar().ToString();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please type a number.");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("One of the fields has a number that is too big.");
                    }

                    proj2.Close();
                }
                else
                {
                    MessageBox.Show("Please select an option above.");
                }
            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void checkBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !radioButton2.Checked)
            {
                groupBox1.Visible = true;
                textBox1.Clear();
                groupBox1.Text = "Search Household ID";
                button2.Visible = true;
                priceLabel.Text = "$";
                totalLabel.Text = "x";
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && radioButton2.Checked)
            {
                groupBox1.Visible = true;
                textBox1.Clear();
                groupBox1.Text = "Search Publication ID";
                button2.Visible = false;
                priceLabel.Text = "$";
                totalLabel.Text = "x";
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void radioButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Visible == true && priceLabel.Text != "$")
            {
                priceLabel.Text = "$0.00";
                MessageBox.Show("Congratulations! You paid your bill.");
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
