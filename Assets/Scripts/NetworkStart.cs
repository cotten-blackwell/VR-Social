using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.VR;

public class NetworkStart : MonoBehaviour {
    public GameObject oculusMain;
    public GameObject cardboardMain;
    public string hostIP = "10.0.1.14";

    void Awake()
    {
        VRSettings.enabled = false;

        #if (UNITY_ANDROID || UNITY_IPHONE)
            oculusMain.SetActive(false);
            cardboardMain.SetActive(true);

            NetworkManager net = GetComponent<NetworkManager>();
            net.networkAddress = hostIP;
            net.StartClient();
            Debug.Log("NetworkStart line 21 reached!");
        #else
            oculusMain.SetActive(true);
                cardboardMain.SetActive(false);
            #endif
    }
}