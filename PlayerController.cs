using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPun
{
    void Start()
    {
        if (photonView.IsMine)
        {
            Debug.LogError("我自己");
        }
        else
        {
            Debug.LogError("別的玩家");
        }
    }
}
