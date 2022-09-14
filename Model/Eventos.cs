namespace MinhaMissaCore.Model
{
    public class Eventos
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataAbertura { get; set; } = default!;
        public DateTime DataEncerramento { get; set; } = default!;
        public string Local { get; set; } = string.Empty;
        public int Vagas { get; set; } = default!;
        public bool Ativo { get; set; } = default!;
        
    }
}
