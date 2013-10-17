using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MifareCalculator
{
    public partial class Form1 : Form
    {
        private ClassicPasswordGenerator passGen;
        public Form1()
        {
            InitializeComponent();
            passGen = new ClassicPasswordGenerator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputKeyA.Text.Length != 12 && InputKeyB.Text.Length != 12)
            {
                MessageBox.Show("Please put 6 bytes of key!");
                return;

            }
            PasswordResult.Text = passGen.generatePassword(InputKeyA.Text, InputKeyB.Text);
        }
    }
}
