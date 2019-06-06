namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRetrievable<T, O>
        where T : IStripeEntity, IHasId
        where O : BaseOptions
    {
        T Get(string id, O retrieveOptions, RequestOptions requestOptions = null);

        Task<T> GetAsync(string id, O retrieveOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
