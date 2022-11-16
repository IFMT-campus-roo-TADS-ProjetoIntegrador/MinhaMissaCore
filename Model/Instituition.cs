namespace MinhaMissaCore.Model
{
    public class Instituition
    {
        public Guid Id { get; set; } = default(Guid);

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<User> Users { get; set; } = default!;
    }
}