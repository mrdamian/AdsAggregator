namespace AdsAggregatorDomain.Repositories
{
    public interface ICityRepository
    {
        void Insert(City city);

        void Delete(City city);

        void Update(City city);
    }
}
