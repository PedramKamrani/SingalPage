namespace DataLayer.Entites.Account
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public int Email { get; set; }
        public int Password { get; set; }
        public bool IsActive { get; set; }
        public List<RoleUser> RoleUsers { get; set; }
    }
}
