using System.ComponentModel.DataAnnotations;
namespace Store.Domain.Entities.Users
{
    public class Role
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
