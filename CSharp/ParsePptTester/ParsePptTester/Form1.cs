using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsePptTester
{
    public partial class Form1 : Form
    {
        private int slideCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbVersion.Text = ParsePpt.ParsePpt.getAssemblyVersion();
            Console.WriteLine("Version:" + tbVersion.Text);
            tbPath.Text = "E:\\Metis Automation\\Test Import.pptx";
            //tbPath.Text = "E:\\Metis Automation\\Tactus.pptx";
        }

        private void bSlidecount_Click(object sender, EventArgs e)
        {
            string path = tbPath.Text;
            Console.WriteLine("Path: " + path);
            if (!path.Equals(""))
            {
                this.slideCount = ParsePpt.ParsePpt.getSlideCount(path);
                numSlideCount.Value = this.slideCount;
            }
            else
            {
                Console.WriteLine("The entered path is empty");
            }
        }

        private void bSlideText_Click(object sender, EventArgs e)
        {
            string path = tbPath.Text;
            if (!path.Equals("") && this.slideCount > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < slideCount; i++)
                {
                    sb.AppendLine(ParsePpt.ParsePpt.getSlideText(path, i));
                }
                tbSlideText.Text = sb.ToString();
            }
            else
            {
                tbSlideText.Text = "Path empty or no slides found";
            }
        }
    }
}
