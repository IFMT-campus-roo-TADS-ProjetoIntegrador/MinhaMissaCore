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
        /// Descrição do evento. Conta resumidamente como será o evento.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Dia de início do evento.
        /// </summary>
        public DateTime StartDate { get; set; } = default!;
        /// <summary>
        /// Data de encerramento do evento.
        /// </summary>
        public DateTime LastDate { get; set; } = default!;
        /// <summary>
        /// Local do evento.
        /// </summary>
        public string Local { get; set; } = string.Empty;
        /// <summary>
        /// Acentos no evento (lugares).
        /// </summary>
        public int Places { get; set; } = default!;
        /// <summary>
        /// Indica se o usuário está ativo.
        /// </summary>
        public bool Active { get; set; } = default!;
        
    }
}
