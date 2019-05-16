using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        WindowsFormsApp1.ServiceReference1.WebService1SoapClient service; 
        public Form1()
        {
            InitializeComponent();
            service =new WindowsFormsApp1.ServiceReference1.WebService1SoapClient();
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            dbData.Items.Clear();
            List<int> allNrs = service.getAll();
            
            foreach(int nr in allNrs)
            {
                dbData.Items.Add(nr);
            }
        }

        private void Button_insertNr_Click(object sender, EventArgs e)
        {
            int nrToInsert =int.Parse( textBox_insertNr.Text);
            service.insertNr(nrToInsert);
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox_updateValue.Text);
            int id = int.Parse(textBox_updateId.Text);

            service.updateNr(value, id);
        }
    }

  
}
