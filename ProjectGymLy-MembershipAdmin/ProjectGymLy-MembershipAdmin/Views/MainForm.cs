using System.Data;
using ProjectGymLy_MembershipAdmin.App.Context;
using ProjectGymLy_MembershipAdmin.App.Models;
using ProjectGymLy_MembershipAdmin.Views;

namespace ProjectGymLy_MembershipAdmin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void btnTambahMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            TambahMemberForm tambahMemberForm = new TambahMemberForm();

            if (tambahMemberForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataMembership();
            }

            this.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataMembership();
        }

        private void LoadDataMembership()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable membershipData = MembershipContext.All();
                if (membershipData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data mahasiswa");
                    return;
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = membershipData;

                if (dataGridView1.Columns["id"] != null) dataGridView1.Columns["id"].Visible = false;
                if (dataGridView1.Columns["nama"] != null)
                    dataGridView1.Columns["nama"].HeaderText = "Nama";
                if (dataGridView1.Columns["status_membership"] != null)
                    dataGridView1.Columns["status_membership"].HeaderText = "Status Membership";
                if (dataGridView1.Columns["id_status"] != null)
                    dataGridView1.Columns["id_status"].Visible = false;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }


                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    int mahasiswaId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                    DataTable mahasiswaData = MembershipContext.getMembershipById(mahasiswaId);

                    if (mahasiswaData.Rows.Count > 0)
                    {
                        DataRow row = mahasiswaData.Rows[0];
                        M_Membership membership = new M_Membership
                        {
                            id = (int)row["id"],
                            nama = row["nama"].ToString(),
                            id_status = (int)row["id_status"]
                        };

                        this.Hide();
                        TambahMemberForm tambahMemberForm = new TambahMemberForm();
                        tambahMemberForm.PopulateForm(membership);
                        if (tambahMemberForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadDataMembership();
                        }
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int mahasiswaId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                MembershipContext.DeleteMembership(mahasiswaId);
                LoadDataMembership();
            }
        }
    }
}
