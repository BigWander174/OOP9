using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOP9.DB
{

    [Table("Users")]
    public class User
    {
        [Key]public int ID { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public long Phone { get; set; }

        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 1:
                        Surname = value;
                        break;
                    case 2:
                        Name = value;
                        break;
                    case 3:
                        Lastname = value;
                        break;
                    case 4:
                        Phone = Convert.ToInt64(value);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}