// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer = new Customer() { Cart = new Premium()};
OrderManagement management = new OrderManagement { Customer = customer };
var result = management.GetTotalOrderAmount(1000);
Console.WriteLine(result);


/*
 * Open: Nesneniz  GELİŞİME AÇIK olmalı
 * Closed: Nesneniz DEĞİŞİME KAPALI olmalı
 */
public abstract class CartTypes
{
    public abstract decimal GetDiscountedPrice(decimal price);  
}

public class StandartCart : CartTypes
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * 0.95m;
    }
}

public class SilverCart : CartTypes
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * 0.90m;
    }
}

public class GoldCart : CartTypes
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * 0.85m;
    }
}

public class Premium : CartTypes
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * 0.80m;
    }
}



public class Customer
{
    public string Name { get; set; }
    public CartTypes Cart { get; set; }
}
public class OrderManagement
{
    public Customer Customer { get; set; }

    public decimal GetTotalOrderAmount(decimal total)
    {
        decimal result;
        //switch (Customer.Cart)
        //{
        //    case CartTypes.Standart:
        //        result = total * 0.95m;
        //        break;
        //    case CartTypes.Silver:
        //        result = total * 0.90m;
        //        break;
        //    case CartTypes.Gold:
        //        result = total * 0.85m;
        //        break;
        //    default:
        //        result = total;
        //        break;
        //}

        result = Customer.Cart.GetDiscountedPrice(total);

        return result;
    }
}