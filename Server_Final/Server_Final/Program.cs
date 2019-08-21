/*
 * @author Elena Chestnov
 */

using System;
using System.IO;
using System.Net.Sockets;
using System.Net;
namespace Server_Final
{
    class Program
    {
        static string user = "";
        static Boolean admin = false;
        static Boolean connected = false;
        static Boolean loadfile = false;
        static Boolean loadfolder = false;
        static Boolean fileopened = false;
        static string filename = "";
        static string path = "";

        static Boolean connect(string msg)
        {
            StreamReader sr = new StreamReader("users.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
                if (line == msg)
                {
                    sr.Close();
                    return true;
                }
            sr.Close();
            return false;
        }
        static Boolean exists()
        {
            StreamReader sr = new StreamReader(path + user + @"\" + "allfiles.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
                if (line == filename)
                {
                    sr.Close();
                    return true;
                }
            sr.Close();
            return false;
        }
        static void addfile()
        {
            try
            {
                StreamReader sr = new StreamReader(path + user + @"\" + "allfiles.txt");
                string line;
                string newtext = "";
                while ((line = sr.ReadLine()) != null)
                    if (line != filename)
                        newtext += line + "^";
                sr.Close();
                FileStream f = new FileStream(path + user + @"\" + "allfiles.txt", FileMode.Create);
                StreamWriter s = new StreamWriter(f);
                int j = 0;
                newtext += filename + "^";
                while (j < newtext.Length)
                {
                    line = "";
                    while (newtext[j] != '^')
                        line += newtext[j++];
                    s.WriteLine(line);
                    j++;
                }
                s.Close();
                f.Close();

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    static void deletefile()
        {
            try
            {
                StreamReader sr = new StreamReader(path + user + @"\" + "allfiles.txt");
                string line;
                string newtext = "";
                while ((line = sr.ReadLine()) != null)
                    if (line != filename)
                        newtext += line + "^";
                sr.Close();
                FileStream f = new FileStream(path + user + @"\" + "allfiles.txt", FileMode.Create);
                StreamWriter s = new StreamWriter(f);
                int j = 0;
                while (j < newtext.Length)
                {
                    line = "";
                    while (newtext[j] != '^')
                        line += newtext[j++];
                    s.WriteLine(line);
                    j++;
                }
                s.Close();
                f.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                TcpListener server = new TcpListener(localAddr, port);
                server.Start();
                Console.WriteLine("address server : " + server.LocalEndpoint.ToString());
                byte[] bytes = new byte[256];
                string data = null;
                Console.WriteLine("Waiting to connection.......");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    data = null;
                    NetworkStream stream = client.GetStream();
                    int i, j = 0;
                    i = stream.Read(bytes, 0, bytes.Length);

                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    if (!connected) //login
                    {
                        if (connect(data))
                        {
                            while (data[j] != '#')
                                user += data[j++];
                            Console.WriteLine(user + " is connected.");
                            string data1 = "Connected.";
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data1);
                            stream.Write(msg, 0, msg.Length);
                            if (user == "admin")
                            {
                                admin = true;
                                user = "";
                            }
                            path = Path.Combine(Environment.CurrentDirectory) + @"\";
                            connected = true;
                        }
                        else
                        {
                            string data1 = "Access denied.";
                            Console.WriteLine(data1);
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data1);
                            stream.Write(msg, 0, msg.Length);
                        }
                    }
                    else if (data == "logout") //logging out
                    {
                        if (admin==false)
                            Console.WriteLine(user+" logged out");
                        else
                            Console.WriteLine("admin logged out");
                        user = "";
                        admin = false;
                        connected = false;
                        loadfile = false;
                        loadfolder = false;
                        fileopened = false;
                        filename = "";
                        path = "";
                    }
                    else if (data == "allfiles.txt") //showing list of all user's files
                    {
                        string data1 = "";
                        try
                        {
                            loadfile = true;
                            Console.WriteLine("Openning " + data);
                            StreamReader sr = new StreamReader(path + user + @"\" + data);
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                data1 += line;
                                data1 += "^";
                            }
                            sr.Close();
                        }
                        catch
                        {
                            data1 = "Error while loading" + data;
                        }
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data1);
                        stream.Write(msg, 0, msg.Length);
                    }
                    else if (data == "replace") //saving changes to file
                    {
                        fileopened = true;
                    }
                    else if (data == "back") //go back
                    {
                        loadfile = false;
                    }
                    else if (data == "close") //closing file
                    {
                        Console.WriteLine("Closing " + filename);
                        loadfile = false;
                        fileopened = false;
                        filename = "";
                    }
                    else if (data == "delete") //deleting file
                    {
                        loadfile = false;
                        fileopened = false;
                        File.Delete(path + user + @"\" + filename);
                        deletefile();
                        filename = "";
                    }
                    else if (data == "userslist" && admin == true) //opening users file
                    {
                        string data1 = "";
                        try
                        {
                            loadfolder = true;
                            Console.WriteLine("Openning " + "users.txt");
                            StreamReader sr = new StreamReader(path  + "users.txt");
                            string line;
                            sr.ReadLine();
                            while ((line = sr.ReadLine()) != null)
                            {
                                data1 += line;
                                data1 += "^";
                            }
                            sr.Close();
                        }
                        catch
                        {
                            data1 = "Error while loading" + data;
                        }
                       
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data1);
                        stream.Write(msg, 0, msg.Length);
                    }
                    else if (loadfolder&&admin==true) //change path
                    {
                        loadfolder = false;
                        j = int.Parse(data);
                        string data1 = "";
                        StreamReader sr = new StreamReader(path + "users.txt");
                        sr.ReadLine();
                        while (j > 0) { sr.ReadLine(); j--; }
                        data1 = sr.ReadLine();
                        sr.Close();
                        j = 0;
                        user = "";
                        while (data1[j] != '#')
                            user += data1[j++];
                    }
                    else if (loadfile == true|| data == "open") //opening an existing file
                    {
                        fileopened = true;
                        loadfile = false;
                        if (data != "open") //if not after propmt
                            filename = data;
                        Console.WriteLine("Openning " + filename);
                        string data1 = "";
                        StreamReader sr = new StreamReader(path + user + @"\" + filename);
                        data1 = sr.ReadToEnd();
                        sr.Close();
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data1);
                        stream.Write(msg, 0, msg.Length);
                    }
                    else if (fileopened) //saving changes to file
                    {
                        Console.WriteLine("Updating " + filename);
                        FileStream f = new FileStream(path + user + @"\" + filename, FileMode.Create);
                        StreamWriter s = new StreamWriter(f);
                        s.WriteLine(data);
                        s.Close();
                        f.Close();
                    }
                    else //new file
                    {
                        filename = data + ".rtf";
                        if (exists() == true) //prompt user
                        {
                            Console.WriteLine(filename + " Already exists");
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes("exists");
                            stream.Write(msg, 0, msg.Length);
                        }
                        else //adding a new file to the list
                        {
                            fileopened = true;
                            Console.WriteLine("Creating " + filename);
                            FileStream f = new FileStream(path + user + @"\" + filename, FileMode.Create);
                            StreamWriter s = new StreamWriter(f);
                            s.WriteLine("");
                            s.Close();
                            f.Close();
                            addfile();
                        }
                    }
                    client.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Console.Read();
        }
    }
}
