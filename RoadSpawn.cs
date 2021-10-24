using System.Collections;
using System.Collections.Generic;
using System.Linq; 
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{

    public List<GameObject> roads;
    private float offset = 275f; 
    // Start is called before the first frame update
    void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(roads => roads.transform.position.z).ToList(); 
        }
    }

    public void MoveRoad()
    {
        GameObject moveroad = roads[0];
        roads.Remove(moveroad);
        float newPos = roads[roads.Count - 1].transform.position.z + offset;
        moveroad.transform.position = new Vector3(0, 0, newPos);
        roads.Add(moveroad); 
    }
}
