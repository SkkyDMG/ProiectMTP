using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace ProiectMTP
{
    public partial class LoginForm : Form
    {
        private const string usersFilePath = "D:\\ProiectMTP\\ProiectMTP\\Utilizatori.xml";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string numeUtilizator = boxNume.Text;
            string parolaUtilizator = boxParola.Text;

            if (string.IsNullOrEmpty(boxNume.Text))
            {
                MessageBox.Show("Introduceți un nume de utilizator!");
                return;
            }

            if (string.IsNullOrEmpty(boxParola.Text))
            {
                MessageBox.Show("Introduceți o parolă!");
                return;
            }

            // Verificare autentificare utilizator
            bool isAuthenticated = AuthenticateUser(numeUtilizator, parolaUtilizator);


            if (isAuthenticated)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nume de utilizator sau parolă incorecte!");
            }
        }
        // Verificare utilizator și parolă în fișierul XML
        private bool AuthenticateUser(string numeUtilizator, string parolaUtilizator)
        {
            
            XmlDocument xmlDoc = new XmlDocument();

            using (StreamReader reader =new StreamReader(usersFilePath))
            {
                string xmlString = reader.ReadToEnd();
                xmlDoc.LoadXml(xmlString);
            }
            xmlDoc.Load(usersFilePath);

            XmlNodeList userNodes = xmlDoc.SelectNodes("//Utilizator");

            foreach (XmlNode userNode in userNodes)
            {
                string storednumeUtilizator = userNode.SelectSingleNode("numeUtilizator").InnerText;
                string storedparolaUtilizator = userNode.SelectSingleNode("parolaUtilizator").InnerText;

                if (numeUtilizator == storednumeUtilizator && parolaUtilizator == storedparolaUtilizator)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
   