namespace CodeSmells;
internal class BooleanBlindess
{
    public void ProcessOrderWithBooleanBlindness(int orderId, bool applyDiscount)
    {
        if (applyDiscount)
        {
            // Apply discount to the order
        }

        // Process the order here  
    }

    public enum DiscountOption
    {
        None,
        ApplyDiscount
    }

    public void ProcessOrderWithoutBooleanBlindness(int orderId, DiscountOption discountOption)
    {
        if (discountOption == DiscountOption.ApplyDiscount)
        {
            // Apply discount to the order
        }

        // Process the order here  
    }


}
