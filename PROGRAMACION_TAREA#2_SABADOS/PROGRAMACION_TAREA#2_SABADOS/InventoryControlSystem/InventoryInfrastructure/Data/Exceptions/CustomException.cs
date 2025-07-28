using System;

namespace InventoryInfrastructure.Data.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
