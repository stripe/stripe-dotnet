namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedRetrievable<T>
        where T : IStripeEntity, IHasId
    {
        T Get(string parentId, string id, RequestOptions requestOptions = null);

        Task<T> GetAsync(string parentId, string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
