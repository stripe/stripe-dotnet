namespace Stripe
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    /// <summary>
    /// <para>
    /// <see cref="NonConsecutiveList{T}" /> behaves just like a normal <see cref="List{T}"/>,
    /// except that the indices may be non-consecutive. Use <see cref="Insert" /> or
    /// <see cref="this[int]" /> to insert items at any index.
    /// </para>
    /// <para>
    /// This is useful for update requests, when an existing resource contains a list of elements
    /// and you only want to update certain elements.
    /// </para>
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    public class NonConsecutiveList<T> : INonConsecutiveList<T>
    {
        /// <summary>Store for the list indices and values.</summary>
        private Dictionary<int, T> contents = new Dictionary<int, T>();

        /// <summary>
        /// Value of the next index when adding an element in the list without an explicit index.
        /// </summary>
        private int nextIndex;

        /// <summary>
        /// Gets the number of elements contained in the <see cref="NonConsecutiveList{T}" />.
        /// </summary>
        /// <value>
        /// The number of elements contained in the <see cref="NonConsecutiveList{T}" />.
        /// </value>
        /// <remarks>
        /// Because the indices may be non-consecutive, this value may be less than the value of the
        /// max index. Do not use this value to iterate over the contents of the list; instead, use
        /// <code>foreach</code> or iterate over the <see cref="Dictionary" /> containing the
        /// indices.
        /// </remarks>
        public int Count => this.contents.Count;

        /// <summary>
        /// Gets the read-only dictionary containing the <see cref="NonConsecutiveList{T}" />'s
        /// indices and values.
        /// </summary>
        /// <value>
        /// The read-only dictionary containing the <see cref="NonConsecutiveList{T}" />'s indices
        /// and values.
        /// </value>
        public ImmutableDictionary<int, T> Dictionary => this.contents.ToImmutableDictionary();

        ImmutableDictionary<int, object> INonConsecutiveList.Dictionary =>
            this.contents.Select(x => new KeyValuePair<int, object>(x.Key, (object)x.Value)).ToImmutableDictionary();

        /// <summary>
        /// Gets a value indicating whether the <see cref="NonConsecutiveList{T}" /> has a fixed
        /// size.
        /// </summary>
        /// <value>
        /// <code>true</code> if the <see cref="NonConsecutiveList{T}" /> has a fixed size;
        /// otherwise, <code>false</code>.
        /// </value>
        public bool IsFixedSize => false;

        /// <summary>
        /// Gets a value indicating whether the <see cref="NonConsecutiveList{T}" /> is read-only.
        /// </summary>
        /// <value>
        /// <code>true</code> if the <see cref="NonConsecutiveList{T}" /> is read-only; otherwise,
        /// <code>false</code>.
        /// </value>
        public bool IsReadOnly => false;

        /// <summary>Gets or sets the element at the specified index.</summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <value>The element at the specified index.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <code>index</code> is not a valid index in the <see cref="NonConsecutiveList{T}" />.
        /// </exception>
        public T this[int index]
        {
            get => this.contents[index];
            set => this.contents[index] = value;
        }

        /// <summary>Adds an item to the <see cref="NonConsecutiveList{T}" />.</summary>
        /// <param name="value">
        /// The object to be added to the <see cref="NonConsecutiveList{T}" />.
        /// </param>
        public void Add(T value)
        {
            this.contents[this.nextIndex] = value;
            this.nextIndex += 1;
        }

        /// <summary>Removes all items from the <see cref="NonConsecutiveList{T}" />.</summary>
        public void Clear()
        {
            this.contents.Clear();
            this.nextIndex = 0;
        }

        /// <summary>
        /// Determines whether the <see cref="NonConsecutiveList{T}" /> contains a specific value.
        /// </summary>
        /// <param name="value">
        /// The object to locate in the <see cref="NonConsecutiveList{T}" />.
        /// </param>
        /// <returns>
        /// <code>true</code> if the object is found in the <see cref="NonConsecutiveList{T}" />;
        /// otherwise, <code>false</code>.
        /// </returns>
        public bool Contains(T value)
        {
            return this.contents.ContainsValue(value);
        }

        /// <summary>
        /// Copies the elements of the <see cref="NonConsecutiveList{T}" /> to an Array, starting at
        /// a particular Array index.
        /// </summary>
        /// <param name="array">
        /// The one-dimensional Array that is the destination of the elements copied from
        /// <see cref="NonConsecutiveList{T}" />. The Array must have zero-based indexing.
        /// </param>
        /// <param name="index">
        /// The zero-based index in <code>array</code> at which copying begins.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <code>array</code> is <code>null</code>.
        /// </exception>
        public void CopyTo(T[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Value cannot be null.");
            }

            int j = index;
            foreach (var value in this.contents.Values)
            {
                array.SetValue(value, j);
                j++;
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="NonConsecutiveList{T}" />'s
        /// values.
        /// </summary>
        /// <returns>
        /// An IEnumerator object that can be used to iterate through the
        /// <see cref="NonConsecutiveList{T}" />'s values.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this.contents.Values.GetEnumerator();
        }

        /// <summary>
        /// Determines the index of a specific item in the <see cref="NonConsecutiveList{T}" />.
        /// </summary>
        /// <param name="value">
        /// The object to localte in the <see cref="NonConsecutiveList{T}" />.
        /// </param>
        /// <returns>
        /// The index of <code>value</code> if found in the <see cref="NonConsecutiveList{T}" />;
        /// otherwise, -1.
        /// </returns>
        public int IndexOf(T value)
        {
            KeyValuePair<int, T> entry;

            try
            {
                entry = this.contents.First(x => EqualityComparer<T>.Default.Equals(x.Value, value));
            }
            catch (InvalidOperationException)
            {
                return -1;
            }

            return entry.Key;
        }

        /// <summary>
        /// Inserts an item in the <see cref="NonConsecutiveList{T}" /> at the specified index.
        /// </summary>
        /// <param name="index">
        /// The zero-based index at which <code>value</code> should be inserted.
        /// </param>
        /// <param name="value">
        /// The object to insert into the <see cref="NonConsecutiveList{T}" />.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <code>index</code> is less than zero.
        /// </exception>
        public void Insert(int index, T value)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative.");
            }

            this.contents[index] = value;
            if (index >= this.nextIndex)
            {
                this.nextIndex = index + 1;
            }
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the
        /// <see cref="NonConsecutiveList{T}" />.
        /// </summary>
        /// <param name="value">
        /// The object to remove from the <see cref="NonConsecutiveList{T}" />.
        /// </param>
        /// <returns>
        /// <code>true</code> if the object was found and removed from the
        /// <see cref="NonConsecutiveList{T}" />; otherwise, <code>false</code>.
        /// </returns>
        public bool Remove(T value)
        {
            var index = this.IndexOf(value);

            if (index < 0)
            {
                return false;
            }

            return this.contents.Remove(this.IndexOf(value));
        }

        /// <summary>
        /// Removes the <see cref="NonConsecutiveList{T}" /> item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove.</param>
        public void RemoveAt(int index)
        {
            this.contents.Remove(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }
    }
}
