using PrometheusGrafanaDotNetCore.Domain;

namespace PrometheusGrafanaDotnetCore.Application.Services;

public class UserService
{
    private readonly List<User> _users = [];
    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public List<User> GetUsers()
    {
        return _users;
    }

    public User? GetUser(double userId)
    {
        return _users.FirstOrDefault(x => x.Id == userId);
    }
}
