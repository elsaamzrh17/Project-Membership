namespace ProjectGymLy_MembershipAdmin.Views
{
    partial class TambahMemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            textBoxNama = new TextBox();
            label4 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            btnTambahMember = new Button();
            btnBatal1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 117);
            label1.Name = "label1";
            label1.Size = new Size(75, 29);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 201);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(163, 115);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(544, 31);
            textBoxNama.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(233, 34);
            label4.Name = "label4";
            label4.Size = new Size(343, 38);
            label4.TabIndex = 5;
            label4.Text = "Masukkan Data Member";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 199);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 6;
            label2.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(163, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 33);
            comboBox1.TabIndex = 7;
            // 
            // btnTambahMember
            // 
            btnTambahMember.BackColor = Color.Lime;
            btnTambahMember.Font = new Font("Bodoni MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambahMember.Location = new Point(595, 359);
            btnTambahMember.Name = "btnTambahMember";
            btnTambahMember.Size = new Size(112, 34);
            btnTambahMember.TabIndex = 8;
            btnTambahMember.Text = "Tambah";
            btnTambahMember.UseVisualStyleBackColor = false;
            btnTambahMember.Click += btnTambahMember_Click;
            // 
            // btnBatal1
            // 
            btnBatal1.BackColor = Color.DarkGray;
            btnBatal1.Font = new Font("Bodoni MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBatal1.Location = new Point(464, 359);
            btnBatal1.Name = "btnBatal1";
            btnBatal1.Size = new Size(112, 34);
            btnBatal1.TabIndex = 9;
            btnBatal1.Text = "Batal";
            btnBatal1.UseVisualStyleBackColor = false;
            // 
            // TambahMemberForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatal1);
            Controls.Add(btnTambahMember);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBoxNama);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "TambahMemberForm";
            Text = "Form Tambah Member";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBoxNama;
        private Label label4;
        private Label label2;
        private ComboBox comboBox1;
        private Button btnTambahMember;
        private Button btnBatal1;
    }
}