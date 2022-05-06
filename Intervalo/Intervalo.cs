using System;
namespace AquecimentoOO
{
    public class Intervalo
    {
        private TimeSpan duracao;

        public DateTime dataHoraInicio { get; }
        public DateTime dataHoraFinal { get; }
        public TimeSpan Duracao { get => duracao; set => duracao = dataHoraFinal - dataHoraInicio; }

        public Intervalo(DateTime inicio, DateTime final)
        {
            if (inicio > final)
            {
                throw new ArgumentException("A data/hora de inicio não pode ser posterior a data/hora final");
            }

            dataHoraInicio = inicio;
            dataHoraFinal = final;
            Duracao = dataHoraInicio - dataHoraFinal;
        }

        public bool TemIntersecao(Intervalo intervalo)
        {
            return !(dataHoraInicio > intervalo.dataHoraFinal || dataHoraFinal < intervalo.dataHoraInicio);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Intervalo))
            {
                return false;
            }
            return (dataHoraInicio == ((Intervalo)obj).dataHoraInicio)
                 && (dataHoraFinal == ((Intervalo)obj).dataHoraFinal);
        }
    }
}
