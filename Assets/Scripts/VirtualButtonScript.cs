using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public GameObject vbtn;
    public GameObject GiantOrb;
    //public GameObject SmallOrb;
    //public float zone_range;
    private Vector3 pos;  //, pos2;
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
        //pos2 = new Vector3(Random.Range(-zone_range, zone_range), GiantOrbHeight, Random.Range(-zone_range, zone_range));
        Instantiate(GiantOrb,pos ,vbtn.transform.rotation);
        //Instantiate(SmallOrb, pos2, vbtn.transform.rotation);
    }


}
