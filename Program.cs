namespace LOS_Installer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //void InitCustomLabelFont() {
            //    //Create your private font collection object.
            //    PrivateFontCollection pfc = new PrivateFontCollection();

            //    //Select your font from the resources.
            //    //My font here is "SVN_Avo.ttf"
            //    int fontLength = Properties.Resources.SVN_Avo.Length;

            //    // create a buffer to read in to
            //    byte[] fontdata = Properties.Resources.SVN_Avo;

            //    // create an unsafe memory block for the font data
            //    System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            //    // copy the bytes to the unsafe memory block
            //    Marshal.Copy(fontdata, 0, data, fontLength);

            //    // pass the font to the font collection
            //    pfc.AddMemoryFont(data, fontLength);
            //}
            ////After that we can create font and assign font to label
            //label1.Font = new Font(pfc.Families[0], label1.Font.Size);
            //label1.Text = "My new font";


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }
}