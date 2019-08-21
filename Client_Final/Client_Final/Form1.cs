/*
 * @author Elena Chestnov
 */

using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace Client_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string user = "";
        Boolean admin = false;
        Boolean connected = false;
        Boolean selectuser = false;
        Boolean deletemode = false;
        Boolean fileopened = false;

        string filename = "";
        private string send(string msg)
        {
            string messagefromserver = "";
            try
            {
                if (msg != "")
                {
                    Int32 port = 13000;
                    IPAddress addressserver = IPAddress.Parse("127.0.0.1");
                    TcpClient client = new TcpClient(addressserver.ToString(), port);
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                    data = new byte[256];
                    int bytes = stream.Read(data, 0, data.Length);
                    messagefromserver = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                messagefromserver = null;
            }
            return messagefromserver;
        }
        private void viewusers()
        {
            try
            {
                openfile.Text = "Open Folder";
                deletemode = true;
                richTextBox1.Visible = true;
                listBox1.Items.Clear();
                string message = "userslist";
                string list = send(message);
                string line;
                int j = 0;
                while (j < list.Length)
                {
                    line = "";
                    while (list[j] != '#' && j < list.Length)
                        line += list[j++];
                    listBox1.Items.Add(line);
                    while (list[j] != '^' && j < list.Length)
                        j++;
                    j++;
                }
                richTextBox1.Text = "";
                groupBox4.Visible = true;
                label3.Text = "Choose user:";
                savefile.Text = "Delete File";
                selectuser = true;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text + "#" + textBox2.Text;
            string messagefromserver = send(message);
            user = textBox1.Text;
            textBox1.Text = messagefromserver;
            if (messagefromserver == "Connected.")
            {
                connected = true;
                if (user == "admin")
                    admin = true;
            }
            if (connected)
            {
                logout.Visible = true;
                groupBox1.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";

                if (admin == true)
                {
                    openfile.Text = "Open Folder";
                    viewusers();
                }
                else
                {
                    groupBox2.Visible = true;
                }
            }
            else
            {
                textBox2.Text = "";

            }
        }
        private void loadfile_Click(object sender, EventArgs e)
        {
            try
            { 
                label3.Text = "Choose file:";
                richTextBox1.Visible = true;
                listBox1.Items.Clear();
                string message = "allfiles.txt";
                string list = send(message);
                string line;
                int j = 0;
                while (j < list.Length)
                {
                    line = "";
                    while (list[j] != '^')
                        line += list[j++];
                    listBox1.Items.Add(line);
                    j++;
                }
                richTextBox1.Text = "";
                groupBox2.Visible = false;
                groupBox4.Visible = true;
                label3.Text = "Choose file:";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void openfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin == false || selectuser == false)
                {
                    filename = listBox1.SelectedItem.ToString();
                    string text = send(filename);
                    richTextBox1.Text = text;
                    groupBox4.Visible = false;
                    richTextBox1.Visible = true;
                    savefile.Visible = true;
                    closefile.Visible = true;
                    fileopened = true;
                }
                else if (selectuser == true)
                {
                    string list = send(listBox1.SelectedIndex.ToString());
                    string line;
                    int j = 0;
                    listBox1.Items.Clear();
                    while (j < list.Length)
                    {
                        line = "";
                        while (list[j] != '#' && j < list.Length)
                            line += list[j++];
                        listBox1.Items.Add(line);
                        while (list[j] != '^' && j < list.Length)
                            j++;
                        j++;
                    }
                    label3.Text = list;
                    selectuser = false;
                    listBox1.Items.Clear();
                    openfile.Text = "Open File";
                    list = send("allfiles.txt");
                    j = 0;
                    while (j < list.Length)
                    {
                        line = "";
                        while (list[j] != '^')
                            line += list[j++];
                        listBox1.Items.Add(line);
                        j++;
                    }
                    label3.Text = "Choose file:";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void newfile_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }
        private void createfile_Click(object sender, EventArgs e)
        {
            try
            {
                    filename = textBox3.Text;
                    string msg = send(filename);
                    if (msg != "exists")
                    {
                        groupBox3.Visible = false;
                        richTextBox1.Visible = true;
                        savefile.Visible = true;
                        closefile.Visible = true;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Replace file " + filename + " ?", "File already exists", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            send("replace");
                            groupBox3.Visible = false;
                            richTextBox1.Visible = true;
                            savefile.Visible = true;
                            closefile.Visible = true;
                        }
                        else
                        {
                            dialogResult = MessageBox.Show("Open exisiting file " + filename + " ?", "File already exists", MessageBoxButtons.OKCancel);
                            if (dialogResult == DialogResult.OK)
                            {
                                string text = send("open");
                                richTextBox1.Text = text;
                                groupBox3.Visible = false;
                                richTextBox1.Visible = true;
                                savefile.Visible = true;
                                closefile.Visible = true;
                            }
                            else
                                textBox3.Text = "";
                        }
                    }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void savefile_Click(object sender, EventArgs e) //deletefile on admin==true
        {
            try
            {
                if (admin == false || deletemode == false)
                {
                    String text = richTextBox1.Text;
                    send(text);
                }
                else
                {
                    send("delete");
                    richTextBox1.Text = "";
                    richTextBox1.Visible = false;
                    savefile.Visible = false;
                    closefile.Visible = false;
                    groupBox4.Visible = true;
                    viewusers();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void closefile_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin == false || deletemode == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Save changes to " + filename + " ?", "Closing file", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        String text = richTextBox1.Text;
                        send(text);
                    }
                    if (admin == false)
                    {
                        groupBox2.Visible = true;
                        richTextBox1.Visible = false;
                    }
                }
                else if (admin == true)
                {
                    groupBox4.Visible = true;
                    viewusers();
                }
                send("close");
                richTextBox1.Text = "";
                textBox3.Text = "";
                savefile.Visible = false;
                closefile.Visible = false;
                fileopened = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            if (admin == false)
            {
                send("back");
                groupBox2.Visible = true;
                groupBox4.Visible = false;
                richTextBox1.Visible = false;
            }
            else if (selectuser == false)
            {
                viewusers();
            }

        }
        private void logout_Click(object sender, EventArgs e)
        {
            if (fileopened == true)
                if (admin == false || deletemode == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Save changes to " + filename + " ?", "Closing file", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        String text = richTextBox1.Text;
                        send(text);
                    }
                }
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox1.Visible = true;

            richTextBox1.Visible = false;
            savefile.Visible = false;
            closefile.Visible = false;
            logout.Visible = false;
            user = "";
            admin = false;
            connected = false;
            selectuser = false;
            deletemode = false;
            savefile.Text = "Save File";
            openfile.Text = "Open File";
            filename = "";
            send("logout");
        }
       
    }
}
    

