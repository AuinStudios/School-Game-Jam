using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform followplayer;
    // Start is called before the first frame update
    void Start()
    {
        followplayer = GameObject.Find("balloni").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(followplayer.position.x, transform.position.y, transform.position.z);
    }
}
