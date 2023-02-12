using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;

namespace KN_Nhom1_PM10
{
    public partial class FormBan : Form
    {
        IObjectContainer dbBan;
        public FormBan()
        {
            InitializeComponent();
        }
        private void FormBan_Load(object sender, EventArgs e)
        {
            dbBan = Db4oFactory.OpenFile("CSDL");
            loaddata();

        }
        private void loaddata()
        {
            IList<Ban> db4oList = dbBan.Query<Ban>();
            dataGridView1.DataSource = db4oList.ToList();
        }

        private void btThemB_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban(txtMaB.Text, txtTenB.Text, txtDiaChiB.Text, txtSDTB.Text);
            dbBan.Store(ban);
            MessageBox.Show("Them Thanh Cong");
            txtMaB.Text = "";
            txtTenB.Text = "";
            txtDiaChiB.Text = "";
            txtSDTB.Text = "";
            txtMaB.Focus();
            txtTenB.Focus();
            txtDiaChiB.Focus();
            txtSDTB.Focus();
            loaddata();
        }

        private void btSuaB_Click(object sender, EventArgs e)
        {
            IObjectSet rs = dbBan.QueryByExample(new Ban(txtMaB.Text, null, null, null));
            Ban found = (Ban)rs.Next();
            found.ADDBan(txtTenB.Text, txtDiaChiB.Text, txtSDTB.Text);
            dbBan.Store(found);
            txtMaB.Text = ""; txtTenB.Text = ""; txtDiaChiB.Text = ""; txtSDTB.Text = "";
            loaddata();
        }

        private void btXoaB_Click(object sender, EventArgs e)
        {
            IObjectSet rs = dbBan.QueryByExample(new Ban(txtMaB.Text, null, null, null));
            Ban found = (Ban)rs.Next();
            dbBan.Delete(found);
            loaddata();
        }

        private void btMua_Click(object sender, EventArgs e)
        {
            dbBan.Close();
            FormBan ban = new FormBan();
            ban.Close();
            FormMua mua = new FormMua();
            mua.Show();

        }
    }
}
