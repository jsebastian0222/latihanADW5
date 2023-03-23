namespace Bruhhh
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelnama = new System.Windows.Forms.Label();
            this.labelTim = new System.Windows.Forms.Label();
            this.labelStadion = new System.Windows.Forms.Label();
            this.textBoxnama = new System.Windows.Forms.TextBox();
            this.textBoxtim = new System.Windows.Forms.TextBox();
            this.textBoxstadion = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labeltime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(478, 178);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(35, 13);
            this.labelnama.TabIndex = 1;
            this.labelnama.Text = "Nama";
            // 
            // labelTim
            // 
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(478, 209);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(24, 13);
            this.labelTim.TabIndex = 2;
            this.labelTim.Text = "Tim";
            // 
            // labelStadion
            // 
            this.labelStadion.AutoSize = true;
            this.labelStadion.Location = new System.Drawing.Point(478, 236);
            this.labelStadion.Name = "labelStadion";
            this.labelStadion.Size = new System.Drawing.Size(43, 13);
            this.labelStadion.TabIndex = 3;
            this.labelStadion.Text = "Stadion";
            // 
            // textBoxnama
            // 
            this.textBoxnama.Location = new System.Drawing.Point(535, 178);
            this.textBoxnama.Name = "textBoxnama";
            this.textBoxnama.Size = new System.Drawing.Size(100, 20);
            this.textBoxnama.TabIndex = 4;
            // 
            // textBoxtim
            // 
            this.textBoxtim.Location = new System.Drawing.Point(535, 206);
            this.textBoxtim.Name = "textBoxtim";
            this.textBoxtim.Size = new System.Drawing.Size(100, 20);
            this.textBoxtim.TabIndex = 5;
            // 
            // textBoxstadion
            // 
            this.textBoxstadion.Location = new System.Drawing.Point(535, 233);
            this.textBoxstadion.Name = "textBoxstadion";
            this.textBoxstadion.Size = new System.Drawing.Size(100, 20);
            this.textBoxstadion.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(535, 285);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.BackColor = System.Drawing.Color.Transparent;
            this.labeltime.Location = new System.Drawing.Point(334, 52);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(0, 13);
            this.labeltime.TabIndex = 8;
            this.labeltime.Click += new System.EventHandler(this.labeltime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxstadion);
            this.Controls.Add(this.textBoxtim);
            this.Controls.Add(this.textBoxnama);
            this.Controls.Add(this.labelStadion);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.Label labelStadion;
        private System.Windows.Forms.TextBox textBoxnama;
        private System.Windows.Forms.TextBox textBoxtim;
        private System.Windows.Forms.TextBox textBoxstadion;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labeltime;
    }
}

