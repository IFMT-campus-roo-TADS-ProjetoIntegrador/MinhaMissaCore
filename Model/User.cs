namespace MinhaMissaCore.Model
{
    public class User
    {
        /// <summary>
        /// Identificador do usuário.
        /// </summary>
        public int Id { get; set; } = default!;
        /// <summary>
        /// Nome completo do usuário.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Email do usuário.
        /// </summary>
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string Password { get; set; } = string.Empty;
        /// <summary>
        /// Define a regra de acesso do usuário.
        /// TODO Definir uma interface Enum para os tipos de usuários do sistema.
        /// </summary>
        public string Role { get; set; } = string.Empty;
    }
}
