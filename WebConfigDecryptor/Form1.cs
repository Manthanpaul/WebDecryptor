using Daimler.ConnectionStringEncryptor;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WebConfigDecryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            this.InitializeComponent();
            this.chkBox_EnvType.SetItemChecked(0, true);
            this.chkBox_EnvType.SetItemChecked(1, true);
            //this.chkBox_EnvType.SetItemChecked(2, true);
        }

        private void cmb_ApplicationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string appName = this.cmb_ApplicationName.Text.ToString();

            this.txt_SIV.Text = /*"1,2,0,8,1,2,3,5";//*/this.getSIV(appName);
            this.txt_Skey.Text = /*"1,2,0,8,1,2,3,4"; //*/this.getSkey(appName);
            this.txtBox_ConnString.Text = "";
            this.fetchConnString(appName, false);
        }
        private string getSIV(string appName)
        {
            char[] separator = new char[] { '|' };
            string SIV = SIVKey.ResourceManager.GetString(appName).Split(separator)[0];
            return (SIV);
        }

        private string getSkey(string appName)
        {
            char[] separator = new char[] { '|' };
            string SKEY = SIVKey.ResourceManager.GetString(appName).Split(separator)[1];
            return (SKEY);
        }

        private string decryptString(string encrString) =>
            ConnectionEncryptor.DecryptString(this.txt_Skey.Text, this.txt_SIV.Text, encrString);
        public static string DecryptString(string keyString, string cipherText)
        {
            string str2;
            byte[] src = Convert.FromBase64String(cipherText);
            byte[] dst = new byte[0x10];
            byte[] buffer3 = new byte[src.Length - dst.Length];
            Buffer.BlockCopy(src, 0, dst, 0, dst.Length);
            Buffer.BlockCopy(src, dst.Length, buffer3, 0, src.Length - dst.Length);
            byte[] bytes = Encoding.UTF8.GetBytes(keyString);
            using (Aes aes = Aes.Create())
            {
                using (ICryptoTransform transform = aes.CreateDecryptor(bytes, dst))
                {
                    string str;
                    using (MemoryStream stream = new MemoryStream(buffer3))
                    {
                        using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(stream2))
                            {
                                str = reader.ReadToEnd();
                            }
                        }
                    }
                    str2 = str;
                }
            }
            return str2;
        }
        private void fetchConnString(string appName, bool decryption)
        {
            if (appName == "")
            {
                this.txtBox_ConnString.SelectionColor = Color.Black;
                this.txtBox_ConnString.AppendText("Please select the application");
            }
            else
            {
                try
                {
                    string[] strArray;
                    int num2;
                    string str = "";
                    int index = 0;
                    while (true)
                    {
                        if (index >= this.chkBox_EnvType.Items.Count)
                        {
                            strArray = Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"WebConfig\\" + appName), "*.*", SearchOption.AllDirectories);
                            num2 = 0;
                            break;
                        }
                        if (this.chkBox_EnvType.GetItemChecked(index))
                        {
                            str = str + ((string)this.chkBox_EnvType.Items[index]);
                        }
                        str = str + ";";
                        index++;
                    }
                    while (true)
                    {
                        while (true)
                        {
                            if (num2 < strArray.Length)
                            {
                                string filename = strArray[num2];
                                if (filename.ToLower().Contains("dev"))
                                {
                                    if (!str.ToLower().Contains("dev"))
                                    {
                                        break;
                                    }
                                    this.txtBox_ConnString.SelectionColor = Color.Black;
                                    this.txtBox_ConnString.AppendText("Dev: ");
                                }
                                else if (filename.ToLower().Contains("qa") || filename.ToLower().Contains("staging"))
                                {
                                    if (!str.ToLower().Contains("qa"))
                                    {
                                        break;
                                    }
                                    this.txtBox_ConnString.SelectionColor = Color.Black;
                                    this.txtBox_ConnString.AppendText("QA: ");
                                }
                                else if (filename.ToLower().Contains("prod"))
                                {
                                    if (!str.ToLower().Contains("prod"))
                                    {
                                        break;
                                    }
                                    this.txtBox_ConnString.SelectionColor = Color.Red;
                                    this.txtBox_ConnString.AppendText("Prod: ");
                                }
                                XmlDocument document1 = new XmlDocument();
                                document1.Load(filename);
                                foreach (XmlNode node in document1.SelectNodes("configuration/connectionStrings/add"))
                                {
                                    XmlElement element1 = (XmlElement)node;
                                    string str3 = node.Attributes["name"].Value;
                                    string str4 = "";
                                    str4 = !decryption ? node.Attributes["connectionString"].Value : this.decryptString(node.Attributes["connectionString"].Value);
                                    this.txtBox_ConnString.AppendText("\r\n\r\nName: " + str3);
                                    this.txtBox_ConnString.AppendText("\r\n\r\n" + str4);
                                }
                                this.txtBox_ConnString.AppendText("\r\n\r\n__________________________________________________________________________________________________________________\r\n\r\n");
                            }
                            else
                            {
                                return;
                            }
                            break;
                        }
                        num2++;
                    }
                }
                catch (Exception exception)
                {
                    this.txtBox_ConnString.SelectionColor = Color.Black;
                    this.txtBox_ConnString.AppendText(exception.Message);
                }
            }
        }

        private void btn_Decrypt_Click_1(object sender, EventArgs e)
        {
             this.txtBox_ConnString.Text = "";
                this.fetchConnString(this.cmb_ApplicationName.Text.ToString(), true);
        }
    }
}
