using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace gestionContacts
{
    public partial class Form1 : Form
    {
        List<Contact>? _contacts = [];

        string path = "C:\\Users\\npelleschi\\source\\repos\\gestionContacts\\gestionContacts";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //open JSON file
            string file = path + "\\contacts.json";

            //read JSON file
            string json = File.ReadAllText(@file);

            //store reading data in a list
            _contacts = JsonConvert.DeserializeObject<List<Contact>>(json);

            if (_contacts != null)
            {
                dataGridView1.DataSource = _contacts;
            }

        }

        private void ajoutContact_Click(object sender, EventArgs e)
        {
            //open JSON file
            string file = path + "\\contacts.json";

            //Create the new contact
            Contact newContact = new Contact
            {
                firstname = newFirstname.Text,
                lastname = newLastname.Text,
                phone = newPhone.Text
            };

            if (_contacts != null)
            {
                _contacts.Add(newContact); //Add the new contact in the existing list
            }
            else
            {
                _contacts = [newContact]; //create the list and Add the new contact
            }

            string json = JsonConvert.SerializeObject(_contacts); //Convert in JSON before write in file

            File.WriteAllText(@file, json); //Write JSON in file

            Form1_Load(sender, e); //Refresh the dataGridView

            //Clear new Contact
            newFirstname.Text = "";
            newLastname.Text = "";
            newPhone.Text = "";

        }

        private void delete_Click(object sender, EventArgs e)
        {
            //open JSON file
            string file = path + "\\contacts.json";

            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                _contacts.RemoveAt(rowIndex);

                string json = JsonConvert.SerializeObject(_contacts); //Convert in JSON before write in file

                File.WriteAllText(@file, json); //Write JSON in file

                Form1_Load(sender, e); //Refresh the dataGridView
            }

        }
    }
}
