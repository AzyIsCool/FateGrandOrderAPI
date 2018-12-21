﻿using FateGrandOrderApi.Classes;
using System.Collections.Generic;

namespace FateGrandOrderApi.Caching
{
    /// <summary>
    /// Everything that has been setup for caching
    /// </summary>
    public static class FateGrandOrderPersonCache
    {
        /// <summary>
        /// People that are currently in the cache
        /// </summary>
        public static List<FateGrandOrderPerson> FateGrandOrderPeople { get; set; }
        public static List<Item> Items { get; set; }
    }
}
