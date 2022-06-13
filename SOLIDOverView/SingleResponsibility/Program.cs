using SingleResponsibility;

public class Program
{
    //Her nesnenin bir sorumluluğu vardır.  
    //Program class'ının sorumluluğu:
    //Kullanıcıdan gelen verileri almak -> çıktıyı göstermek 
    //Eğer bir sınıfta bir değişiklik yapmak için birden fazla sebebiniz varsa; bu prensibe UYMUYORSUNUZ demektir.
    public static void Main(string[] args)
    {

        /*
         * Burada, db'ye eklenecek ADO.NET gibi kodlar yazılıyor........
         */

        string name = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());


        ProductBusiness productBusiness = new ProductBusiness();
        productBusiness.Add(name,price);
        
    }
}


