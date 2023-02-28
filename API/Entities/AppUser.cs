namespace API.Entities
{
    public class AppUser
    {
        //[Key] if Id would have another name
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
