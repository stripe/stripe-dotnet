namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedDeletable<T>
        where T : StripeEntity
    {
        T Delete(string parentId, string id, RequestOptions requestOptions = null);

        Task<T> DeleteAsync(string parentId, string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
