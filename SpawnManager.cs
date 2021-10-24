using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawn spawnRoad; 
      
    // Start is called before the first frame update
    void Start()
    {
        spawnRoad = GetComponent<RoadSpawn>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTrigEnter()
    {
        spawnRoad.MoveRoad();  
    }
}
