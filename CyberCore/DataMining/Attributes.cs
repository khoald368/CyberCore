using System;

namespace CyberCore.DataMining.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BaseViewAttribute : Attribute
    {
        public string TableName { get; set; }
    }
}
