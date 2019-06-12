namespace Stripe
{
    public class EmptyValue : StringEnum
    {
        /// <summary>Empties the value.</summary>
        public static readonly EmptyValue Empty = new EmptyValue(string.Empty);

        private EmptyValue(string value)
            : base(value)
        {
        }
    }
}
