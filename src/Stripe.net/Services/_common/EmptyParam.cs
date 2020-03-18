namespace Stripe
{
    public class EmptyParam : StringEnum
    {
        /// <summary>Special value used to unset a field.</summary>
        public static readonly EmptyParam Empty = new EmptyParam(string.Empty);

        private EmptyParam(string value)
            : base(value)
        {
        }
    }
}
