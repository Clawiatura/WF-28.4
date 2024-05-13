using System.Windows.Forms;

namespace WF_28._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btclick_Click(object sender, EventArgs e)
        {
            string filePath = tbfile.Text; 
            
            
                FileInfo file = new FileInfo(filePath);
                string text = File.ReadAllText(filePath);
                string[] textSort = text.Split('\n');
            foreach (string s in textSort)
            {
                lbtext.Items.Add(s);
            }

        }
    }
}
