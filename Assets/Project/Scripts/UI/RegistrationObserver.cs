using System.Collections.Generic;
using Mirror;

public class RegistrationObserver : NetworkBehaviour
{
    private List<NetworkConnectionToClient> _connections = new List<NetworkConnectionToClient>();

    [Server]
    public void AddConnection(NetworkConnectionToClient sender)
    {
        _connections.Add(sender);
    }

    [Server]
    public void SendMessage()
    {
        HelloMessage helloMessage = new HelloMessage()
        {
            message = "Hello Client!"
        };
        foreach (var connection in _connections)
        {
            connection.Send(helloMessage);
        }
    }
}