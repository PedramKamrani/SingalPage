namespace DataLayer.Entites.Account
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public List<RoleUser> RoleUsers { get; set; }
    }
}
