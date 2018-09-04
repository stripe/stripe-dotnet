namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface ICreatable<T, O>
        where T : StripeEntity
        where O : BaseOptions
    {
        T Create(O createOptions, RequestOptions requestOptions = null);

        Task<T> CreateAsync(O createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
