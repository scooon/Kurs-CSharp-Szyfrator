﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Effortless.Net.Encryption;
using Newtonsoft.Json;

namespace SzyfratorUI
{
    public partial class Szyfrator : Form
    {
        byte[] key = new byte[] { 18, 1, 62, 248, 116, 173, 190, 231, 129, 217, 29, 198, 214, 198, 110, 37, 137, 10, 7, 10, 224, 107, 20, 147, 20, 17, 254, 231, 155, 38, 111, 6 };
        byte[] iv = new byte[] { 251, 206, 128, 185, 18, 70, 175, 117, 81, 51, 116, 212, 182, 23, 144, 197, 95, 225, 96, 78, 148, 122, 191, 90, 95, 232, 52, 104, 203, 11, 146, 72 };
        string fileContent = string.Empty;
        string filePath = string.Empty;
        List<Passwords> passwords;




        public Szyfrator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte[] key = Bytes.GenerateKey();
            //byte[] iv = Bytes.GenerateIV();



            try
            {


                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
                    openFileDialog.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.Title = "Szyfrator - Otwórz plik";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }

                        Content.Text = Strings.Decrypt(fileContent, key, iv);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wybrany plik, nie jest plikiem programu Szyfrator!", "Niewłaściwy plik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }

        private void Szyfrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {

                Stream myStream;


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
                saveFileDialog1.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.Title = "Szyfrator - Zapisz plik";
                saveFileDialog1.RestoreDirectory = true;

                byte[] buffer = Encoding.UTF8.GetBytes(Strings.Encrypt(Content.Text, key, iv));

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Write(buffer, 0, buffer.Length);
                        myStream.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Problem z zapisem pliku!", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string json = "[{'index':0,'name':'Nazwa','login':'Test','password':'5fd7a17eee119039335adb07','email':'Test@gmail.com','notes':'Jakieś notatki'},{'index':1,'name':'Nazwa','login':'Test','password':'5fd7a17eec845a3bba6cc10c','email':'Test@gmail.com','notes':'Jakieś notatki'},{ 'index':2,'name':'Nazwa','login':'Test','password':'5fd7a17e22ab30886f105c9f','email':'Test@gmail.com','notes':'Jakieś notatki'},{ 'index':3,'name':'Nazwa','login':'Test','password':'5fd7a17e0befe84e2a1739b1','email':'Test@gmail.com','notes':'Jakieś notatki'},{'index':4,'name':'Nazwa','login':'Test','password':'5fd7a17eaca98a53fa8cbbdf','email':'Test@gmail.com','notes':'Jakieś notatki'},{'index':5,'name':'Nazwa','login':'Test','password':'5fd7a17e04b2bc3004e66621','email':'Test@gmail.com','notes':'Jakieś notatki'}]";
            passwords = JsonConvert.DeserializeObject<List<Passwords>>(json);

            string jsonout = JsonConvert.SerializeObject(passwords);

            Console.WriteLine(jsonout);

            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.GridLines = true;
            listView.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            /*imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage1.bmp"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage2.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage1.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage2.bmp"));*/

            //Assign the ImageList objects to the ListView.
            listView.LargeImageList = imageListLarge;
            listView.SmallImageList = imageListSmall;

            // Add the ListView to the control collection.
            this.Controls.Add(listView);

        }
    }
}
