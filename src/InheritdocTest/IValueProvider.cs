﻿using System.Collections.Generic;

namespace InheritdocTest
{
    /// <summary>
    /// Interface for value providers.
    /// </summary>
    public interface IValueProvider
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
    }
}
