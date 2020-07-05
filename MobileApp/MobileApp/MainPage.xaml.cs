using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading;

namespace MobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs args)
        {
            label1.Text = Convert.ToString(ReverseNumber(Convert.ToInt32(entry.Text)));
        }

        private int ReverseNumber(int num)
        {
            int newNum = 0;
            
            while (num != 0)
            {
                newNum *= 10;
                int tmp = num % 10;
                newNum += tmp;
                num /= 10;
            }


            return newNum;
        }
    }
}
