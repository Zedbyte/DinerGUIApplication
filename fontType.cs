using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DinerGUIApplication
{
    internal class fontType
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        PrivateFontCollection pfc1 = new PrivateFontCollection();
        PrivateFontCollection pfc2 = new PrivateFontCollection();
        PrivateFontCollection pfc3 = new PrivateFontCollection();

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public void InitializeCustomFont_Receipt(RichTextBox txtBx)
        {

            int fontLength = Properties.Resources.fake_receipt.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.fake_receipt;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            txtBx.Font = new Font(pfc.Families[0], (float)8f);

        }

        public void InitializeCustomFont_Label(Label label, float size)
        {

            int fontLength = Properties.Resources.Franchise.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Franchise;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc1.AddMemoryFont(data, fontLength);

            label.Font = new Font(pfc1.Families[0], (float)size);

        }

        public void InitializeCustomFont_Cartoony(Label label, float size)
        {

            int fontLength = Properties.Resources.jellee_roman.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.jellee_roman;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc2.AddMemoryFont(data, fontLength);

            label.Font = new Font(pfc2.Families[0], (float)size);

        }

        public void InitializeCustomFont_CartoonyButtons(Button btn, float size)
        {

            int fontLength = Properties.Resources.jellee_roman.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.jellee_roman;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc3.AddMemoryFont(data, fontLength);

            btn.Font = new Font(pfc3.Families[0], (float)size);

        }

        public PrivateFontCollection getPFC()
        {
            return pfc;
        }
    }
}
