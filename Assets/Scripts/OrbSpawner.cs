using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Vuforia;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orb;
    public GameObject ARAnchor;
    public float zone_range;
    public float timedelay;
    public float repRate;
    
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("OrbSpawn", timedelay, repRate);
    }

    // Update is called once per frame
    void Update()
    {
        //if (core == null)
            //CancelInvoke(); //makes the aliens to stop spawning once the core is destroyed
        
    }

    //spawn function
    public void OrbSpawn()
    {
        //int index = Random.Range(0, alienPrefabs.Length);
        //Vector3 spawnPos = new Vector3(Random.Range(-zone_range, zone_range), Random.Range(-zone_range, zone_range), Random.Range(-zone_range, zone_range)); //randZonePoint(zone_radius_min);
        Instantiate(orb,ARAnchor.transform.position  +Random.insideUnitSphere*10 , transform.rotation);          //transform.position+spawnPos
    }

}
