﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SadConsole
{
    public static class IListExtensions
    {
        /// <summary>
        /// Removes each item from a list one-by-one.
        /// </summary>
        /// <param name="list">The list collection to remove from.</param>
        public static void RemoveAll(this IList list)
        {
            while (list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
