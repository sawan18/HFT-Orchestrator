﻿using System;

namespace MyData.Csv
{
    [Flags]
    public enum ValueTrimmingOptions
    {
        None = 0,
        UnquotedOnly = 1,
        QuotedOnly = 2,
        All = UnquotedOnly | QuotedOnly
    }
}