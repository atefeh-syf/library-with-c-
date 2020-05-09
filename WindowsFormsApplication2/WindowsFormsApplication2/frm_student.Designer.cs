namespace WindowsFormsApplication2
{
    partial class frm_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_student));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_namenevisande3 = new System.Windows.Forms.TextBox();
            this.txt_nameketab3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_namenevisande3
            // 
            this.txt_namenevisande3.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_namenevisande3.ForeColor = System.Drawing.Color.Brown;
            this.txt_namenevisande3.Location = new System.Drawing.Point(530, 65);
            this.txt_namenevisande3.Name = "txt_namenevisande3";
            this.txt_namenevisande3.Size = new System.Drawing.Size(100, 40);
            this.txt_namenevisande3.TabIndex = 1;
            // 
            // txt_nameketab3
            // 
            this.txt_nameketab3.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_nameketab3.ForeColor = System.Drawing.Color.Brown;
            this.txt_nameketab3.Location = new System.Drawing.Point(530, 19);
            this.txt_nameketab3.Name = "txt_nameketab3";
            this.txt_nameketab3.Size = new System.Drawing.Size(100, 40);
            this.txt_nameketab3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(646, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام کتاب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(636, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام نویسنده";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(406, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_namenevisande3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_nameketab3);
            this.panel1.ForeColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(70, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 397);
            this.panel1.TabIndex = 6;
            // 
            // frm_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 536);
            this.Controls.Add(this.panel1);
            this.Name = "frm_student";
            this.Text = "student";
            this.Load += new System.EventHandler(this.frm_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_namenevisande3;
        private System.Windows.Forms.TextBox txt_nameketab3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}