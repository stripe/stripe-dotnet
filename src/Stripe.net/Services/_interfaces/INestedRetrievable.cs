namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedRetrievable<T, O>
        where T : IStripeEntity, IHasId
        where O : BaseOptions
    {
        T Get(string parentId, string id, O retrieveOptions, RequestOptions requestOptions = null);

        Task<T> GetAsync(string parentId, string id, O retrieveOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
