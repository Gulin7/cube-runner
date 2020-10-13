using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 thirdplayer;
    void Update()
    {
        transform.position = player.position + thirdplayer;
    }

}
