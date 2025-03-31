namespace Stripe
{
    /// <summary>
    /// Represents a value that may be of one of several different types.
    /// </summary>
    public interface IEmptyable
    {
        /// <summary>Gets whether or not the field is empty.</summary>
        /// <returns>True if the value is empty; false if the value is set.</returns>
        public bool Empty { get; }

        /// <summary>Gets the value of the current <see cref="IEmptyable"/> object.</summary>
        /// <returns>The value of the current <see cref="IEmptyable"/> object.</returns>
        object Value { get; }
    }

    /// <summary>Represents a generic expandable field.</summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
    public interface IEmptyable<T> : IEmptyable
    {
        /// <summary>Gets the value of the current <see cref="IEmptyable"/> object.</summary>
        /// <returns>The value of the current <see cref="IEmptyable"/> object.</returns>
        new T Value { get; set; }
    }
}
