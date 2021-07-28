using System;
using System.Collections.Generic;

namespace LEDServer
{
    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int r { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int g { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int b { get; set; }
    }

    public class LEDData
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> Data { get; set; }
    }
}
