namespace AdsAggregatorDomain
{
    /// <summary>
    /// Interface for using from Composition root for initializing persitant layer. 
    /// </summary>
    public interface IObjectsInitializer
    {
        void Initialize();
    }
}
