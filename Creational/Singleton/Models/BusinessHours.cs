using System;

namespace Singleton.Models
{
    public class BusinessHours
    {
        private BusinessHours(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        private static BusinessHours _instance;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public static BusinessHours GetInstance()
        {
            if(_instance is null)
            {
                _instance = new BusinessHours(
                    new DateTime(1, 1, 1, new Random().Next(0, 10), 0, 0),
                    new DateTime(1, 1, 1, new Random().Next(18, 24), 0, 0)
                );

                Console.WriteLine("Nova instância gerada");
            }

            return _instance;
        }
    }
}
