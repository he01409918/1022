using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPun
{
    public Transform headPos;
    public Transform rightHandPos;
    public Transform lefHandPos;
    void Start()
    {
        if (photonView.IsMine)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 8;
            }
            Debug.LogError("我自己");
            gameObject.name = PhotonNetwork.LocalPlayer.NickName;
        }
        else
        {
            Debug.LogError("別的玩家");
            gameObject.name = photonView.Owner.NickName;
        }
    }

    private void Update()
    {

    }
}
