using Cardtrader_web_scraper.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardtrader_web_scraper.Views
{
    public partial class MainForm : Form
    {
        public MainFormController _MainFormController = new MainFormController();
        public MainForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Watch out for deadlock in the UI!
            string result = await _MainFormController.CallUrl("https://www.cardmarket.com/it/Pokemon/Data/Best-Bargains");   

        }
    }
}
