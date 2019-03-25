using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TNDStudios.Domain.Objects.People
{
    /// <summary>
    /// Implementation of a worker inherited from a Person
    /// </summary>
    [JsonObject(Description = "Worker Object", MemberSerialization = MemberSerialization.OptOut)]
    public class Worker : Person
    {
        /// <summary>
        /// The job title of the worker
        /// </summary>
        [JsonProperty]
        public virtual String JobTitle { get; set; } = String.Empty;
    }
}
