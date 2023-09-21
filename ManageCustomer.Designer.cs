namespace BankSystem
{
    partial class ManageCustomer
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(19, 464);
            button1.Name = "button1";
            button1.Size = new Size(178, 66);
            button1.TabIndex = 0;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 464);
            button2.Name = "button2";
            button2.Size = new Size(178, 66);
            button2.TabIndex = 1;
            button2.Text = "Update Customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(469, 464);
            button3.Name = "button3";
            button3.Size = new Size(178, 66);
            button3.TabIndex = 2;
            button3.Text = "Delete Customer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 92);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 9;
            label2.Text = "Write Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 221);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 10;
            label3.Text = "Write contact detail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 348);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 11;
            label1.Text = "staff status";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(307, 348);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 29);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "yes";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(742, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(439, 454);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1243, 663);
            Controls.Add(listBox1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Black;
            Name = "ManageCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomer";
            Load += ManageCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label1;
        private CheckBox checkBox1;
        private ListView listView1;
        private ListBox listBox1;
    }
}