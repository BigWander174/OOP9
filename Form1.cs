using OOP9.AddForm;
using OOP9.DB;

namespace OOP9
{
    public partial class Form1 : Form
    {
        private DbManipulator _dbAdder = new DbManipulator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTableFromDatabase();
        }

        private void FillTableFromDatabase()
        {
            using (var db = new PhoneBookContext())
            {
                var allUsers = db.PhoneBooks.ToArray();

                foreach (var user in allUsers)
                {
                    dataGridView1.Rows.Add(user.Surname, user.Name, user.Lastname, user.Phone);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(this);
            addUserForm.ShowDialog();
        }

        internal void AddNewUser(PhoneBook user)
        {
            _dbAdder.Work(user);
            AddNewRow(user);
        }

        private void AddNewRow(PhoneBook user)
        {
            dataGridView1.Rows.Add(user.Surname, user.Name, user.Lastname, user.Phone);
        }
    }
}