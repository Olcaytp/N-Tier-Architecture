using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer; // EntityLayer is added
using LogicLayer; // LogicLayer is added

namespace N_Tier_Architecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelList();
            dataGridView1.DataSource = PerList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelAd = TxtName.Text;
            ent.PersonelSoyad = TxtSurname.Text;
            ent.PersonelSehir = TxtCity.Text;
            ent.PersonelMaas = short.Parse(TxtSalary.Text);
            ent.PersonelGorev = TxtJob.Text;
            LogicPersonel.LLPersonelAdd(ent);
            MessageBox.Show("Personel Added!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelId = Convert.ToInt32(TxtId.Text);
            LogicPersonel.LLPersonelDelete(ent.PersonelId);
            MessageBox.Show("Personel Deleted!");

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelId = Convert.ToInt32(TxtId.Text);
            ent.PersonelAd = TxtName.Text;
            ent.PersonelSoyad = TxtSurname.Text;
            ent.PersonelSehir = TxtCity.Text;
            ent.PersonelMaas = short.Parse(TxtSalary.Text);
            ent.PersonelGorev = TxtJob.Text;
            LogicPersonel.LLPersonelUpdate(ent);
            MessageBox.Show("Personel Updated!");
        }
    }
}
