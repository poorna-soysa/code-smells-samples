using CodeSmells;

BooleanBlindess booleanBlindess = new();

booleanBlindess.ProcessOrderWithBooleanBlindness(100,applyDiscount:true);

booleanBlindess.ProcessOrderWithoutBooleanBlindness(100, BooleanBlindess.DiscountOption.ApplyDiscount);
