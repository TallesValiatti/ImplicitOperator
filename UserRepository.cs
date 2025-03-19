namespace ImplicitOperators;

public class UserRepository
{
    public async Task<List<User>> ListUsersAsync()
    {
        return await Task.FromResult(new List<User>
        {
            new() { Id = Guid.NewGuid(), Name = "John Doe", CreditCardNumber = "1234567812345678" },
            new() { Id = Guid.NewGuid(), Name = "Jane Smith", CreditCardNumber = "8765432187654321" },
            new() { Id = Guid.NewGuid(), Name = "Alice Johnson", CreditCardNumber = "1111222233334444" },
            new() { Id = Guid.NewGuid(), Name = "Bob Brown", CreditCardNumber = "4444333322221111" },
            new() { Id = Guid.NewGuid(), Name = "Charlie Davis", CreditCardNumber = "5555666677778888" }
        });
    }
}