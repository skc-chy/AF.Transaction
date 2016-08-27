using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AF.Transaction.Common
{

    [DataContract]
    public class Result
    {
        [DataMember]
        public bool IsValid { get; set; }
        [DataMember]
        public IList<string> Message { get; set; }
    }
}
