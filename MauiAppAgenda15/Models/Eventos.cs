namespace MauiAppAgenda15.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; } = DateTime.Now.AddDays(1);
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; } = string.Empty;
        public double CustoPorParticipante { get; set; }

        public int DuracaoDias
        {
            get
            {
                TimeSpan diferenca = DataTermino.Date - DataInicio.Date;
                return Math.Max(1, (int)diferenca.TotalDays + 1);
            }
        }

        public double CustoTotal
        {
            get => NumeroParticipantes * CustoPorParticipante;
        }
    }
}