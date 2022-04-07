namespace OOP9.DB
{
    internal class DbManipulator
    {
        internal void Work(PhoneBook user)
        {
            using (var db = new PhoneBookContext())
            {
                try
                {
                    db.PhoneBooks.Add(user);
                    db.SaveChanges();
                }
                catch { }
            }
        }
    }
}
