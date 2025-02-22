﻿using InputReader.Converters.CustomConverters;
using System;

namespace InputReader.Converters;

public class TimeOnlyValueConverter(string format = "HH:mm:ss") : IValueConverter<CustomTimeOnly?>
{
    public bool TryConvertFromString(string consoleInput, out CustomTimeOnly? value)
    {
        try
        {
            return CustomTimeOnly.TryParseExact(consoleInput, format, out value);
        }
        catch (ArgumentException)
        {
            value = default;
            return false;
        }
    }
}