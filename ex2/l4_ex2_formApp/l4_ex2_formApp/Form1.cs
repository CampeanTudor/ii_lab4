using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l4_ex2_formApp
{
    public partial class Form1 : Form
        
      
    {
        ServiceReference1.WebService1SoapClient service;

        public Form1()
        {
            InitializeComponent();
            service = new ServiceReference1.WebService1SoapClient();
        }

        private void Button_convFtoC_Click(object sender, EventArgs e)
        {
            double f =double.Parse(textBox_f.Text.ToString());

            double c = service.convFtoC(f);

            textBox_convFtoC_result.Text = c.ToString();
            
        }

        private void Button_convRonToE_Click(object sender, EventArgs e)
        {
            double ron = double.Parse(textBox_Ron.Text.ToString());

            double eu = service.convertRonToE(ron);

            textBox_convRontoE_result.Text = eu.ToString();
        }

        private void Button_getDate_Click(object sender, EventArgs e)
        {
            textBox_date.Text=service.getCurrentDateAndTime().ToString();
        }

        private void Button_showList_Click(object sender, EventArgs e)
        {
            listBox_showElement.Items.Clear();

            List<int> list = service.getList();

            foreach(int i in list)
            {
                listBox_showElement.Items.Add(i);
            }
        }
    }
}
