using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RestSharp;
using Newtonsoft.Json;
using WindowsFormsApp2;
using System.Security.Cryptography;
namespace employee_tracker
{
    public partial class Form2 : Form
    {
        string email = null, password = null;
        string link = "http://192.168.0.6:3000/signup";
        bool checkpoint = false;
        public static string user_name = "";
        public static string _tokens = "";
        public static string login_email = "";
        public static string clientApiLink = "http://192.168.0.6:3000";
        

        public Form2()
        {

            InitializeComponent();
            passwordTextBox.Text = "";
            passwordTextBox.PasswordChar = '*';
            
        }
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link);
        }
        public class Product
        {
            public string logged_in { get; set; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            email = emailTextBox.Text;

            password = MD5Hash(passwordTextBox.Text);

            if (email == "" || IsValidEmail(email) == false)
            {
                MessageBox.Show("Invalid Email Address", "Warning");
                checkpoint = false;
            }
            else {
                checkpoint = true;
            }
            if (password == "")
            {
                MessageBox.Show("Invalid Password", "Warning");
                checkpoint = false;
            }
            else {
                checkpoint = true;
            }
            if (checkpoint == true) {
                var client = new RestClient(clientApiLink);
                // client.Authenticator = new HttpBasicAuthenticator(username, password);
                var request = new RestRequest("login_user/"+email+"/"+password);
               // request.AddParameter("email", email);
                //request.AddParameter("password", password);
                request.AddHeader("Access-Control-Allow-Origin", "*");

                request.AddHeader("Content-Type", "multipart/form-data");


                //request.AddFile("file", path);
                var response = client.Get(request);
                
                string content = response.Content; // Raw content as string
                
                root jsonData = JsonConvert.DeserializeObject<root>(content);
                if (jsonData != null)
                {
                    if (jsonData.logged_in == true)
                    {
                        user_name = jsonData.user_data.name;
                        _tokens = jsonData.user_data._tokens;
                        login_email = jsonData.user_data.email;
                        MessageBox.Show("Logged In Successfully");
                        this.Hide();
                        var Form1 = new Form1();
                        Form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email or Password incorrect");
                    }
                }
                else {
                    MessageBox.Show("Please check your internet");
                }
                   

            }
           
        }
    }
}
