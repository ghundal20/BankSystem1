namespace BankSystem
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
            labelCustomer = new Label();
            accountComboBox = new ComboBox();
            infoLabel = new Label();
            amountTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomer.Location = new Point(133, 43);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(113, 32);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Greeting";
            // 
            // accountComboBox
            // 
            accountComboBox.FormattingEnabled = true;
            accountComboBox.Location = new Point(61, 119);
            accountComboBox.Name = "accountComboBox";
            accountComboBox.Size = new Size(367, 33);
            accountComboBox.TabIndex = 1;
            accountComboBox.SelectedIndexChanged += accountComboBox_SelectedIndexChanged;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.Location = new Point(61, 256);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(170, 28);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "SelectedAccount";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(841, 65);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(149, 31);
            amountTextBox.TabIndex = 3;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(878, 130);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Deposite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(878, 170);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(878, 210);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Interest";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(51, 377);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(819, 204);
            listBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 318);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 8;
            label2.Text = "Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(686, 65);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 9;
            label1.Text = "Enter amount- ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1104, 630);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(amountTextBox);
            Controls.Add(infoLabel);
            Controls.Add(accountComboBox);
            Controls.Add(labelCustomer);
            Name = "Form1";
            Text = "BankSyatem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomer;
        private ComboBox accountComboBox;
        private Label infoLabel;
        private TextBox amountTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Label label2;
        private Label label1;
    }
}