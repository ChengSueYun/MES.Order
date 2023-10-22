using System;
using System.ComponentModel;

namespace Ritek.App.Infrastructure
{
    /// <summary>
    /// 曝光
    /// </summary>
    [Serializable()]
    public class LDIViewModel
    {
        [DisplayName("類別")]
        public string Category { get; set; }

        [DisplayName("限制歸類")]
        public string LimitCollation { get; set; }

        [DisplayName("散焦")]
        public int Defocus { get; set; }

        [DisplayName("曝光量")]
        public int Exposure { get; set; }
    }
}