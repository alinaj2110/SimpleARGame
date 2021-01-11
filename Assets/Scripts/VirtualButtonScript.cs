using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public GameObject vbtn;
    public GameObject[] Orbs;
    public float Radius;
    private Vector3 pos; 
    public float OrbHeight;
   
    // Start is called before the first frame update
    void Start()
    {
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnPressedOrb);
    }

    public void OnPressedOrb(VirtualButtonBehaviour vb)
    {
        
        int index = Random.Range(0, Orbs.Length);
        pos = Random.insideUnitSphere * Radius;
        pos.y = OrbHeight;
        Debug.Log(pos);
        Instantiate(Orbs[index],pos ,vbtn.transform.rotation);
    }


}
