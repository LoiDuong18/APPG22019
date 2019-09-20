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
    public partial class frmTinhToanCoBan : Form
    {
        public frmTinhToanCoBan()
        {
            InitializeComponent();
        }

        private void BtnCong_Click(object sender, EventArgs e)
        {
            try
            {
                errProvider.Clear();
                float temp = 0;
                if (!float.TryParse(txtA.Text, out temp))
                {
                    //MessageBox.Show("Lỗi. Vui lòng nhập lại giá trị a");
                    errProvider.SetError(txtA, "Vui lòng nhập lại giá trị a");
                    return;
                }
                var a = float.Parse(txtA.Text);

                if (!float.TryParse(txtB.Text, out temp))
                {
                    //MessageBox.Show("Lỗi. Vui lòng nhập lại giá trị b");
                    errProvider.SetError(txtB, "Vui lòng nhập lại giá trị b");
                    return;
                }
                var b = float.Parse(txtB.Text);


                var c = a + b;
                string data = String.Format("{0} + {1} = {2}", a, b, c);
                MessageBox.Show(data, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi rồi. Chi tiết lỗi: " + ex.StackTrace);
            }
        }
    }
}
