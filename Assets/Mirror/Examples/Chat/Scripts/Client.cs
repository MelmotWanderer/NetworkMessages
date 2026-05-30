using Mirror;

public class Client : NetworkBehaviour
    {
        [SyncVar]
        public string playerName;

        public override void OnStartServer()
        {
            playerName = (string)connectionToClient.authenticationData;
        }

        public void Register()
        {
            
        }
    }

