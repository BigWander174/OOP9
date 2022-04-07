using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP9.DB
{

    [Table("phone_book")]
    public class PhoneBook
    {
        [Column("surname")]
        public string Surname { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("phone")]
        [Key] public string Phone { get; set; }

        public string[] Info;
        public string this[int index]
        {
            get
            {
                return Info[index];
            }
        }

        public PhoneBook()
        {
            Info = new string[] {Surname, Name, Lastname, Phone};
        }

        public string GetInfo()
        {
            return $"{Surname} {Name} {Lastname} {Phone}";
        }
    }
}