namespace MinhaMissaCore.Model
{
    public class Instituition
    {
        public int Id { get; set; } = default;

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<User> Users { get; set; } = default!;
    }
}