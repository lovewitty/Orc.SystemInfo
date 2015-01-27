﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pair.cs" company="Wild Gums">
//   Copyright (c) 2008 - 2015 Wild Gums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.SystemInfo
{
    using System;

    [Serializable]
    public class SystemInfoElement
    {
        public SystemInfoElement()
        {
            Name = string.Empty;
            Value = string.Empty;
        }

        public SystemInfoElement(string name, string value)
            : this()
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            var result = Name;

            if (!string.IsNullOrWhiteSpace(Value))
            {
                if (string.IsNullOrWhiteSpace(result))
                {
                    result = "  ";
                }
                else
                {
                    result += ": ";
                }

                result += Value;
            }

            return result;
        }
    }
}