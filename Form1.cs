namespace BankSystem
{
    public partial class Form1 : Form
    {

        private Customer customer;
        private Account? account;

        private EverydayAccount everydayAccount;
        private Investment interestAccount;
        private Omni omniAccount;

        public Form1()
        {
            InitializeComponent();
            customer = new Customer("Gurjeet", 23213432, true);

            accountComboBox.SelectedIndexChanged += accountComboBox_SelectedIndexChanged;

            // Initialize instances of the child account classes
            everydayAccount = new EverydayAccount(1000);
            interestAccount = new Investment(1000);
            omniAccount = new Omni(1000);
        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account selectedAccount = (Account)accountComboBox.SelectedItem;
            if (selectedAccount != null)
            {
                infoLabel.Text = $"You selected an {selectedAccount.AccountType}.";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add child account instances to the ComboBox
            accountComboBox.Items.Add(everydayAccount);
            accountComboBox.Items.Add(interestAccount);
            accountComboBox.Items.Add(omniAccount);

            // Select the first item by default
            accountComboBox.SelectedIndex = 0;

            labelCustomer.Text = $"Welcome, {customer.Name}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedItem != null)
            {
                account = (Account)accountComboBox.SelectedItem;

                if (amountTextBox.Text != null && double.TryParse(amountTextBox.Text, out double amount) && amount > 0)
                {
                    account.Deposite(amount);
                    
                    label2.Text = $"Deposited {amount:C} into {account.AccountType}.";
                    amountTextBox.Clear();
                    UpdateInfo();
                }
                else
                {
                    MessageBox.Show("Please enter a valid deposit amount.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedItem != null)
            {
                account = (Account)accountComboBox.SelectedItem;

                if (amountTextBox.Text != null && double.TryParse(amountTextBox.Text, out double amount) && amount > 0)
                {
                    account.Withdraw(amount);
                    UpdateInfo();
                    label2.Text = $"withdraw {amount:C} from {account.AccountType}.";
                    amountTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid withdraw amount.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedItem != null)
            {
                account = (Account)accountComboBox.SelectedItem;

                if (amountTextBox.Text != null && double.TryParse(amountTextBox.Text, out double amount) && amount > 0)
                {
                    account.Interest(amount);

                    UpdateInfo();
                    label2.Text = $"Interest {amount:C} from {account.AccountType}.";
                    amountTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Interest amount.");
                }


            }
        }

        private void UpdateInfo()
        {
            listBox1.Items.Clear();

            if (accountComboBox.SelectedItem != null)
            {
              
                if (accountComboBox.SelectedItem is Account account)
                {
                    listBox1.Items.Add(account.GetInfo());
                }
            }
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}