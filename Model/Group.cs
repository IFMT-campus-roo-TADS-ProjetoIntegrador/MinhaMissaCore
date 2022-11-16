namespace MinhaMissaCore.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Instituition> Instituitions { get; set; }
        public List<User> Users { get; set; };
    }
}
