using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Model;
namespace AppG2.View

{
    public partial class frmQuatrinhHocTap : Form
    {
        HistoryLearning history;
        public frmQuatrinhHocTap(HistoryLearning history=null)
        {
            InitializeComponent();
            this.history = history;
            if (history != null)
            {
                //chinh sua
                this.Text = "chinh sua qua trinh hoc tap";
                numTunam.Value = history.YearFrom;
                numDennam.Value = history.YearFrom;
                txtNoihoc.Text = "";
            }
        }

  

    private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmQuatrinhHocTap_Load(object sender, EventArgs e)
        {

        }

        private void Btndongy_Click(object sender, EventArgs e)
        {
            if (history != null)
            {
                //cap nhat
            }
            else
            {
                //them moi
            }
            MessageBox.Show("da cap nhat du lieu thanh cong");
            DialogResult = DialogResult.OK;
            
        }

     
    }
}
