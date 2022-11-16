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
        public string Username { get; set; } = string.Empty;
        /// <summary>
        /// Email do usuário.
        /// </summary>
        public string[] PasswordHash { get; set; } = default!;
        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string[] PasswordSalt { get; set; } = default!;
        /// <summary>
        /// Define a regra de acesso do usuário.
        /// </summary>
        public string Role { get; set; } = string.Empty;
        /// <summary>
        /// Lista de eventos registrados do usuário.
        /// </summary>
        public List<Event> EventsRegistered { get; set; } = default!;
    }
}
