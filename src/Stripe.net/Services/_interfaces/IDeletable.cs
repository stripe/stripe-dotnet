namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDeletable<TEntity>
        where TEntity : IStripeEntity, IHasId
    {
        TEntity Delete(string id, RequestOptions requestOptions = null);

        Task<TEntity> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
