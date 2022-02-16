﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPhoneAbstractionExample.Concrete;

namespace WFAPhoneAbstractionExample
{
    public partial class SamsungForm : Form
    {
        private readonly Samsung samsung;
        bool isClicked = false;
        public SamsungForm(Samsung samsung)
        {
            InitializeComponent();
            this.samsung = samsung;
        }

        private void SamsungForm_Load(object sender, EventArgs e)
        {
            txtModel.Text = samsung.Model;
            txtUnitPrice.Text = samsung.UnitPrice.ToString("c2");
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                samsung.PlaySound();
                isClicked = true;
                btnSound.Text = "StopSound";
            }
            else
            {
                isClicked = false;
                samsung.StopSound();
                btnSound.Text = "PlaySound";
            }
        }
    }
}
