using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public GameObject vbtn;
    public GameObject GiantOrb;
    private Vector3 pos; 
    public float GiantOrbHeight;
   
    // Start is called before the first frame update
    void Start()
    {
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnPressedOrb);
    }

    public void OnPressedOrb(VirtualButtonBehaviour vb)
    {
        Debug.Log(vbtn.transform.position);
        pos = vbtn.transform.position + new Vector3(0,GiantOrbHeight,0);
        Instantiate(GiantOrb,pos ,vbtn.transform.rotation);
    }


}
