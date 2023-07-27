using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Anahtar_Kontrol_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private class serialPort1
        {
            public static string PortName { get; internal set; }
            public static int BaudRate { get; internal set; }

            internal static void Open()
            {
                throw new NotImplementedException();
            }
        }
    }
}
