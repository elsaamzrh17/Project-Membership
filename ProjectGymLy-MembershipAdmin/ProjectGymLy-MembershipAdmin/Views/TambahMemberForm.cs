using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGymLy_MembershipAdmin.App.Context;
using ProjectGymLy_MembershipAdmin.App.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectGymLy_MembershipAdmin.Views
{
    public partial class TambahMemberForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int MahasiswaId { get; set; }
        public TambahMemberForm()
        {
            InitializeComponent();
            UpdateButtonText();
            LoadStatusData();
        }

        private void btnTambahMember_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Membership membership = new M_Membership
            {
                nama = textBoxNama.Text,
                id_status = (int)comboBox1.SelectedValue,
            };

            if (IsEditMode)
            {
                membership.id = MahasiswaId;
                MembershipContext.UpdateMmembership(membership);
                MessageBox.Show("Membership berhasil diupdate");
            }
            else
            {
                MembershipContext.AddMembership(membership);
                MessageBox.Show("Member baru berhasil ditambahkan");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private void LoadStatusData()
        {
            DataTable dataProdi = StatusContext.All();
            comboBox1.DisplayMember = "status";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = dataProdi;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textBoxNama.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        public void PopulateForm(M_Membership membership)
        {
            LoadStatusData();

            textBoxNama.Text = membership.nama;
            comboBox1.SelectedValue = membership.id_status;
            IsEditMode = true;
            MahasiswaId = membership.id;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            btnTambahMember.Text = IsEditMode ? "Update" : "Add";
        }
    }
}

