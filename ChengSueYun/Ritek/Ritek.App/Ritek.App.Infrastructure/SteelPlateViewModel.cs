using System;
using System.ComponentModel;

namespace Ritek.App.Infrastructure
{
    /// <summary>
    /// 鋼板
    /// </summary>
    [Serializable()]
    public class SteelPlateViewModel
    {
        [DisplayName("鋼板")]
        public string SteelPlate { get; set; }

        [DisplayName("鋼板尺寸")]
        public string SteelPlateSize { get; set; }
    }
}