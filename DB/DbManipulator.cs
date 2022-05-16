namespace OOP9.DB
{
    internal static class DbManipulator
    {
        internal static void Add(User user)
        {
            using (var db = new UserContext())
            {
                try
                {
                    db.PhoneBooks.Add(user);
                    db.SaveChanges();
                }
                catch { }
            }
        }

        internal static void SetInfo(object sender, DataGridViewCellEventArgs e)
        {
            string value;
            DataGridView table;
            try
            {
                table = (DataGridView)sender;
                value = Convert.ToString(table[e.ColumnIndex, e.RowIndex].Value);
            }
            catch
            {
                return;
            }

            using (var db = new UserContext())
            {
                int id = Convert.ToInt32(table[0, e.RowIndex].Value);
                var user = db.PhoneBooks.Where(x => x.ID == id).FirstOrDefault();

                user[e.ColumnIndex] = value;
                db.SaveChanges();
            }
        }

        internal static void RemoveBy(int id)
        {
            using (var db = new UserContext())
            {
                try
                {
                    var user = db.PhoneBooks.Where(x => x.ID == id).FirstOrDefault();
                    db.PhoneBooks.Remove(user);
                    db.SaveChanges();
                }
                catch
                {
                }
            }
        }
    }
}
