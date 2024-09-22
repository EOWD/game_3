using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatBackGround : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatW;
    // Start is called before the first frame update
    void Start()
    {
        startPosition=transform.position;
        repeatW= GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPosition.x - repeatW){
            transform.position=startPosition;
        }
    }
}
