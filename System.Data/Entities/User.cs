namespace System.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin,
        Customer
    }
}
