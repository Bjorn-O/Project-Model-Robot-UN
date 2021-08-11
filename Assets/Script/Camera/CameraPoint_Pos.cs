using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPoint_Pos : MonoBehaviour
{
    public GameObject cameraPoint;
    public GameObject player1;
    public GameObject player2; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPoint.transform.position = player1.transform.position + player2.transform.position / 2;
    }
}
