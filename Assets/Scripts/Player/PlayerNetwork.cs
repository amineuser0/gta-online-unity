using UnityEngine;
using Mirror;

public class PlayerNetwork : NetworkBehaviour
{

    public GameObject[] localPlayerObjects;

    public Behaviour[] localPlayerComponents;

    void Start()
    {
        if(!isOwned){
            foreach (GameObject obj in localPlayerObjects)
            {
                obj.SetActive(false);
            }
            foreach (Behaviour comp in localPlayerComponents)
            {
                comp.enabled = false;
            }
        }
    }
}