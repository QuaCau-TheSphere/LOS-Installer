namespace LOS_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_cài_đặt.Visible = false;
        }

        private void button_cài_đặt_Click(object sender, EventArgs e)
        {
            UC_cài_đặt.Visible = true;
        }

        private void UC_cài_đặt_Load(object sender, EventArgs e)
        {

        }
    }
}