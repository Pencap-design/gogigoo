using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramanager: MonoBehaviour
{
    public GameObject player;
    public Vector3 pivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5.59f,player.transform.position.y+pivot.y,player.transform.position.z+pivot.z);
    }
}
