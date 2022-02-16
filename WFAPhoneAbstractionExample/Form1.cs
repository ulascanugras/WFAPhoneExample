using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPhoneAbstractionExample.Concrete;
using WFAPhoneAbstractionExample.Properties;

namespace WFAPhoneAbstractionExample
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            //SoundPlayer kullanımı:
            //SoundPlayer soundPlayer = new SoundPlayer(Resources.iphone);
            //soundPlayer.Play();
            //Thread.Sleep(500);
            //soundPlayer.Stop();
        }
        bool iphoneIsClicked = false;
        private void btnIphone_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();
            iphone.Model = "13Pro";
            iphone.UnitPrice = 15555.55m;
            if (!iphoneIsClicked)
            {
                iphone.PlaySound();
                iphoneIsClicked = true;
                btnIphone.Text = iphone.Model + " " + iphone.UnitPrice.ToString("c2");
                MessageBox.Show(iphone.Call("Mustafa"));
            }
            else
            {
                iphone.StopSound();
                btnIphone.Text = "Iphone";
                iphoneIsClicked = false;///////////////////////
            }
        }

        private void btnEricson_Click(object sender, EventArgs e)
        {
            
            Ericson ericson = new Ericson()
            {
                Model = "X",
                UnitPrice = 11.1m
            };
            MessageBox.Show(ericson.ToString());
        }

        private void btnNokia_Click(object sender, EventArgs e)
        {
           
            Nokia nokia = new Nokia() 
            {
                Model = "3310",
                UnitPrice = 22.2m
            };
            nokia.PlaySound();
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung() 
            {
                Model = "Note5",
                UnitPrice = 10000.00m
            };
            SamsungForm samsungForm = new SamsungForm(samsung);
            samsungForm.ShowDialog();
            MessageBox.Show("Çalışmaya burdan devam eder! ShowDialog'un dialogResult döndürmesi.");

        }
    }
}
