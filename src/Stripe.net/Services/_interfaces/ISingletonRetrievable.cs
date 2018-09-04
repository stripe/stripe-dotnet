namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface ISingletonRetrievable<T>
        where T : StripeEntity
    {
        T Get(RequestOptions requestOptions = null);

        Task<T> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
