﻿using System;

namespace SmartAnalyzers.CSharpExtensions.Annotations
{
    public sealed class TwinTypeAttribute : Attribute
    {
        public string[] IgnoredMembers { get; set; }
        public TwinTypeAttribute(Type type)
        {
        }
    }
}