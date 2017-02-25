using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSC_330_Project_2
{
    class User
    {
        public static bool authenticate(string username, string password)
        {
            string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
            MySqlConnection proj2 = new MySqlConnection(connection);
            proj2.Open();
            var query = "SELECT username, password FROM csc330project2.logins;";
            MySqlCommand cmd = new MySqlCommand(query, proj2);

            List<string> tempU = new List<string>();
            List<string> tempP = new List<string>();
            string u, p;
            bool check = false;

            using (proj2)
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    u = (string)reader["username"];
                    p = (string)reader["password"];
                    if (username == u && password == p)
                    {
                        tempU.Add(u);
                        tempP.Add(p);
                        check = true;
                        break;
                    }
                }
            }
            proj2.Close();

            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void addNewUser(string username, string password)
        {
            string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
            MySqlConnection proj2 = new MySqlConnection(connection);
            proj2.Open();

            var query = "INSERT INTO logins (username, password) VALUES (@user, @password);";
            MySqlCommand cmd = new MySqlCommand(query, proj2);

            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();

            proj2.Close();
        }

        public static bool checkIfRegistered(string username)
        {
            string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
            MySqlConnection proj2 = new MySqlConnection(connection);
            proj2.Open();

            var query = "SELECT username FROM csc330project2.logins;";
            MySqlCommand cmd = new MySqlCommand(query, proj2);
            List<string> tempU = new List<string>();
            string u;
            bool check = false;

            using (proj2)
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    u = (string)reader["username"];
                    tempU.Add(u);
                    if (username == u)
                    {
                        tempU.Add(u);
                        check = true;
                        break;
                    }
                }
            }
            proj2.Close();

            if (check == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected string pNumber;
        protected string streetName;
        protected int streetNumber;
        protected string aptNumber;
        protected int postalCode;
        protected string city;
        protected string state;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PNumber { get; set; }

        public string StreetName { get; set; }

        public int StreetNumber { get; set; }

        public string AptNumber { get; set; }

        public int PostalCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public abstract void update(int ID, int idH, int idP);
    }

    class Household : Person
    {
        private bool subStatus;

        public bool SubStatus
        {
            get { return subStatus; }
            set { subStatus = value; }
        }

        public override void update(int ID, int idH, int idP)
        {
            throw new NotImplementedException();
        }
    }

    class Carrier : Person
    {
        private int idcarriers;
        private int idhouseholds;
        private int idpublications;

        public int Idcarriers
        {
            get { return idcarriers; }
            set { idcarriers = value; }
        }
        public int Idhouseholds
        {
            get { return idhouseholds; }
            set { idhouseholds = value; }
        }
        public int Idpublications
        {
            get { return idpublications; }
            set { idpublications = value; }
        }

        public override void update(int ID, int idH, int idP)
        {
            string connection = "server=localhost; User Id=root; password=8milerun; database=csc330project2;";
            MySqlConnection proj2 = new MySqlConnection(connection);
            proj2.Open();
            if (idH != 0 && idP == 0)
            {
                var query = "UPDATE csc330project2.carriers SET idhouseholds = @house WHERE idcarriers = @ID";
                MySqlCommand cmd = new MySqlCommand(query, proj2);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@house", idH);
                cmd.ExecuteNonQuery();
            }
            else if (idH == 0 && idP != 0)
            {
                var query = "UPDATE csc330project2.carriers SET idpublications = @pub WHERE idcarriers = @ID";
                MySqlCommand cmd = new MySqlCommand(query, proj2);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@pub", idP);
                cmd.ExecuteNonQuery();
            }
            else if (idH != 0 && idP != 0)
            {
                var query = "UPDATE csc330project2.carriers SET idhouseholds = @house, idpublications = @pub WHERE idcarriers = @ID";
                MySqlCommand cmd = new MySqlCommand(query, proj2);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@house", idH);
                cmd.Parameters.AddWithValue("@pub", idP);
                cmd.ExecuteNonQuery();
            }
            else
            { }

            proj2.Close();
        }
    }

    class Publication
    {
        private string title;
        private char newsType;
        private string edition;
        private double price;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public char NewsType
        {
            get { return newsType; }
            set { newsType = value; }
        }

        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
