namespace MES.Order.Infrastructure
{
    public class EnumCollect
    {
        /// <summary>
        /// 訂單的狀態
        /// </summary>
        public enum OrderStatusEnum
        {
            /// <summary>
            /// 已取貨
            /// </summary>
            Y,
            /// <summary>
            /// 未取貨
            /// </summary>
            N
        }

        /// <summary>
        /// 顏色規格
        /// </summary>
        public enum ColorSpecEnum
        {
            黑,
            白,
            紅,
            綠,
            藍,
            黃
        }

        /// <summary>
        /// 尺寸規格
        /// </summary>
        public enum SizeSpecEnum
        {
            XS,
            S,
            M,
            L,
            XL
            
        }
    }
}