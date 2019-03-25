using System;
using System.Collections.Generic;
using System.Text;

namespace TNDStudios.Domain.Objects.Base
{
    /// <summary>
    /// Common wrapper for contracts in the system so objects can be 
    /// wrapped in a contract object with common information
    /// </summary>
    /// <typeparam name="T">The type of object used in the contract</typeparam>
    public class Contract<T>
    {
        public T Data { get; set; } = default(T);
    }
}
