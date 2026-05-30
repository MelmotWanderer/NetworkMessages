using Mirror;

public interface IClientService
{
    public void RegisterClient(NetworkConnectionToClient sender);

    public void NotifyServer();
}
