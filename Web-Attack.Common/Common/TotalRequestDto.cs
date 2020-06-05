using System;

namespace Web_Attack.Common.Common
{
    public class TotalRequestDto
    {
        public string Method { get; set; }
        public int Count { get; set; }
    }
    public class WeeklyRequest
    {
        public DateTime WeekDay { get; set; }
        public int Count { get; set; }
    }
}