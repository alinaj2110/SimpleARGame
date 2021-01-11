using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public GameObject vbtn;
    public GameObject[] Orbs;
    private Vector3 pos; 
    public float OrbHeight;
   
    // Start is called before the first frame update
    void Start()
    {
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnPressedOrb);
    }

    public void OnPressedOrb(VirtualButtonBehaviour vb)
    {
        //Debug.Log(vbtn.transform.position);
        int index = Random.Range(0, Orbs.Length);
        pos = vbtn.transform.position + new Vector3(0,OrbHeight,0);
        Instantiate(Orbs[index],pos ,vbtn.transform.rotation);
    }


}
