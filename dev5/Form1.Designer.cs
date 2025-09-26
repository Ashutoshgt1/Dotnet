namespace dev5
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
            label1 = new Label();
            label2 = new Label();
            nametxt = new TextBox();
            entxt = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            submitbutton = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            exitbtn = new Button();
            updatebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 74);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Enrollment No:";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(97, 32);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(100, 23);
            nametxt.TabIndex = 2;
            // 
            // entxt
            // 
            entxt.Location = new Point(118, 71);
            entxt.Name = "entxt";
            entxt.Size = new Size(100, 23);
            entxt.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 119);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "Sports Activity:";
            // 
            // submitbutton
            // 
            submitbutton.Location = new Point(37, 183);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(75, 23);
            submitbutton.TabIndex = 6;
            submitbutton.Text = "Submit";
            submitbutton.UseVisualStyleBackColor = true;
            submitbutton.Click += submitbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 258);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(173, 241);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 23);
            exitbtn.TabIndex = 9;
            exitbtn.Text = "exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(299, 247);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(75, 23);
            updatebtn.TabIndex = 10;
            updatebtn.Text = "update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 310);
            Controls.Add(updatebtn);
            Controls.Add(exitbtn);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(submitbutton);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(entxt);
            Controls.Add(nametxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nametxt;
        private TextBox entxt;
        private ComboBox comboBox1;
        private Label label3;
        private Button submitbutton;
        private DataGridView dataGridView1;
        private Label label4;
        private Button exitbtn;
        private Button updatebtn;
    }
}
