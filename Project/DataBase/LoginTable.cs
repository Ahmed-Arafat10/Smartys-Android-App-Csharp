using SQLite;


namespace Project.DataBase
{
    public class LoginTable
    {

        [PrimaryKey, AutoIncrement, Column("_Id")]
        public int id { get; set; }
        [MaxLength(25)]
        public string Username { get; set; }
        [MaxLength(15)]
        public string Password { get; set; }

    }
}


