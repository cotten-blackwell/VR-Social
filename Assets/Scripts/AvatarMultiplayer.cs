using UnityEngine;
using UnityEngine.Networking;

public class AvatarMultiplayer : NetworkBehaviour
{

    public override void OnStartLocalPlayer()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        transform.parent = camera.transform;
        transform.localPosition = Vector3.zero;
    }
}
