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
    public partial class FormMua : Form
    {
        IObjectContainer dbm;
        public FormMua()
        {
            InitializeComponent();
        }
        private void FormMua_Load_1(object sender, EventArgs e)
        {
            dbm = Db4oFactory.OpenFile(databaseFileName: "CSDL");
            loaddata();
        }
        private void loaddata()
        {
            IList<Mua> db4oList = dbm.Query<Mua>();
            dataGridView1.DataSource = db4oList.ToList();
        }

        private void btThemM_Click(object sender, EventArgs e)
        {
            Mua m = new Mua(txtMaM.Text, txtTenM.Text, txtDiaChiM.Text, txtSDTM.Text);
            dbm.Store(m);
            MessageBox.Show("Them Thanh Cong");
            txtMaM.Text = "";
            txtTenM.Text = "";
            txtDiaChiM.Text = "";
            txtSDTM.Text = "";
            txtMaM.Focus();
            txtTenM.Focus();
            txtDiaChiM.Focus();
            txtSDTM.Focus();
            loaddata();
        }

        private void btSuaM_Click(object sender, EventArgs e)
        {
            IObjectSet rs = dbm.QueryByExample(new Mua(txtMaM.Text, null, null, null));
            Mua found = (Mua)rs.Next();
            found.ADDMua(txtTenM.Text, txtDiaChiM.Text, txtSDTM.Text);
            dbm.Store(found);
            txtMaM.Text = ""; txtTenM.Text = ""; txtDiaChiM.Text = ""; txtSDTM.Text = "";
            loaddata();
        }

        private void btXoaM_Click(object sender, EventArgs e)
        {
            IObjectSet rs = dbm.QueryByExample(new Mua(txtMaM.Text, null, null, null));
            Mua found = (Mua)rs.Next();
            dbm.Delete(found);
            loaddata();
        }

        private void btBan_Click(object sender, EventArgs e)
        {
            dbm.Close();
            FormBan ban = new FormBan();
            ban.Show();
            FormMua mua = new FormMua();
            mua.Close();

        }
    }
}
