using POSsystem.Database;
using POSsystem.Repository;
using POSsystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSsystem
{
    public partial class ManageBrand : Form
    {
        public List<Brand> BrandList { get; set; }

        private BrandRepository brandRepository = new BrandRepository();
        public ManageBrand()
        {
            InitializeComponent();
        }


        private void ManageBrand_Load(object sender, EventArgs e)
        {
            LoadData();

            /*
            Console.WriteLine("single data");
            Console.WriteLine(List[0].ID);
            Console.WriteLine(List[0].name);
            Console.WriteLine(List[0].remark);
            */
        }

        private void LoadData()
        {
            BrandList = brandRepository.GetAll();

            gvbrand.Rows.Clear();

            int runningno = 1;

            foreach (var item in BrandList)
            {
               
                gvbrand.Rows.Add(item.id,
                    runningno, 
                    item.name, 
                    item.remark);

                runningno = runningno + 1;
            }

            runningno = 1;
        }

        private void btaddbrand_Click(object sender, EventArgs e)
        {
            var form = new AddEditBrand();
            form.ShowDialog();
            LoadData();
        }

        private void bteditbrand_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gvbrand.Rows[gvbrand.CurrentCell.RowIndex].Cells[0].Value);
            var brand = BrandList.FirstOrDefault(x => x.id == id);
            if (brand != null)
            {
                var form = new AddEditBrand();
                form.Editmode = true;
                form.Branddata = brand;
                form.ShowDialog();
                LoadData();
            }


        }

        private void btdeletebrand_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gvbrand.Rows[gvbrand.CurrentCell.RowIndex].Cells[0].Value);

            var form = new ConfirmationDialog();
            form.Message = "Apa anda yakin menghapus Brand terpilih?";
            form.ShowDialog();

            if (form.YES)
            {
                if (!brandRepository.Delete(id))
                    MessageBox.Show("Gagal menghapus brand");
                LoadData();
            }


        }
    }
}
