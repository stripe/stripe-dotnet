namespace Stripe
{
    /// <summary>Represents a generic expandable field.</summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
    internal class Emptyable<T>
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
    }
}
