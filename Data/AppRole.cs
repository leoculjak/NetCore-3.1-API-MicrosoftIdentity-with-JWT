using System.ComponentModel.DataAnnotations;

namespace IdentityTest.Data
{
    public class AppRole
    {
        [Key]
        public string Id { get; set; }
    }
}