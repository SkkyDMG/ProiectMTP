using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProiectMTP
{ 
public partial class MainForm : Form
{
    private const string usersFilePath = "D:\\ProiectMTP\\ProiectMTP\\Utilizatori.xml";
    private List<User> users;

    public MainForm()
    {
        InitializeComponent();

        // Inițializare utilizatori
        users = new List<User>();

        UtilizatoriXML();

        // Afișare utilizatori în DataGridView
        RefreshUserGrid();
    }

    private void UtilizatoriXML()
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
                    string job = userNode.SelectSingleNode("job").InnerText;

                    User user = new User(numeUtilizator, parolaUtilizator,job);



                    users.Add(user);
            }
        }
    }

    private void RefreshUserGrid()
    {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            
        }

        private void SalvareUtilizatoriXML()
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

                XmlNode jobNode = xmlDoc.CreateElement("job");
                jobNode.InnerText = user.Job;
                userNode.AppendChild(jobNode);

                rootNode.AppendChild(userNode);
            }

            xmlDoc.Save(usersFilePath);
        }


        private void btnCautare_Click(object sender, EventArgs e)
        {
        string searchTerm = boxCautare.Text;

        // Utilizatori dupa criteriul de cautare
        List<User> filteredUsers = users.Where(u => u.NumeUtilizator.Contains(searchTerm)).ToList();

        dataGridView1.DataSource = null;
        dataGridView1.DataSource = filteredUsers;

            boxCautare.Text = string.Empty;
        }

    

        private void CuloareValidareUtilizator()
        {
            boxNewUtilizator.BackColor = Color.Red;
        }

        private void ResetCuloareValidareUtilizator()
        {
            boxNewUtilizator.BackColor = SystemColors.Window;
        }

        private void CuloareValidareParola()
        {
            boxNewParola.BackColor = Color.Red;
        }

        private void ResetCuloareValidareParola()
        {
            boxNewParola.BackColor = SystemColors.Window;
        }

        private void CuloareValidareJob()
        {
            boxJob.BackColor = Color.Red;
        }

        private void ResetCuloareValidareJob()
        {
            boxJob.BackColor = SystemColors.Window;
        }

        private bool ValidareUtilizator(string username)
        {
            // Verificare daca incepe cu o majuscula si daca nu contine cifre
            if (!char.IsUpper(username[0]) || (username.Any(char.IsDigit)))
            {
             
                MessageBox.Show("Utilizatorul trebuie sa inceapa cu majuscula si sa nu contina nici o cifra!");
                return false;
            }
                

            return true;
        }
        private bool ValidareParola(string password)
        {
            // Verifică lungimea minimă a parolei (6 caractere) , daca contine o majuscula si o cifra
            if (password.Length < 6 || (!password.Any(char.IsUpper)) || (!password.Any(char.IsDigit)))
            {
               
                MessageBox.Show("Parola trebuie sa contina cel putin 6 caractere, o majuscula si o cifra!");
                return false;
            }
            return true;
        }

        private bool ValidareJob(string job)
        {
            if (!char.IsUpper(job[0]) || (job.Any(char.IsDigit)))
            {
                
                MessageBox.Show("Jobul trebuie sa inceapa cu majuscula si sa nu contina nici o cifra!");
                return false;
            }
            return true;
        }
    private void btnAdaugare_Click(object sender, EventArgs e)
    {
        string username = boxNewUtilizator.Text;
        string password = boxNewParola.Text;
            string job = boxJob.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
                if (ValidareUtilizator(username) && ValidareParola(password))
                {
                    ResetCuloareValidareUtilizator();
                    ResetCuloareValidareParola();
                    ResetCuloareValidareJob();
                    User newUser = new User(username, password,job);


                    users.Add(newUser);

                    SalvareUtilizatoriXML();

                    RefreshUserGrid();

                    // Resetare campuri - text boxuri
                    boxNewUtilizator.Text = string.Empty;
                    boxNewParola.Text = string.Empty;
                    boxJob.Text = string.Empty;

                    MessageBox.Show("Utilizator adăugat cu succes!");
                }
                   
        }
        else
        {
                if (!ValidareUtilizator(username))
                    CuloareValidareUtilizator();
                if (!ValidareParola(password))
                    CuloareValidareParola();
                if (!ValidareJob(job))
                    CuloareValidareJob();
                MessageBox.Show("Introduceți un nume de utilizator și o parolă valide!");
        }
    }

        private void boxNewParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnCautareJob_Click(object sender, EventArgs e)
        {
            string cautareJob = boxCautareJob.Text;

            if (!string.IsNullOrEmpty(cautareJob))
            {
                List<User> matchingUsers = users.FindAll(user => user.Job == cautareJob);
                boxJob.Text = string.Empty;
                if (matchingUsers.Count > 0)
                {
                    // Afiseaza utilizatorii gasiti
                    dataGridView1.DataSource = matchingUsers;

                    boxJob.Text = string.Empty;
                }
                else
                {
                    
                    MessageBox.Show("Jobul nu exista!");
                }
            }
            else
            {
                MessageBox.Show("Introduceți un job pentru căutare.");
            }
            
        }
        private void btnStergere_Click(object sender, EventArgs e)
        {
            string username = boxStergere.Text;

            // Obtinerea utilizatorului introdus
            User userToDelete = users.FirstOrDefault(u => u.NumeUtilizator == username);


            if (userToDelete != null)
            {
                // Stergere utilizator din lista de utilizatori
                users.Remove(userToDelete);

                SalvareUtilizatoriXML();

                RefreshUserGrid();

                boxStergere.Text = string.Empty;

                MessageBox.Show("Utilizatorul a fost șters cu succes!");
            }
            else
                MessageBox.Show("Utilizatorul nu a fost găsit în listă!");

        }
    }
    
}

    public class User
    {
        public string NumeUtilizator { get; set; }
        public string ParolaUtilizator { get; set; }

        public string Job { get; set; }

        public User(string numeUtilizator, string parolaUtilizator, string job)
        {
            NumeUtilizator = numeUtilizator;
            ParolaUtilizator = parolaUtilizator;
            Job = job;
        }
    }
