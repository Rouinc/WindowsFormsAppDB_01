namespace WindowsFormsAppDB_01
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
            this.dataGridViewmatch = new System.Windows.Forms.DataGridView();
            this.buttonfirst = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonlast = new System.Windows.Forms.Button();
            this.labelteam = new System.Windows.Forms.Label();
            this.labelmanager = new System.Windows.Forms.Label();
            this.labelstadium = new System.Windows.Forms.Label();
            this.labeltopscorer = new System.Windows.Forms.Label();
            this.labelworstdisc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmatch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmatch
            // 
            this.dataGridViewmatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmatch.Location = new System.Drawing.Point(89, 296);
            this.dataGridViewmatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewmatch.Name = "dataGridViewmatch";
            this.dataGridViewmatch.RowHeadersWidth = 51;
            this.dataGridViewmatch.RowTemplate.Height = 24;
            this.dataGridViewmatch.Size = new System.Drawing.Size(565, 274);
            this.dataGridViewmatch.TabIndex = 2;
            this.dataGridViewmatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonfirst
            // 
            this.buttonfirst.ImageKey = "(none)";
            this.buttonfirst.Location = new System.Drawing.Point(90, 50);
            this.buttonfirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonfirst.Name = "buttonfirst";
            this.buttonfirst.Size = new System.Drawing.Size(66, 53);
            this.buttonfirst.TabIndex = 3;
            this.buttonfirst.Text = "<<";
            this.buttonfirst.UseVisualStyleBackColor = true;
            this.buttonfirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(174, 50);
            this.buttonback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 50);
            this.buttonback.TabIndex = 4;
            this.buttonback.Text = "<";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(269, 50);
            this.buttonnext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(73, 50);
            this.buttonnext.TabIndex = 5;
            this.buttonnext.Text = ">";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonlast
            // 
            this.buttonlast.Location = new System.Drawing.Point(364, 50);
            this.buttonlast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonlast.Name = "buttonlast";
            this.buttonlast.Size = new System.Drawing.Size(72, 50);
            this.buttonlast.TabIndex = 6;
            this.buttonlast.Text = ">>";
            this.buttonlast.UseVisualStyleBackColor = true;
            this.buttonlast.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelteam
            // 
            this.labelteam.AutoSize = true;
            this.labelteam.Location = new System.Drawing.Point(86, 119);
            this.labelteam.Name = "labelteam";
            this.labelteam.Size = new System.Drawing.Size(103, 20);
            this.labelteam.TabIndex = 7;
            this.labelteam.Text = "Team Name :";
            this.labelteam.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelmanager
            // 
            this.labelmanager.AutoSize = true;
            this.labelmanager.Location = new System.Drawing.Point(86, 151);
            this.labelmanager.Name = "labelmanager";
            this.labelmanager.Size = new System.Drawing.Size(80, 20);
            this.labelmanager.TabIndex = 8;
            this.labelmanager.Text = "Manager :";
            // 
            // labelstadium
            // 
            this.labelstadium.AutoSize = true;
            this.labelstadium.Location = new System.Drawing.Point(86, 189);
            this.labelstadium.Name = "labelstadium";
            this.labelstadium.Size = new System.Drawing.Size(76, 20);
            this.labelstadium.TabIndex = 9;
            this.labelstadium.Text = "Stadium :";
            // 
            // labeltopscorer
            // 
            this.labeltopscorer.AutoSize = true;
            this.labeltopscorer.Location = new System.Drawing.Point(86, 220);
            this.labeltopscorer.Name = "labeltopscorer";
            this.labeltopscorer.Size = new System.Drawing.Size(95, 20);
            this.labeltopscorer.TabIndex = 10;
            this.labeltopscorer.Text = "Top Scorer :";
            // 
            // labelworstdisc
            // 
            this.labelworstdisc.AutoSize = true;
            this.labelworstdisc.Location = new System.Drawing.Point(86, 252);
            this.labelworstdisc.Name = "labelworstdisc";
            this.labelworstdisc.Size = new System.Drawing.Size(130, 20);
            this.labelworstdisc.TabIndex = 11;
            this.labelworstdisc.Text = "Worst Discipline :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 695);
            this.Controls.Add(this.labelworstdisc);
            this.Controls.Add(this.labeltopscorer);
            this.Controls.Add(this.labelstadium);
            this.Controls.Add(this.labelmanager);
            this.Controls.Add(this.labelteam);
            this.Controls.Add(this.buttonlast);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonfirst);
            this.Controls.Add(this.dataGridViewmatch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewmatch;
        private System.Windows.Forms.Button buttonfirst;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttonlast;
        private System.Windows.Forms.Label labelteam;
        private System.Windows.Forms.Label labelmanager;
        private System.Windows.Forms.Label labelstadium;
        private System.Windows.Forms.Label labeltopscorer;
        private System.Windows.Forms.Label labelworstdisc;
    }
}

