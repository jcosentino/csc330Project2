using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace CSC_330_Project_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            if (householdsButton.Checked)
            {
                string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                MySqlConnection proj2 = new MySqlConnection(connection);
                proj2.Open();

                Random idGen = new Random();
                int id = idGen.Next();
                string tempID = id.ToString();
                tempID = tempID.Substring(0, 6);
                id = int.Parse(tempID);

                var addQuery = "INSERT INTO households(idhouseholds, firstName, lastName, pNumber, streetName, houseNumber, aptNum, postal, subStatus)VALUES(@ID, @first, @last, @pnum, @sName, @hNumber, @aNum, @post, @subS)";
                MySqlCommand cmd = new MySqlCommand(addQuery, proj2);
                MySqlDataAdapter adapt = new MySqlDataAdapter(addQuery, proj2);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.Add("@first", MySqlDbType.String, 36, "firstName");
                cmd.Parameters.Add("@last", MySqlDbType.String, 36, "lastName");
                cmd.Parameters.Add("@pNum", MySqlDbType.String, 11, "pNumber");
                cmd.Parameters.Add("@sName", MySqlDbType.String, 11, "streetName");
                cmd.Parameters.Add("@hNumber", MySqlDbType.Int32, 11, "houseNumber");
                cmd.Parameters.Add("@aNum", MySqlDbType.String, 11, "aptNum");
                cmd.Parameters.Add("@post", MySqlDbType.Int32, 11, "postal");
                cmd.Parameters.AddWithValue("@subS", 1);
                adapt.InsertCommand = cmd;

                var updateQuery = "UPDATE csc330project2.households SET firstName = @first, lastName = @last, pNumber = @pNum, streetName = @sName, houseNumber = @hNumber, aptNum = @aNum, postal = @post, subStatus = @subS WHERE idhouseholds = @ID;";
                cmd = new MySqlCommand(updateQuery, proj2);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32, 6, "idhouseholds");
                cmd.Parameters.Add("@first", MySqlDbType.String, 36, "firstName");
                cmd.Parameters.Add("@last", MySqlDbType.String, 36, "lastName");
                cmd.Parameters.Add("@pNum", MySqlDbType.String, 11, "pNumber");
                cmd.Parameters.Add("@sName", MySqlDbType.String, 11, "streetName");
                cmd.Parameters.Add("@hNumber", MySqlDbType.Int32, 11, "houseNumber");
                cmd.Parameters.Add("@aNum", MySqlDbType.String, 11, "aptNum");
                cmd.Parameters.Add("@post", MySqlDbType.Int32, 11, "postal");
                cmd.Parameters.Add("@subS", MySqlDbType.Bit, 11, "subStatus");
                adapt.UpdateCommand = cmd;

                var deleteQuery = "DELETE FROM csc330project2.households WHERE idhouseholds= @ID;";
                cmd = new MySqlCommand(deleteQuery, proj2);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32, 6, "idhouseholds");
                adapt.DeleteCommand = cmd;

                try
                {
                    DataTable DT = dataGridView1.DataSource as DataTable;
                    adapt.Update(DT);
                }

                catch (MySqlException)
                {
                    MessageBox.Show("Not all fields have been filled");
                }

                catch (FormatException)
                {
                    MessageBox.Show("One of the fields has incorrect information format.");
                }

                catch (OverflowException)
                {
                    MessageBox.Show("One of the fields has a number that is too big.");
                }

                catch (Exception)
                {
                    MessageBox.Show("Unable to process.");
                }

                finally
                {
                    MessageBox.Show("The database has been updated.");
                }

                proj2.Close();
            }
            else if (carrierButton.Checked)
            {
                string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                MySqlConnection proj2 = new MySqlConnection(connection);
                proj2.Open();

                Random idGen = new Random();
                int id = idGen.Next();
                string tempID = id.ToString();
                tempID = tempID.Substring(0, 6);
                id = int.Parse(tempID);

                DataSet DS = new DataSet();
                var addQuery = "INSERT INTO carriers(idcarriers, dayDeliver, idhouseholds, idpublications, price)VALUES(@ID, @dDel, @idH, @idP, @pr)";
                MySqlCommand cmd = new MySqlCommand(addQuery, proj2);
                MySqlDataAdapter adapt = new MySqlDataAdapter(addQuery, proj2);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.Add("@dDel", MySqlDbType.String, 36, "dayDeliver");
                cmd.Parameters.Add("@idH", MySqlDbType.Int32, 6, "idhouseholds");
                cmd.Parameters.Add("@idP", MySqlDbType.Int32, 6, "idpublications");
                cmd.Parameters.Add("@pr", MySqlDbType.Double, 6, "price");
                adapt.InsertCommand = cmd;

                var updateQuery = "UPDATE csc330project2.carriers SET dayDeliver = @dDel, idhouseholds = @idH, idpublications = @idP, price = @pr WHERE idhouseholds = @ID;";
                cmd = new MySqlCommand(updateQuery, proj2);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32, 6, "idhouseholds");
                cmd.Parameters.Add("@dDel", MySqlDbType.String, 36, "dayDeliver");
                cmd.Parameters.Add("@idH", MySqlDbType.Int32, 6, "idhouseholds");
                cmd.Parameters.Add("@idP", MySqlDbType.Int32, 6, "idpublications");
                cmd.Parameters.Add("@pr", MySqlDbType.Double, 6, "price");
                adapt.UpdateCommand = cmd;

                var deleteQuery = "DELETE FROM csc330project2.carriers WHERE idcarriers= @ID;";
                cmd = new MySqlCommand(deleteQuery, proj2);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32, 6, "idcarriers");
                adapt.DeleteCommand = cmd;

                try
                {
                    DataTable DT = dataGridView1.DataSource as DataTable;
                    adapt.Update(DT);
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Not all fields have been filled (Database)");
                }

                catch (FormatException)
                {
                    MessageBox.Show("One of the fields has incorrect information.");
                }

                catch (OverflowException)
                {
                    MessageBox.Show("One of the fields has a number that is too big.");
                }

                finally
                {
                    MessageBox.Show("The database has been updated.");
                }

                proj2.Close();
            }
            else if (publicationButton.Checked)
            {
                string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                MySqlConnection proj2 = new MySqlConnection(connection);
                proj2.Open();

                Random idGen = new Random();
                int id = idGen.Next();
                string tempID = id.ToString();
                tempID = tempID.Substring(0, 6);
                id = int.Parse(tempID);

                DataSet DS = new DataSet();
                var addQuery = "INSERT INTO publications(idpublications, title, newsType, edition, price)VALUES(@ID, @titl, @newsT, @edit, @pr)";
                MySqlCommand cmd = new MySqlCommand(addQuery, proj2);
                MySqlDataAdapter adapt = new MySqlDataAdapter(addQuery, proj2);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.Add("@titl", MySqlDbType.String, 36, "title");
                cmd.Parameters.Add("@newsT", MySqlDbType.String, 36, "newsType");
                cmd.Parameters.Add("@edit", MySqlDbType.String, 11, "edition");
                cmd.Parameters.Add("@pr", MySqlDbType.Double, 11, "price");
                adapt.InsertCommand = cmd;

                var updateQuery = "UPDATE csc330project2.publications SET title = @titl, newsType = @newsT, edition = @edit, price = @pr WHERE idpublications = @ID;";
                cmd = new MySqlCommand(updateQuery, proj2);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32, 6, "idpublications");
                cmd.Parameters.Add("@titl", MySqlDbType.String, 36, "title");
                cmd.Parameters.Add("@newsT", MySqlDbType.String, 36, "newsType");
                cmd.Parameters.Add("@edit", MySqlDbType.String, 11, "edition");
                cmd.Parameters.Add("@pr", MySqlDbType.Double, 11, "price");
                adapt.UpdateCommand = cmd;

                var deleteQuery = "DELETE FROM csc330project2.publications WHERE idpublications= @ID;";
                cmd = new MySqlCommand(deleteQuery, proj2);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32, 6, "idpublications");
                adapt.DeleteCommand = cmd;

                try
                {
                    DataTable DT = dataGridView1.DataSource as DataTable;
                    adapt.Update(DT);
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Not all fields have been filled");
                }

                catch (FormatException)
                {
                    MessageBox.Show("One of the fields has incorrect information.");
                }

                catch (OverflowException)
                {
                    MessageBox.Show("One of the fields has a number that is too big.");
                }

                finally
                {
                    MessageBox.Show("The database has been updated.");
                }

                proj2.Close();
            }
            else
            { }
        }

        private void searchButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //When in textbox, press Enter to utilize the button
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void searchButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void addButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void deleteButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void connectionButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void householdsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (householdsButton.Checked)
            {
                if (householdsButton.Checked == true)
                {
                    textBox1.Visible = false;
                    carrierClickButton.Visible = false;
                    richTextBox1.Visible = false;
                    instructionLabel.Visible = false;
                }
                string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                MySqlConnection proj2 = new MySqlConnection(connection);
                proj2.Open();

                var query = "select * from households;";
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, proj2);
                DataSet DS = new DataSet();
                cmd.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Visible = true;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[8].ReadOnly = true;
                this.dataGridView1.ClipboardCopyMode =
                DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                proj2.Close();
            }
        }

        private void carrierButton_CheckedChanged(object sender, EventArgs e)
        {
            if (carrierButton.Checked)
            {
                if (carrierButton.Checked == true)
                {
                    textBox1.Visible = true;
                    carrierClickButton.Visible = true;
                    carrierClickButton.Text = "C";
                    richTextBox1.Visible = true;
                    instructionLabel.Visible = true;
                }

                string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                MySqlConnection proj2 = new MySqlConnection(connection);
                proj2.Open();

                var query = "select * from carriers;";
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, proj2);
                DataSet DS = new DataSet();
                cmd.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Visible = true;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                this.dataGridView1.ClipboardCopyMode =
                DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                proj2.Close();
            }
        }

        private void publicationButton_CheckedChanged(object sender, EventArgs e)
        {
            if (publicationButton.Checked)
                {
                if (publicationButton.Checked == true)
                {
                    textBox1.Visible = false;
                    carrierClickButton.Visible = false;
                    richTextBox1.Visible = false;
                    instructionLabel.Visible = false;
                }
                string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
                MySqlConnection proj2 = new MySqlConnection(connection);
                proj2.Open();

                var query = "select * from publications;";
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, proj2);
                DataSet DS = new DataSet();
                cmd.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Visible = true;
                dataGridView1.Columns[0].ReadOnly = true;
                this.dataGridView1.ClipboardCopyMode =
                DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                proj2.Close();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void checkBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectionButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void carrierClickButton_Click(object sender, EventArgs e)
        { //What if carrier ID does not exist?
            Carrier c = new Carrier();
            int x; //Used for Int32.TryParse

            if (String.IsNullOrWhiteSpace(textBox1.Text) == true)
            { }
            else
            {
                switch (carrierClickButton.Text)
                {
                    case "C":
                        if (Int32.TryParse(textBox1.Text, out x) == true)
                        {
                            idClabel.Text = textBox1.Text;
                            textBox1.Clear();
                            carrierClickButton.Text = "H";
                        }
                        else
                        {
                            MessageBox.Show("Please input a 6-digit number.");
                            textBox1.Clear();
                        }

                        break;
                    case "H":
                        if (Int32.TryParse(textBox1.Text, out x) == true)
                        {
                            idHlabel.Text = textBox1.Text;
                            textBox1.Clear();
                            carrierClickButton.Text = "P";
                        }
                        else
                        {
                            MessageBox.Show("Please input a 6-digit number.");
                            textBox1.Clear();
                        }
                        break;
                    case "P":
                        if (Int32.TryParse(textBox1.Text, out x) == true)
                        {
                            idPlabel.Text = textBox1.Text;
                            textBox1.Clear();
                            carrierClickButton.Text = "C";
                            c.update(Int32.Parse(idClabel.Text), Int32.Parse(idHlabel.Text), Int32.Parse(idPlabel.Text));
                            idClabel.Text = "idcarriers";
                            idHlabel.Text = "idhouseholds";
                            idPlabel.Text = "idpublications";
                        }
                        else
                        {
                            MessageBox.Show("Please input a 6-digit number.");
                            textBox1.Clear();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void carrierClickButton_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                carrierClickButton_Click(this, new EventArgs());
                //press Enter to utilize the button
            }
        }

        private void carrierClickButton_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
