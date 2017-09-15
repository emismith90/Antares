
namespace Antares.DesignPatterns.DataFlow.Pipeline
{
    public interface IPipeline<T>
    {
        T ProcessAll(T input);
    }
}
