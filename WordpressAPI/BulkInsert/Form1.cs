using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordpressAPI;

namespace BulkInsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"C:\Users\ziaurrahman.j\Google Drive\Interview questions\Security\Security.docx";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application word = null;
            Microsoft.Office.Interop.Word.Document docs = null;
            try
            {
                word = new Microsoft.Office.Interop.Word.Application();
                object miss = System.Reflection.Missing.Value;
                object path = textBox1.Text;
                object readOnly = true;
                docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
                //


                //


                string totaltext = "";
                for (int i = 0; i < docs.Paragraphs.Count; i++)
                {
                    totaltext += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();
                }
                string[] parts1 = totaltext.Split(new string[] { "***" }, StringSplitOptions.None);

                foreach (var part in parts1)
                {
                    string[] parts2 = part.Split(new string[] { "---" }, StringSplitOptions.None);

                    BlogPost blogPost = new BlogPost()
                    {
                        Title = parts2[0].Trim(),
                        Body = parts2[1].Trim(),
                        Tags = "Security"

                    };

                    WordpressAPI.Service.Post(blogPost);

                }
                //label1.Text=totaltext;
            }
            catch { throw; }
            finally
            {
                docs.Close();
                word.Quit();
            }
        }
    }
}
