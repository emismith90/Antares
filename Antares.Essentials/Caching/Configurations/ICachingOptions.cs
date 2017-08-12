namespace Antares.Essentials.Caching.Configurations
{
    public interface ICachingOptions
    {
        int ExpiredInMinute { get; }
        int SlidingInMinute { get; }
        int RetryInSecond { get; }
    }
}
