namespace MVCProject.Models
{
    public class  User
    {
        public User(string name, string password, string email, string phone)//констр
        {
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Password { get; set;}
        public string Email { get; set;}
        public string Phone { get; set;}

        public int Id { get; set; }


    }
}
