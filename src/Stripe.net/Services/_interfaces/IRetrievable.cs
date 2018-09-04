namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRetrievable<T>
        where T : StripeEntity
    {
        T Get(string id, RequestOptions requestOptions = null);

        Task<T> GetAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
