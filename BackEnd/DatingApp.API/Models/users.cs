namespace DatingApp.API.Models
{
    public class User
    {
        public int ID {get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string UserName {get; set; }
        public byte[] PasswordHash {get; set; }
        public byte[] PasswordSalt {get; set; }

    }
}