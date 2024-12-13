namespace ProjectGymLy_MembershipAdmin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnTambahMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 282);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 19);
            label1.Name = "label1";
            label1.Size = new Size(329, 28);
            label1.TabIndex = 1;
            label1.Text = "DATA MEMBERSHIP GYMLY";
            // 
            // btnTambahMain
            // 
            btnTambahMain.BackColor = Color.Lime;
            btnTambahMain.Font = new Font("Bodoni MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambahMain.Location = new Point(630, 382);
            btnTambahMain.Name = "btnTambahMain";
            btnTambahMain.Size = new Size(112, 34);
            btnTambahMain.TabIndex = 9;
            btnTambahMain.Text = "Tambah";
            btnTambahMain.UseVisualStyleBackColor = false;
            btnTambahMain.Click += btnTambahMain_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahMain);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnTambahMain;
    }
}
