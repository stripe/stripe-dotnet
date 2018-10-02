namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IListable<T, O>
        where T : IStripeEntity
        where O : ListOptions
    {
        StripeList<T> List(O listOptions = null, RequestOptions requestOptions = null);

        Task<StripeList<T>> ListAsync(O listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
