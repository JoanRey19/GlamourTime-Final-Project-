namespace GlamourTime.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Phone { get; set; }

        public string? Email { get; set; }

    }
}
