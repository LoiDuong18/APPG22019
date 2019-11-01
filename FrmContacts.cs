using AppG2.Controller;
using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2
{
    public partial class FrmContacts : Form
    {
         #region Path data file
        string pathClientDataFile;
        #endregion
        public FrmContacts()
        {
            InitializeComponent();
            pathClientDataFile = Application.StartupPath + @"\Data\client.txt";
        bindingSource1.DataSource = null;       
        dataGridView1.AutoGenerateColumns = false;
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
        if (client == null)
            throw new Exception("Danh bạ rỗng!");
        else
        {
                bindingSource1.DataSource = client;
        }
            dataGridView1.DataSource = bindingSource1;
           
        }

        public object ContactsService { get; }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var f = new FrmContacts();
            if (f.ShowDialog()==DialogResult.OK)
            {
                //tien hanh nhap du lieu
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "A")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "D")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "G")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "J")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "M")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "P")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "S")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "Y")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "Z")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void textBox1_keydown(object sender, KeyEventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client)
            {

            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            List<ClientContact> client = ContacstService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if(cl.Name.Contains(textBox1.Text) == false &&
                    cl.Email.Contains(textBox1.Text) == false &&
                    cl.Phone.Contains(textBox1.Text) == false)
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
