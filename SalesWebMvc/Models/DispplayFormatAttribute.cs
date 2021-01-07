using System;

namespace SalesWebMvc.Models
{
    internal class DispplayFormatAttribute : Attribute
    {
        public string DataFormatString { get; set; }
    }
}