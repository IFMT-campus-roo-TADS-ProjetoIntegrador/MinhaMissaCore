namespace MinhaMissaCore.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<Instituition> Instituitions { get; set; } = default!;
        public List<User> Users { get; set; } = default!;
    }
}
