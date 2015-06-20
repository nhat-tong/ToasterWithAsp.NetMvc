using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ToasterWithAsp.NetMvc.POCO
{
    /// <summary>
    /// Notification type
    /// </summary>
    [DataContract]
    public enum MessageType
    {
        /// <summary>
        /// Success message
        /// </summary>
        [EnumMember]
        Success,

        /// <summary>
        /// Information message
        /// </summary>
        [EnumMember]
        Info,

        /// <summary>
        /// Warning message
        /// </summary>
        [EnumMember]
        Warning,

        /// <summary>
        /// Error message
        /// </summary>
        [EnumMember]
        Error
    }
}
