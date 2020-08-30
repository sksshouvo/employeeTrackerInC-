using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using employee_tracker;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int timeSec, timeMin, timehour, totalSecond, targetSeconds, goOntime;
        bool isActive;
        upload_to_server new_var = new upload_to_server();

        public Form1()
        {   
            InitializeComponent();
            ////var Form2 = new Form2();
            var sql = new sqllite_class();
         
            if (Form2.user_name != "") {
                nameTextBox.Text = Form2.user_name;
            }
            //taskPanel.BackColor = Color.FromArgb(100, Color.White);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taskEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = true;
            
            if (taskEntry.Text != "Write Task Details" && nameTextBox.Text!="Write Your Name Here" && comboBox1.Text !="Select one")
            {
                timer1.Start();
                startButton.Enabled = false;
                startButton.BackColor = Color.Gray;
                startButton.ForeColor = Color.White;
                if (!taskList.Items.Contains(taskEntry.Text)) {
                    taskList.Items.Add(taskEntry.Text);
                }
            }
            else {
                MessageBox.Show("Invalid Text Details", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isActive = false;
            startButton.Enabled = true;
            startButton.BackColor = Color.DodgerBlue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            timeSec = 0;
            timeMin = 0;
            timehour = 0;
            totalSecond = 0;
            targetSeconds = 10;
            isActive = false;

            
            new_var.checkFiles();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            
            if (isActive==true) {
                totalSecond++;
                goOntime++;
                timeSec++;
                if ((timeSec % 2) == 0)
                {
                    dot.Text = "";
                }
                else {
                    dot.Text = ":";
                }
                Console.WriteLine(totalSecond);
                if (timeSec >= 60) {
                    timeSec = 0;
                    timeMin++;
                }
                if (timeMin >= 60) {
                    timeMin = 0;
                    timehour++;
                }
                if (totalSecond == targetSeconds) {
                    takeScreenShot();
                    totalSecond = 0;
                }
                
            }

        DrawTime();
        }

        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var settings_form = new settings_form();
            settings_form.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            var settings_form = new settings_form();
            settings_form.Show();
        }

        private void taskList_DoubleClick(object sender, EventArgs e)
        {
            taskList.Items.RemoveAt(taskList.SelectedIndex);
        }

        private void logout_button_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click to logout", logout_button);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

        private void DrawTime()
        {
            labelHour.Text = String.Format("{0:00}", timehour);
            labelMin.Text = String.Format("{0:00}", timeMin);
        }
        private void takeScreenShot() {
            string path = @"C:\\Users\\Public\\Pictures\\it corner online\\media\\"+ Form2.login_email+"\\";
            if (!Directory.Exists(path)) {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height );
            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(0, 0, 0, 0, bm.Size);
            var file_full_path = path + Stopwatch.GetTimestamp() + ".png";
            bm.Save(file_full_path);
            new_var.checkFiles();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
