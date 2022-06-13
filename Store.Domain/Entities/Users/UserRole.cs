using System.ComponentModel.DataAnnotations;
namespace Store.Domain.Entities.Users
{
    public class UserRole
    {
        [Key]
        public long Id { get; set; }
        public virtual User User { get; set; }
        public long UserId { get; set; }

        public virtual Role Role { get; set; }
        public long RoleId { get; set; }


    }
}
