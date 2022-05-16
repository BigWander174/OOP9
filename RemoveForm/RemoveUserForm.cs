namespace OOP9.RemoveForm
{
    public partial class RemoveUserForm : Form
    {
        private OOP _form;
        public RemoveUserForm(OOP form)
        {
            InitializeComponent();
            _form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                _form.RemoveUser(id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
