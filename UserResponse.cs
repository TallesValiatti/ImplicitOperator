namespace ImplicitOperators;

public class UserResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string CreditCardNumber { get; set; } = null!;
    
    public static implicit operator UserResponse(User user) => new()
    {
        Id = user.Id,
        Name = user.Name,
        CreditCardNumber = MaskCreditCard(user.CreditCardNumber)
    };
    
    private static string MaskCreditCard(string creditCardNumber)
    {
        if (string.IsNullOrEmpty(creditCardNumber) || creditCardNumber.Length < 4)
            return new string('*', creditCardNumber.Length);

        return new string('*', creditCardNumber.Length - 4) + creditCardNumber[^4..];
    }
}