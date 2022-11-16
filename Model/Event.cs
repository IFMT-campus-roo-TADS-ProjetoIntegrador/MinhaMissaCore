namespace MinhaMissaCore.Model
{
    public class Event
    {
        /// <summary>
        /// Identificação do evento.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do Evento, título.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Localização do local do evento.
        /// </summary>
        public string Location { get; set; } = string.Empty ;

        /// <summary>
        /// Descrição do evento. Conta resumidamente como será o evento.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Dia de início do evento.
        /// </summary>
        public DateTime StartDate { get; set; } = default!;
        /// <summary>
        /// Duração do evento.
        /// </summary>
        public DateTime Duration { get; set; } = default!;
        /// <summary>
        /// Acentos no evento (lugares).
        /// </summary>
        public int Seats { get; set; } = default!;
        /// <summary>
        /// Instituição do evento.
        /// </summary>
        public Instituition Instituition { get; set; } = default!;
        /// <summary>
        /// Lista de usuários participantes do Evento.
        /// </summary>
        public List<User> Participants { get; set; } = default!;
        /// <summary>
        /// Indica se o evento está ativo.
        /// </summary>
        public bool Active { get; set; } = default!;
    }
}
