﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("트위터 일론 머스크한테 인수당했대ㅜㅜ", "트친님이 말씀하시길", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
        }
    }
}
