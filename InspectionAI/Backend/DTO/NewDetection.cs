using System;
using System.Collections.Generic;
using System.Text;

namespace Exhibition.DTO
{
    public class NewDetection
    {
        public int Id { get; set; }
        public String FileName { get; set; }
        public float Confidence { get; set; }
        public int Type { get; set; }
        public DateTime Datetime { get; set; }
    }
}
