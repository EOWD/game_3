using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 position=new Vector3(24,0,0);
    private moveCharacter player;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.Find("player").GetComponent<moveCharacter>(); 

       InvokeRepeating("addObstacle",2,2);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void addObstacle(){
      
       if(player.gameOver==false){
 Instantiate(obstaclePrefab, position,obstaclePrefab.transform.rotation);
    }
    }
}
