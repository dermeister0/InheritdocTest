using System.Collections.Generic;
using System.Threading.Tasks;

namespace Generic40.Domain
{
    /// <summary>
    /// Interface for value providers.
    /// </summary>
    public interface IAnotherValueProvider
    {
        /// <summary>
        /// Returns value.
        /// </summary>
        /// <returns>The value.</returns>
        int GetValue();

        /// <summary>
        /// Returns values.
        /// </summary>
        /// <returns>The list of values.</returns>
        IEnumerable<int> GetValues();

        /// <summary>
        /// Processes data.
        /// </summary>
        /// <returns>Async task.</returns>
        Task DoWorkAsync();
    }
}
