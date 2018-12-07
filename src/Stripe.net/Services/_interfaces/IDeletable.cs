namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDeletable<T>
        where T : IStripeEntity, IHasId
    {
        T Delete(string id, RequestOptions requestOptions = null);

        Task<T> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
