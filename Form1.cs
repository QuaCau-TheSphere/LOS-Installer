namespace LOS_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UC_cài_đặt.Visible = false;
            UC_giới_thiệu.Visible = false;
            UC_gặp_nhau.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_cài_đặt_Click(object sender, EventArgs e)
        {
            if (UC_cài_đặt.Visible == true)
            {
                UC_cài_đặt.Visible = false;
            }
            else if (UC_cài_đặt.Visible == false)
            {
                UC_cài_đặt.Visible = true;
            }

            UC_giới_thiệu.Visible = false;
            UC_gặp_nhau.Visible = false;
        }

        private void buttonGiớiThiệu_Click(object sender, EventArgs e)
        {
            if (UC_giới_thiệu.Visible == true)
            {
                UC_giới_thiệu.Visible = false;
            }
            else if (UC_giới_thiệu.Visible == false)
            {
                UC_giới_thiệu.Visible = true;
            }
            UC_cài_đặt.Visible = false;
            UC_gặp_nhau.Visible = false;
        }
        private void button_gặp_nhau_Click(object sender, EventArgs e)
        {
            if (UC_gặp_nhau.Visible == true)
            {
                UC_gặp_nhau.Visible = false;
            }
            else if (UC_gặp_nhau.Visible == false)
            {
                UC_gặp_nhau.Visible = true;
            }

            UC_cài_đặt.Visible = false;
            UC_giới_thiệu.Visible = false;
        }

        private void button_đóng_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}