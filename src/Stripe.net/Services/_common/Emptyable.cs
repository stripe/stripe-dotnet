namespace Stripe
{
    /// <summary>Represents a field that might be emptyble.</summary>
    /// <typeparam name="T">Type of the field when not empty.</typeparam>
    internal class Emptyable<T> : IEmptyable<T>
    {
        private bool empty;
        private T value;

        public T Value
        {
            get => this.value;
            set
            {
                this.value = value;
                this.empty = false;
            }
        }

        public bool Empty
        {
            get => this.empty;
            set
            {
                this.empty = value;
                if (value)
                {
                    this.value = default(T);
                }
            }
        }

        /// <summary>Gets or sets the expanded object.</summary>
        /// <value>The expanded object.</value>
        object IEmptyable.Value => this.Value;
    }
}
