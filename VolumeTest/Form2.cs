using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace VolumeTest
{
    public partial class Form2 : Form
    {
        private const uint APPCOMMAND_VOLUME_MUTE = 8;
        private const uint APPCOMMAND_VOLUME_DOWN = 9;
        private const uint APPCOMMAND_VOLUME_UP = 10;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public Form2()
        {
            InitializeComponent();
            SendMessageW(Process.GetCurrentProcess().Handle, 0, Process.GetCurrentProcess().Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
    }
}
