namespace Antares.DesignPatterns.DataFlow.Pipeline
{
    public interface IProcessor<T>
    {
        T Process(T input);
    }
}
