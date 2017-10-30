using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerialCamouflage
{
    public partial class ProjectTextManager : Form
    {
        OpenFileDialog fbd = new OpenFileDialog();
        FolderBrowserDialog fd = new FolderBrowserDialog();
        string settingMainFileName = "fileLocation.txt";
        string settingOutputFileName = "outPutLocation.txt";
        //string settingJsonFileName = "mapJson.txt";

        //JObject mapJson;
        List<JObject> listJson = new List<JObject>();


        string excelFile = "";
        string outputLocation = "";
        //string jsonLocation = "";

        public ProjectTextManager()
        {
            InitializeComponent();

            try
            {
                StreamReader sr = new StreamReader(settingMainFileName, Encoding.Default);
                excelFile = sr.ReadLine();
                sr.Close();
                fbd.FileName = excelFile;
                btnFileSource.Text = excelFile;
            }
            catch (Exception ex)
            {

            }

            try
            {
                StreamReader sr = new StreamReader(settingOutputFileName, Encoding.Default);
                outputLocation = sr.ReadLine();
                sr.Close();
                fd.SelectedPath = outputLocation;
                btnOutput.Text = outputLocation;
            }
            catch (Exception ex)
            {

            }

            //try
            //{
            //    StreamReader sr = new StreamReader(settingJsonFileName, Encoding.Default);
            //    jsonLocation = sr.ReadLine();
            //    sr.Close();
            //    btnMapJson.Text = jsonLocation;
            //    readJson(jsonLocation);
            //}
            //catch (Exception ex)
            //{

            //}

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtContent.Text = encryption(txtContent.Text);
        }

        private void btnFileSource_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();

            if (fbd.FileName != "")
            {
                btnFileSource.Text = fbd.FileName;
                excelFile = fbd.FileName;
                StreamWriter sw = new StreamWriter(settingMainFileName, false, Encoding.UTF8);
                sw.WriteLine(excelFile);
                sw.Close();
            }
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();

            if (fd.SelectedPath != "")
            {
                outputLocation = fd.SelectedPath;
                btnOutput.Text = outputLocation;
                StreamWriter sw = new StreamWriter(settingOutputFileName, false, Encoding.UTF8);
                sw.WriteLine(outputLocation);
                sw.Close();
            }
        }

        #region Data Encryption
        static string keySystem = "LinchAndWarmbugLoveAvaLiberty777";
        static string keyAlpha = "WarmbugFuckAvaLibertyveryhard666";
        public string encryption(string _context)
        {
            string result = "";
            int keyCode = Int32.Parse(cb.Text);
            try
            {
                byte[] KeyArray = null;
                switch (keyCode)
                {
                    case 1:
                        KeyArray = UTF8Encoding.UTF8.GetBytes(keySystem);

                        break;
                    case 2:
                        KeyArray = UTF8Encoding.UTF8.GetBytes(keyAlpha);
                        break;
                }
                RijndaelManaged rm = new RijndaelManaged();
                rm.Key = KeyArray;
                rm.Mode = CipherMode.ECB;
                rm.Padding = PaddingMode.PKCS7;
                ICryptoTransform ct = rm.CreateEncryptor();

                byte[] targetContent = UTF8Encoding.UTF8.GetBytes(_context);
                byte[] resultArray = ct.TransformFinalBlock(targetContent, 0, targetContent.Length);
                result = Convert.ToBase64String(resultArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
        private string decryption(string _context)
        {
            int keyCode = Int32.Parse(cb.Text);

            string result = "";
            try
            {
                byte[] KeyArray = null;
                switch (keyCode)
                {
                    case 1:
                        KeyArray = UTF8Encoding.UTF8.GetBytes(keySystem);

                        break;
                    case 2:
                        KeyArray = UTF8Encoding.UTF8.GetBytes(keyAlpha);
                        break;
                }
                RijndaelManaged rm = new RijndaelManaged();
                rm.Key = KeyArray;
                rm.Mode = CipherMode.ECB;
                rm.Padding = PaddingMode.PKCS7;
                ICryptoTransform ct = rm.CreateDecryptor();

                byte[] txtContent = Convert.FromBase64String(_context);
                byte[] txtResult = ct.TransformFinalBlock(txtContent, 0, txtContent.Length);
                result = UTF8Encoding.UTF8.GetString(txtResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtContent.Text = decryption(txtContent.Text);
        }


        #endregion

        private void generateConversation(string lang, int idx)
        {
            StringBuilder sb = new StringBuilder();

            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile + ";" +
                          @"Extended Properties='Excel 8.0;IMEX=1;HDR=No;ImportMixedTypes=Text;'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [對話$]", connection);
                bool isProcess = false;
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string firstLine = "";
                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            if (isProcess)
                            {
                                sb.Append("[END]" + Environment.NewLine);
                            }
                            else
                            {
                                isProcess = true;
                            }

                            firstLine = "[" + dr[0].ToString() + "]";
                        }
                        string data = firstLine +
                            dr[1].ToString() + "\t" +
                            dr[2 + idx].ToString() + "\t" +
                            dr[5].ToString() + "\t" +
                            dr[6 + +idx].ToString() + Environment.NewLine;
                        sb.Append(data);
                    }
                }

                command = new OleDbCommand("select * from [門鎖旗標$]", connection);
                isProcess = false;
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string firstLine = "";
                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            if (isProcess)
                            {
                                sb.Append("[END]" + Environment.NewLine);
                            }
                            else
                            {
                                isProcess = true;
                            }

                            firstLine = "[" + dr[0].ToString() + "]";
                        }
                        string data = firstLine +
                            dr[1].ToString() + "\t" +
                            dr[2 + idx].ToString() + "\t" +
                            dr[5].ToString() + "\t" +
                            dr[6 + +idx].ToString() + Environment.NewLine;
                        sb.Append(data);
                    }
                }
                sb.Append("[END]" + Environment.NewLine);//???
                connection.Close();


                //MapDatabase.json
                readJson(lang);
                for (int i = 0; i < listJson.Count; i++)
                {
                    if (listJson[i]["Right Door"] != null)
                    {
                        string rightDoorHint = "[" + listJson[i]["name"] + " Right Door" + "]" + Environment.NewLine +
                                "\t" +
                                "\t" +
                                "\t" +
                                listJson[i]["Right Door"]["Hint"] + "\t" + Environment.NewLine;
                        sb.Append(rightDoorHint + "[END]" + Environment.NewLine);

                        string rightDoorUnlocked = "[" + listJson[i]["name"] + " Right Door Unlocked" + "]" + Environment.NewLine +
                                "\t" +
                                "\t" +
                                "\t" +
                                listJson[i]["Right Door"]["Unlocked"] + "\t" + Environment.NewLine;
                        sb.Append(rightDoorUnlocked + "[END]" + Environment.NewLine);
                    }
                    if (listJson[i]["Down Door"] != null)
                    {
                        string downDoorHint = "[" + listJson[i]["name"] + " Down Door" + "]" + Environment.NewLine +
                            "\t" +
                            "\t" +
                            "\t" +
                            listJson[i]["Down Door"]["Hint"] + "\t" + Environment.NewLine;
                        sb.Append(downDoorHint + "[END]" + Environment.NewLine);

                        string downDoorUnlocked = "[" + listJson[i]["name"] + " Down Door Unlocked" + "]" + Environment.NewLine +
                               "\t" +
                               "\t" +
                               "\t" +
                               listJson[i]["Down Door"]["Unlocked"] + "\t" + Environment.NewLine;
                        sb.Append(downDoorUnlocked + "[END]" + Environment.NewLine);
                    }
                }
            }

            txtContent.Text = sb.ToString();
            string outputFolder = fd.SelectedPath + "\\" + lang;
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            string outputFilePath = outputFolder + "\\" + "Conversation.txt";
            StreamWriter sw = new StreamWriter(outputFilePath);
            sw.Write(sb.ToString());
            sw.Close();

            listJson.Clear();

        }
        private void generateCredit(string lang, int idx)
        {
            StringBuilder sb = new StringBuilder();

            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile + ";" +
                          @"Extended Properties='Excel 8.0;IMEX=1;HDR=No;ImportMixedTypes=Text;'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Credit$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string data = dr[0].ToString() + dr[1 + idx].ToString() + Environment.NewLine;
                        sb.Append(data);
                    }
                }
                connection.Close();
            }

            txtContent.Text = sb.ToString();
            string outputFolder = fd.SelectedPath + "\\" + lang;
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            string outputFilePath = outputFolder + "\\" + "Credit.txt";
            StreamWriter sw = new StreamWriter(outputFilePath);
            sw.Write(sb.ToString());
            sw.Close();
        }
        private void generateStoryboard(string lang, int idx)
        {
            StringBuilder sb = new StringBuilder();

            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile + ";" +
                          @"Extended Properties='Excel 8.0;IMEX=1;HDR=No;ImportMixedTypes=Text;'";

            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Storyboard$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            sb.Append("[" + dr[0].ToString() + "]" + Environment.NewLine);
                        }
                        else
                        {
                            sb.Append(dr[1 + idx].ToString() + Environment.NewLine);
                        }
                    }
                }
                connection.Close();
            }


            txtContent.Text = sb.ToString();
            string outputFolder = fd.SelectedPath + "\\" + lang;
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            string outputFilePath = outputFolder + "\\" + "Storyboard.txt";
            StreamWriter sw = new StreamWriter(outputFilePath);
            sw.Write(sb.ToString());
            sw.Close();
        }
        private void generateDocument(string lang, int idx)
        {
            StringBuilder sb = new StringBuilder();

            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile + ";" +
                          @"Extended Properties='Excel 8.0;IMEX=1;HDR=No;ImportMixedTypes=Text;'";

            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [文件系統$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (String.IsNullOrEmpty(dr[0].ToString()))
                            sb.Append(dr[1 + idx].ToString() + Environment.NewLine);
                        else
                            sb.Append("[" + dr[0].ToString() + "]" + dr[1 + idx].ToString() + Environment.NewLine);
                    }
                }
                connection.Close();
            }


            txtContent.Text = sb.ToString();
            string outputFolder = fd.SelectedPath + "\\" + lang;
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            string outputFilePath = outputFolder + "\\" + "Document.txt";
            StreamWriter sw = new StreamWriter(outputFilePath);
            sw.Write(sb.ToString());
            sw.Close();
        }
        private void generateIntelligence(string lang, int idx)
        {
            StringBuilder sb = new StringBuilder();

            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile + ";" +
                          @"Extended Properties='Excel 8.0;IMEX=1;HDR=No;ImportMixedTypes=Text;'";

            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [情報系統$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (String.IsNullOrEmpty(dr[0].ToString()))
                            sb.Append(dr[1 + idx].ToString() + Environment.NewLine);
                        else
                            sb.Append("[" + dr[0].ToString() + "]" + dr[1 + idx].ToString() + Environment.NewLine);
                    }
                }
                connection.Close();
            }


            txtContent.Text = sb.ToString();
            string outputFolder = fd.SelectedPath + "\\" + lang;
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            string outputFilePath = outputFolder + "\\" + "Intelligence.txt";
            StreamWriter sw = new StreamWriter(outputFilePath);
            sw.Write(sb.ToString());
            sw.Close();
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            generateConversation("EN", 0);
            generateCredit("EN", 0);
            generateStoryboard("EN", 0);
            generateDocument("EN", 0);
            generateIntelligence("EN", 0);
        }
        private void btnZH_Click(object sender, EventArgs e)
        {
            generateConversation("ZH", 1);
            generateCredit("ZH", 1);
            generateStoryboard("ZH", 1);
            generateDocument("ZH", 1);
            generateIntelligence("ZH", 1);
        }
        private void btnJP_Click(object sender, EventArgs e)
        {
            generateConversation("JP", 2);
            generateCredit("JP", 2);
            generateStoryboard("JP", 2);
            generateDocument("JP", 2);
            generateIntelligence("JP", 2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            generateUI();
            StringBuilder sb = new StringBuilder();
            //Default Area
            string[] area = new string[] { "A", "B", "C", "D", "E", "F" };


            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile + ";" +
                          @"Extended Properties='Excel 8.0;IMEX=1;HDR=No;ImportMixedTypes=Text;'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Conversation" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);

                connection.Open();
                OleDbCommand command_Conversation = new OleDbCommand("select * from [對話$]", connection);
                using (OleDbDataReader dr = command_Conversation.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            string data = "[" + dr[0].ToString() + "]" + "False" + Environment.NewLine;
                            sb.Append(data);
                        }
                    }
                }

                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Door" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);

                OleDbCommand command_Door = new OleDbCommand("select * from [門鎖旗標$]", connection);
                using (OleDbDataReader dr = command_Door.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            string data = "[" + dr[0].ToString() + "]" + "False" + Environment.NewLine;
                            sb.Append(data);
                        }
                    }
                }

                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Document" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);
                int defaultCountrol = 0;

                OleDbCommand command_Document = new OleDbCommand("select * from [文件系統$]", connection);
                using (OleDbDataReader dr = command_Document.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            string data = "";
                            if (ckBox.Checked && defaultCountrol < 1)
                            {
                                defaultCountrol++;
                                data = "[" + dr[0].ToString() + "]" + "True" + Environment.NewLine;
                            }
                            else
                            {
                                data = "[" + dr[0].ToString() + "]" + "False" + Environment.NewLine;
                            }
                            sb.Append(data);
                        }
                    }
                }



                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Intelligence" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);
                defaultCountrol = 0;
                OleDbCommand command_Intelligence = new OleDbCommand("select * from [情報系統$]", connection);
                using (OleDbDataReader dr = command_Intelligence.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            string data = "";
                            if (ckBox.Checked && defaultCountrol < 1)
                            {
                                defaultCountrol++;
                                data = "[" + dr[0].ToString() + "]" + "True" + Environment.NewLine;
                            }
                            else
                            {
                                data = "[" + dr[0].ToString() + "]" + "False" + Environment.NewLine;
                            }
                            sb.Append(data);
                        }
                    }
                }

                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Area Explored" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);
                for (int i = 0; i < area.Length; i++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        sb.Append("[" + "Area" + area[i] + k + "]" + "False" + Environment.NewLine);
                    }
                }

                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Warmbug Control Center" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);
                for (int i = 0; i < area.Length; i++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        sb.Append("[" + area[i] + k + " Warmbug]" + "False" + Environment.NewLine);
                    }
                }

                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Warmbug Control Reset" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);
                for (int i = 0; i < area.Length; i++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        sb.Append("[" + area[i] + k + " Warmbug Reset]" + "False" + Environment.NewLine);
                    }
                }

                sb.Append("--------------------------" + Environment.NewLine);
                sb.Append("Door locked" + Environment.NewLine);
                sb.Append("--------------------------" + Environment.NewLine);

                readJson("EN");
                for (int i = 0; i < listJson.Count; i++)
                {
                    if (listJson[i]["Right Door"] != null)
                    {
                        string data_rightDoor = "[" + listJson[i]["name"] + " Right Door" + "]" + (string)listJson[i]["Right Door"]["DefaultOpen"];
                        sb.Append(data_rightDoor + Environment.NewLine);
                    }

                    if (listJson[i]["Down Door"] != null)
                    {
                        string data_rightDoor = "[" + listJson[i]["name"] + " Down Door" + "]" + (string)listJson[i]["Down Door"]["DefaultOpen"];
                        sb.Append(data_rightDoor + Environment.NewLine);
                    }
                }
            }

            txtContent.Text = sb.ToString();
            string outputFolder = fd.SelectedPath + "\\ODMSave.txt";
            StreamWriter sw = new StreamWriter(outputFolder);
            sw.Write(sb.ToString());
            sw.Close();

            MessageBox.Show("File Generated!", "Message");
        }

        private void generateUI()
        {
            StringBuilder sb = new StringBuilder();

            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelFile + ";" +
                          @"Extended Properties='Excel 8.0;IMEX=1;HDR=No;ImportMixedTypes=Text;'";

            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [介面翻譯$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string data = "[" + dr[0] + "]" + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + Environment.NewLine;
                        sb.Append(data);
                    }
                }
                connection.Close();
            }


            txtContent.Text = sb.ToString();
            string outputFolder = fd.SelectedPath;
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            string outputFilePath = outputFolder + "\\" + "UI Text.txt";
            StreamWriter sw = new StreamWriter(outputFilePath);
            sw.Write(sb.ToString());
            sw.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(outputLocation))
                Process.Start(outputLocation);
        }

        private void ProjectTextManager_Load(object sender, EventArgs e)
        {
            cb.SelectedIndex = 1;
        }

        private void ckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void btnSelectMap_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog fd = new OpenFileDialog();
        //    fd.ShowDialog();

        //    if (fd.FileName != "")
        //    {
        //        jsonLocation = fd.FileName;
        //        btnMapJson.Text = jsonLocation;
        //        readJson(fd.FileName);
        //        StreamWriter sw = new StreamWriter(settingJsonFileName, false, Encoding.UTF8);
        //        sw.WriteLine(jsonLocation);
        //        sw.Close();
        //    }
        //}

        private void readJson(string lang)
        {
            string path = fd.SelectedPath + "\\" + lang + "\\" + "MapDatabase.txt";
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            JsonTextReader reader = new JsonTextReader(sr);
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.StartObject)
                {
                    listJson.Add(JObject.Load(reader));
                    // Load each object from the stream and do something with it
                }
            }
            sr.Close();
        }

        private void txtContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
