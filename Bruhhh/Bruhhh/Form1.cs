using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bruhhh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable dt = new DataTable();
        List<string> listnama = new List<string>();
        bool check = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("nama");
            dt.Columns.Add("tim");
            dt.Columns.Add("stadion");
            dataGridView1.DataSource = dt;

        }

        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            check = false;
            
            string nama = textBoxnama.Text;
            string tim = textBoxtim.Text;
            string stadion = textBoxstadion.Text;

     


            //cek value yang sama
            for (int i = 0; i < listnama.Count; i++)
            {
                if (nama == listnama[i])
                {
                    check = true;
                }
            }
            if (check == true)
            {
                MessageBox.Show("ada yang sama woi", "jeni cantik");
            }
            else
            {
                dt.Rows.Add(nama, tim, stadion);
                listnama.Add(nama);
            }

            dataGridView1.DataSource = dt;
        }

        private void labeltime_Click(object sender, EventArgs e)
        {

        }
    }
}
