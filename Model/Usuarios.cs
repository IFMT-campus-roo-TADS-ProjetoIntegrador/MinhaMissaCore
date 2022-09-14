namespace MinhaMissaCore.Model
{
    public class Usuarios
    {
        public int Id { get; set; } = default!;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        /// <summary>
        /// Define a regra de acesso do usuário.
        /// TODO Definir uma interface Enum para os tipos de usuários do sistema.
        /// </summary>
        public string Role { get; set; } = string.Empty;
    }
}
