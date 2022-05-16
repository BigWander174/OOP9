using OOP9.DB;

namespace OOP9.AddForm
{
    public partial class AddUserForm : Form
    {
        private OOP _form1;
        public AddUserForm(OOP form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var user =  new User
            {
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Lastname = lastnameBox.Text,
                Phone = Convert.ToInt64(phoneBox.Text)
            };

            _form1.AddNewUser(user);
        }
    }
}
