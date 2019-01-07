namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IUpdatable<T, O>
        where T : IStripeEntity, IHasId
        where O : BaseOptions
    {
        T Update(string id, O updateOptions, RequestOptions requestOptions = null);

        Task<T> UpdateAsync(string id, O updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
