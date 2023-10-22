using System;
using System.ComponentModel;

namespace Ritek.App.Infrastructure
{
    /// <summary>
    /// 顯影
    /// </summary>
    [Serializable()]
    public class DevelopmentViewModel
    {
        [DisplayName("顯影1壓力")]
        public decimal DevelopPressure1 { get; set; }

        [DisplayName("二流體壓力")]
        public decimal FluidPressure2 { get; set; }

        [DisplayName("顯影1速度")]
        public decimal DevelopmentSpeed1 { get; set; }

        [DisplayName("二流體速度")]
        public decimal FluidVelocity2 { get; set; }

    }
}