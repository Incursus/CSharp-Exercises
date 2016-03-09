﻿using System.Diagnostics;

namespace DebuggerDisplay
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class House
    {
        public string Street { get; set; }
        public string Number { get; set; }

        private string DebuggerDisplay
        {
            get
            {
                return $"Number {Number}, Street: {Street}";
            }
        }
    }
}
