using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class EnterNameForm : Form
    {
        private FileReader fileReader = new FileReader();
        User user;
        public EnterNameForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            enterNameTextBox.Focus();
            string name = enterNameTextBox.Text.ToUpper();

            if (!IsValidName(name))
            {
                return;
            }
            user.Name = name;
            Close();
        }
        private bool IsValidName(string name)
        {
            if (name.Length > 20 || name.Length == 0)
            {
                enterNameTextBox.Text = "";
                MessageBox.Show("Введіть своє ім'я.");
                DialogResult = DialogResult.None;
                return false;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] < 'А' || name[i] > 'Я') && name[i] != 'Ь' && name[i] != 'і')
                {
                    enterNameTextBox.Text = "";
                    MessageBox.Show("Ім'я має містити літери українського алфавіту!");
                    DialogResult = DialogResult.None;
                    return false;
                }
            }
            return true;
        }
        private void EnterNameForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\User\Desktop\rules\rules.txt";
            string rulesText = fileReader.ReadTextFromFile(filePath);

            MessageBox.Show(rulesText);
        }
        
        
    }
}