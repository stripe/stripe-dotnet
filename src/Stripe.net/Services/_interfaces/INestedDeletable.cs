namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedDeletable<TEntity>
        where TEntity : IStripeEntity, IHasId
    {
        TEntity Delete(string parentId, string id, RequestOptions requestOptions = null);

        Task<TEntity> DeleteAsync(string parentId, string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
