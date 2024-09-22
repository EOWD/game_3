using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    private float speed = 15.0f;
    private moveCharacter player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").GetComponent<moveCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.gameOver == false){

        transform.Translate(Vector3.left * Time.deltaTime*speed);
        }
        if(transform.position.x < -5 && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
