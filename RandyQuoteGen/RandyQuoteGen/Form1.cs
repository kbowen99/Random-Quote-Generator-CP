using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandyQuoteGen
{
    public partial class frm_randyQuoteGenForm : Form
    {
        //random Number Generator Used to randomize Quotes
        Random rndGen = new Random();
        public frm_randyQuoteGenForm()
        {
            //Start Code
            InitializeComponent();
            // do not put "Random rndGen = new Random();" here, it wont work
        }

        private void pic_Background_Click(object sender, EventArgs e)
        {
            //Accidental double click 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Accidental double click, again
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Accidental double click, yet again
        }

        private void btn_Randy_Click(object sender, EventArgs e)
        {
            //generate random number using generator above
            int rndNum = rndGen.Next(1, 11);
            //place image (with qoute) based on number generated
            if (rndNum == 1)
            {
                pic_quotebox.Image = Properties.Resources.Ana_White_Quote_Inspirational_Quotes;
               lbl_Num.Text = "1";
            }
            else if (rndNum == 2)
            {
                pic_quotebox.Image = Properties.Resources.patience;
                lbl_Num.Text = "2";
            }
            else if (rndNum == 3)
            {
                pic_quotebox.Image = Properties.Resources.googleit;
                lbl_Num.Text = "3";
            }
            else if (rndNum == 4)
            {
                pic_quotebox.Image = Properties.Resources.images;
                lbl_Num.Text = "4";
            }
            else if (rndNum == 5)
            {
                pic_quotebox.Image = Properties.Resources.Quotation_Marc_Andreessen_magic_internet_Meetville_Quotes_2427;
                lbl_Num.Text = "5";
            }
            else if (rndNum == 6)
            {
                pic_quotebox.Image = Properties.Resources.images__1_;
                lbl_Num.Text = "6";
            }
            else if (rndNum == 7)
            {
                pic_quotebox.Image = Properties.Resources.Quotation_Kent_Conrad_society_computers_education_internet_Meetville_Quotes_43535;
                lbl_Num.Text = "7";
            }
            else if (rndNum == 8)
            {
                pic_quotebox.Image = Properties.Resources.Quotation_D_M_Jarrett_media_listening_time_Meetville_Quotes_177522;
                lbl_Num.Text = "8";
            }
            else if (rndNum == 9)
            {
                pic_quotebox.Image = Properties.Resources.Quotation_Michio_Kaku_wisdom_trying_people_ideas_internet_Meetville_Quotes_3513;
                lbl_Num.Text = "9";
            }
            else if (rndNum == 10)
            {
                pic_quotebox.Image = Properties.Resources.Quotation_Andrew_Brown_life_people_technology_internet_Meetville_Quotes_188562;
                lbl_Num.Text = "10";
            }
            else
            {
                //Just in case...
                pic_quotebox.Image = Properties.Resources.cooltext1721567769;
            }
        }

        private void pic_quotebox_Click(object sender, EventArgs e)
        {
            //Accidental double click, again
        }
    }
}
