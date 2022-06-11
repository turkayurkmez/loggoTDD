using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Game
{
    public interface ITimeManager
    {
        DateTime Now { get; }


    }

    public class TestTimeManager : ITimeManager
    {
        public Func<DateTime> CurrentTime = () => DateTime.Now;

        public DateTime Now => CurrentTime();

        public void SetCurrentTime(DateTime currentTime)
        {
            CurrentTime = () => currentTime;
        }

    }
}
