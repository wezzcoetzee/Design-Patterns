namespace ChainOfResponsibility;

public abstract class Approver
{
    protected Approver successor;

    public void SetSuccessor(Approver successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(Purchase purchase);
}

public class Purchase
{
    public int PurchaseNumber { get; set; }
    public double Amount { get; set; }
    public string Purpose { get; set; } = "";
}