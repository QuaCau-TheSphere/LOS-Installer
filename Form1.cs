using System.Drawing.Text;
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

            myFont = new Font(fonts.Families[0], 16.0F);

            UC_cài_đặt.Visible = false;
            UC_triết_lý.Visible = false;
        }

        private void button_cài_đặt_Click(object sender, EventArgs e)
        {
            UC_cài_đặt.Visible = true;
            UC_triết_lý.Visible = false;
        }

        private void button_triết_lý_Click(object sender, EventArgs e)
        {
            UC_cài_đặt.Visible = false;
            UC_triết_lý.Visible = true;
        }
        private void button_hỗ_trợ_Click(object sender, EventArgs e)
        {
            UC_triết_lý.Visible = false;
            UC_triết_lý.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = myFont;
        }

    }
}