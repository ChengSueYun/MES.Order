using System;
using System.ComponentModel;

namespace Ritek.App.Infrastructure
{
    /// <summary>
    /// 厚度
    /// </summary>
    [Serializable()]
    public class ThicknessViewModel
    {
        [DisplayName("光阻厚度")]
        public string PhotoresistThickness { get; set; }

        [DisplayName("訂單厚度")]
        public string SeriesNoThickness  { get; set; }
    }
}