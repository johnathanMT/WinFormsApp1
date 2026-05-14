namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            //get the value from the textbox
            string strName=textName.Text;

            string greet = "";
            if (radM.Checked)
                greet = "Good Morning";
            else if (radE.Checked)
                greet = "Good Evening";

            //show the data with MessageBox
            MessageBox.Show(greet+" "+strName);
        }
    }
}