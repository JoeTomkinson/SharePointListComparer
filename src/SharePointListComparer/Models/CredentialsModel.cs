using System.Runtime.Serialization;

namespace SharePointListComparer.Models
{
    [DataContract]
    public class SharePointInformation
    {
        [DataMember]
        public bool IsSharePointOnline { get; set; }
        [DataMember]
        public string EncryptedPassword { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string SiteUrl { get; set; }
    }
}