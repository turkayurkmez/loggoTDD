

Report report = new Report(new MailSender());
report.SendReport();

Report report1 = new Report(new WSSender());
report1.SendReport();


Report report2 = new Report(new TestSender());
report2.SendReport();
public class Report
{
    private ISender sender;
    public Report(ISender sender)
    {
        this.sender = sender;
    }
   
    public void SendReport()
    {
        //MailSender mailSender = new MailSender();
        sender.Send();
    }
}

public interface ISender
{
    public void Send();
}

public class WSSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Whatsapp....");
    }
}
public class MailSender : ISender
{
    public void Send()
    {
        Console.WriteLine("mail gönderiliyor...");
    }
}

public class TestSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Test amaçlı yazılmıştır");
    }
}


