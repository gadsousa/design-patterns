namespace DesignPatterns.Behavioral.Observer
{
    // Observer
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
