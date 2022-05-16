using OOP9.AddForm;
using OOP9.RemoveForm;
using OOP9.DB;

namespace OOP9
{
    public partial class OOP : Form
    {
        public OOP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTableFromDatabase();
        } 

        private void FillTableFromDatabase()
        {
            dataGridView1.Rows.Clear();
            using (var db = new UserContext())
            {
                var allUsers = db.PhoneBooks.ToArray();
                foreach (var user in allUsers)
                {
                    dataGridView1.Rows.Add(user.ID, user.Surname, user.Name, user.Lastname, user.Phone);
                }
            }
        }

        internal void AddNewUser(User user)
        {
            DbManipulator.Add(user);
            FillTableFromDatabase();
        }

        internal void RemoveUser(int id)
        {
            DbManipulator.RemoveBy(id);
            FillTableFromDatabase();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DbManipulator.SetInfo(sender, e);
        }

        private void ‰Ó·‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(this);
            addUserForm.ShowDialog();
            FillTableFromDatabase();
        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var removeUserForm = new RemoveUserForm(this);
            removeUserForm.ShowDialog();
            FillTableFromDatabase();
        }
    }
}