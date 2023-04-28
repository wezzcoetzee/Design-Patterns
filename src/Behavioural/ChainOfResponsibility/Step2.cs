namespace ChainOfResponsibility;

public class Manager : Approver
{
    public override void HandleRequest(Purchase purchase)
    {
        if (purchase.Amount < 1000.0)
        {
            Console.WriteLine(
                $"{this.GetType().Name} approved purchase #{purchase.PurchaseNumber}, Amount: {purchase.Amount}, Purpose: {purchase.Purpose}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(purchase);
        }
    }
}

public class Director : Approver
{
    public override void HandleRequest(Purchase purchase)
    {
        if (purchase.Amount < 5000.0)
        {
            Console.WriteLine(
                $"{this.GetType().Name} approved purchase #{purchase.PurchaseNumber}, Amount: {purchase.Amount}, Purpose: {purchase.Purpose}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(purchase);
        }
    }
}

public class CEO : Approver
{
    public override void HandleRequest(Purchase purchase)
    {
        if (purchase.Amount < 10000.0)
        {
            Console.WriteLine(
                $"{this.GetType().Name} approved purchase #{purchase.PurchaseNumber}, Amount: {purchase.Amount}, Purpose: {purchase.Purpose}");
        }
        else
        {
            Console.WriteLine($"Purchase #{purchase.PurchaseNumber} requires an executive meeting.");
        }
    }
}