using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Vuforia;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orb;
    public GameObject Imagetarget;
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
        
    }

    //spawn function
    public void OrbSpawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-zone_range, zone_range), 0, Random.Range(-zone_range, zone_range)); //- Imagetarget.transform.position;
        Instantiate(orb,spawnPos, transform.rotation);          
    }

}
