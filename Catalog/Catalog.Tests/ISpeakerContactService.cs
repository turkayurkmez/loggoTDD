using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Tests
{
    public interface ISpeakerContactService
    {
        void MessageToSpeaker(string message);
    }
    /*
     * Parametre ne olursa olsun, ihtiyaç duyulan nesneyi döndüren metotlar barındırır.
     */
    public class StubSpeakerContactService : ISpeakerContactService
    {
        //message parametresi ne olursa olsun, hata testi yapıyoruz.
        public void MessageToSpeaker(string message)
        {
            throw new UnableToContactSpeakerException();
        }
    }


    public class SpySpeakerContactService : ISpeakerContactService
    {
        public bool MessageToSpeakerMethodHasBeenCalled { get; set; }
        public int MessageToSpeakerCallCount { get; set; }
        public void MessageToSpeaker(string message)
        {
            MessageToSpeakerMethodHasBeenCalled = true;
            MessageToSpeakerCallCount++;
            
        }
    }

    public class UnableToContactSpeakerException : Exception
    {


    }

    
}
  
