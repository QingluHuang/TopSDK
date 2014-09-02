using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DeleteRouteEntryResponse.
    /// </summary>
    public class DeleteRouteEntryResponse : AliyunResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
