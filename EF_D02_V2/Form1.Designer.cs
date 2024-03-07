namespace EF_D02_V2
{
    partial class Form1
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
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            deptBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addbtn = new Button();
            delbtn = new Button();
            editbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 322);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(601, 101);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(177, 27);
            nameTextBox.TabIndex = 1;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(601, 154);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(177, 27);
            ageTextBox.TabIndex = 2;
            // 
            // deptBox
            // 
            deptBox.FormattingEnabled = true;
            deptBox.Location = new Point(601, 212);
            deptBox.Name = "deptBox";
            deptBox.Size = new Size(177, 28);
            deptBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 101);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 157);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 212);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Department";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(483, 362);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(295, 29);
            addbtn.TabIndex = 7;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // delbtn
            // 
            delbtn.Location = new Point(483, 327);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(141, 29);
            delbtn.TabIndex = 8;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += delbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(651, 327);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(127, 29);
            editbtn.TabIndex = 9;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editbtn);
            Controls.Add(delbtn);
            Controls.Add(addbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deptBox);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private ComboBox deptBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addbtn;
        private Button delbtn;
        private Button editbtn;
    }
}
