using Mirror;
using UnityEngine;

public class ClientRegisterInformation : NetworkBehaviour
{
    private NetworkConnectionToClient _connectionToClient;
    
    public override void OnStartClient() => NetworkClient.RegisterHandler<HelloMessage>(OnSendMessage);
    
    private void OnSendMessage(HelloMessage msg) => Debug.Log($"<color=green> {msg.message} </color>");
}
