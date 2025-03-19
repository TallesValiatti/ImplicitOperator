namespace ImplicitOperators;

public class UserApplicationService(UserRepository repository)
{
    public async Task<List<UserResponse>> ListUsersAsync()
    {
        var users = await repository.ListUsersAsync();
        
        return users
            .Select(user => (UserResponse)user)
            .ToList();
    }
}