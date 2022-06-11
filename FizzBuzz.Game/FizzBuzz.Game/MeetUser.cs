using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Game
{
    public class MeetUser
    {
        private readonly ITimeManager timeManager;

        public MeetUser(ITimeManager timeManager)
        {
            this.timeManager = timeManager;
        }
        public string GetGreeting()
        {
            if (timeManager.Now.Hour <12)
            {
                return "Günaydın";
            }
            return "İyi günler";
        }
    }
}
