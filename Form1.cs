using System.Drawing.Text;
using System.Windows.Controls;

namespace LOS_Installer
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;

        public Form1()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.SVN_Avo;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.SVN_Avo.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.SVN_Avo.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 8.5F);

            UC_cài_đặt.Visible = false;
            UC_triết_lý.Visible = false;
            UC_gặp_nhau.Visible = false;
            //Font = myFont;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //UC_cài_đặt.Font = myFont;
            //button_cài_đặt.Font = myFont;
        }

        private void button_cài_đặt_Click(object sender, EventArgs e)
        {
            if (UC_cài_đặt.Visible == true) {
                UC_cài_đặt.Visible = false;
            } else if (UC_cài_đặt.Visible == false) {
                UC_cài_đặt.Visible = true;
            }
            
            UC_triết_lý.Visible = false;
            UC_gặp_nhau.Visible = false;
        }

        private void button_triết_lý_Click(object sender, EventArgs e)
        {
            if (UC_triết_lý.Visible == true) {
                UC_triết_lý.Visible = false;
            } else if (UC_triết_lý.Visible == false) {
                UC_triết_lý.Visible = true;
            }
            UC_cài_đặt.Visible = false;
            UC_gặp_nhau.Visible = false;
        }
        private void button_gặp_nhau_Click(object sender, EventArgs e)
        {
            if (UC_gặp_nhau.Visible == true) {
                UC_gặp_nhau.Visible = false;
            } else if (UC_gặp_nhau.Visible == false) {
                UC_gặp_nhau.Visible = true;
            }

            UC_cài_đặt.Visible = false;
            UC_triết_lý.Visible = false;
        }

        private void button_đóng_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
    }
}