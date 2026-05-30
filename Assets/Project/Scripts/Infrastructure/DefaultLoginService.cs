using Mirror;

public class DefaultLoginService : ILoginService
{
    private readonly NetworkManager _networkManager;

    
    public DefaultLoginService(NetworkManager networkManager)
    {
        _networkManager = networkManager;
    }

    public void StartServer() => _networkManager.StartServer();

    public void StartHost() => _networkManager.StartHost();

    public void StartClient() => _networkManager.StartClient();
}
