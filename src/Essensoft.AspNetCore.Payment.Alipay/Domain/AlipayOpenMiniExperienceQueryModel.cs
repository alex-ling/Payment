using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniExperienceQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
