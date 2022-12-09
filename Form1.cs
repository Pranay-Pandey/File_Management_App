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
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace FileTaggingApp
{
    public partial class Form1 : Form
    {
        private string filePath = "C://";
        private bool isFile = false;
        private string currentlySelectedItem = "";
        private string temppfilepath = "";
        private static string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=testing;Integrated Security=True";
        private static string tableName = "testTable2";
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Initializing the application...");
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM "+ tableName, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1}",
                            rdr[0], rdr[1]);
                    }
                }
                conn.Close();
                
                Console.WriteLine("Success FUll");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Unsucessful");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filepathtextbox.Text = filePath;
            loadfilesandDirectories(); 
        }

        private void loadfilesandDirectories()
        {
            DirectoryInfo filelist;
            string tempFilePath = "";
            FileAttributes fileAttr; 
            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItem;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    filenamelabel.Text = fileDetails.Name;  
                    filetypelabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath); 
                    Process.Start(tempFilePath);    
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                    
                }
                if((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    filelist = new DirectoryInfo(filePath);
                    FileInfo[] files = filelist.GetFiles();
                    DirectoryInfo[] dirs = filelist.GetDirectories();
                    string fileExtension = ""; 
                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 5);

                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 2);

                                break;
                            case ".MP4":
                            case ".MVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 6);

                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 7);

                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 1);

                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 4);

                                break;
                            default:
                                listView1.Items.Add(files[i].Name, 8);
                                break;


                        }
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name,3);
                    }
                }
                else
                {
                    filenamelabel.Text = this.currentlySelectedItem;
                }
                
            }
            catch (Exception e)
            {

            }
        }

        private void loadButtonAction()
        {
            removeBackSlash(); 
            filePath = filepathtextbox.Text;
            loadfilesandDirectories();
            isFile = false;
        }
        private void gobtn_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItem = e.Item.Text;
            try
            {
                FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItem);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    isFile = false;
                    filepathtextbox.Text = filePath + "/" + currentlySelectedItem;
                    temppfilepath = filepathtextbox.Text;
                }
                else
                {
                    isFile = true;
                    temppfilepath = filePath + "/" + currentlySelectedItem;
                }
            }
            catch (Exception ef)
            {

            }
           
        }
        public void removeBackSlash()
        {
            string path = filepathtextbox.Text; 
            if(path.LastIndexOf("/") == path.Length - 1)
            {
                filepathtextbox.Text = path.Substring(0, path.Length - 1);
            }
        }
        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = filepathtextbox.Text; 
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false; 
                filepathtextbox.Text = path;
                removeBackSlash(); 
            }catch(Exception e)
            {

            }
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        private void addTagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tagName1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // tag 1 click handle  Work
            string currentFilePath = temppfilepath;
            if (isFile)
            {
                FileInfo f = new FileInfo(currentFilePath);
             
            }
            else
            {

            }
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {


        }
    }
}
