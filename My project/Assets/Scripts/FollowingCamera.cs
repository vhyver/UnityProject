using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class FollowingCamera : MonoBehaviour
{
    public Transform player;
    public float smoothing;
    public Vector3 offset;

    void FixedUpdate()
    {
        if(player != null)
        {
            Vector3 newPos = Vector3.Lerp(transform.position, player.position + offset, smoothing);
            transform.position = newPos;
        }   
    }
}
