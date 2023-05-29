using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System;
using System.IO;
using System.Linq;

namespace ProiectMTP
{ 
public partial class MainForm : Form
{
    private const string usersFilePath = "Utilizatori.xml";
    private List<User> users;

    public MainForm()
    {
        InitializeComponent();

        // Inițializare utilizatori
        users = new List<User>();

        LoadUsersFromXml();

        // Afișare utilizatori în DataGridView
        RefreshUserGrid();
    }

    private void LoadUsersFromXml()
    {
        if (File.Exists(usersFilePath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(usersFilePath);

            XmlNodeList userNodes = xmlDoc.SelectNodes("//Utilizator");

            foreach (XmlNode userNode in userNodes)
            {
                    string numeUtilizator = userNode.SelectSingleNode("numeUtilizator").InnerText;
                    string parolaUtilizator = userNode.SelectSingleNode("parolaUtilizator").InnerText;

                    User user = new User(numeUtilizator, parolaUtilizator);



                    users.Add(user);
            }
        }
    }

    private void RefreshUserGrid()
    {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            /* dataGridView1.SuspendLayout();

             // Golire DataGridView
             dataGridView1.Rows.Clear();

             // Adăugare utilizatori în DataGridView
             foreach (User user in users)
             {
                 dataGridView1.Rows.Add(user.NumeUtilizator, user.ParolaUtilizator);
             }

             dataGridView1.ResumeLayout();*/
        }

        private void SaveUsersToXml()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(xmlDeclaration);

            XmlNode rootNode = xmlDoc.CreateElement("Utilizatori");
            xmlDoc.AppendChild(rootNode);

            foreach (User user in users)
            {
                XmlNode userNode = xmlDoc.CreateElement("Utilizator");

                XmlNode usernameNode = xmlDoc.CreateElement("numeUtilizator");
                usernameNode.InnerText = user.NumeUtilizator;
                userNode.AppendChild(usernameNode);

                XmlNode passwordNode = xmlDoc.CreateElement("parolaUtilizator");
                passwordNode.InnerText = user.ParolaUtilizator;
                userNode.AppendChild(passwordNode);

                rootNode.AppendChild(userNode);
            }

            xmlDoc.Save(usersFilePath);
        }


        private void btnCautare_Click(object sender, EventArgs e)
    {
        string searchTerm = boxCautare.Text;

        // Filtrare utilizatori după criteriul de căutare
        List<User> filteredUsers = users.Where(u => u.NumeUtilizator.Contains(searchTerm)).ToList();

        dataGridView1.DataSource = null;
        dataGridView1.DataSource = filteredUsers;

            boxCautare.Text = string.Empty;
        }

    private void btnStergere_Click(object sender, EventArgs e)
    {
            string username=boxStergere.Text;
        //if (dataGridView1.SelectedRows.Count > 0)
        //{
                // Obținerea utilizatorului selectat
                User userToDelete = users.FirstOrDefault(u => u.NumeUtilizator == username);
                //User selectedUser = dataGridView1.SelectedRows[0].DataBoundItem as User;

            //string numeUtilizator = userToDelete.NumeUtilizator;

            if(userToDelete !=null)
                {
                    // Ștergere utilizator din lista de utilizatori
                    users.Remove(userToDelete);

                    SaveUsersToXml();

                    RefreshUserGrid();

                    boxStergere.Text = string.Empty;

                    MessageBox.Show("Utilizatorul a fost șters cu succes!");
                }
                else
                    MessageBox.Show("Utilizatorul nu a fost găsit în listă!");



            //}
    }

    

        private void btnValidare_Click(object sender, EventArgs e)
        {
            string username = boxValidare1.Text;
            string password = boxValidare2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Validare reușită! Utilizatorul și parola sunt introduse corect.");
            }
            else
            {
                MessageBox.Show("Validare eșuată! Vă rugăm să completați toate câmpurile.");
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
    {
        string username = boxNewUtilizator.Text;
        string password = boxNewParola.Text;

        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
            User newUser = new User(username, password);


                users.Add(newUser);

            SaveUsersToXml();

            RefreshUserGrid();

                // Resetare câmpuri
                boxNewUtilizator.Text = string.Empty;
                boxNewParola.Text = string.Empty;

            MessageBox.Show("Utilizator adăugat cu succes!");
        }
        else
        {
            MessageBox.Show("Introduceți un nume de utilizator și o parolă valide!");
        }
    }

        private void boxNewParola_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public string NumeUtilizator { get; set; }
        public string ParolaUtilizator { get; set; }

        public User(string numeUtilizator, string parolaUtilizator)
        {
            NumeUtilizator = numeUtilizator;
            ParolaUtilizator = parolaUtilizator;
        }
    }

}