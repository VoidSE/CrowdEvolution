using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowePlayer : MonoBehaviour
{
    /*
    Camera follow：https://blog.csdn.net/qq_41860752/article/details/116067551
    */
    public Transform player;
    public Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
        transform.position = player.position + offset;
        // Keep heading
        Vector3 pos = transform.position;
        pos.x = 0;
        transform.position = pos;

    }
}
