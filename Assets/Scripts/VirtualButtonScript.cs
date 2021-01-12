using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public GameObject vbtn;
    public GameObject[] Orbs;
    public float Radius;
    public int maxOrbs;
    private Vector3 pos; 
    public float OrbHeight;
   
    // Start is called before the first frame update
    void Start()
    {
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnPressedOrb);
    }

    public void OnPressedOrb(VirtualButtonBehaviour vb)
    {
        
        
        
        int len = Random.Range(0, maxOrbs +1);
        for (int i = 0; i < len; i++)
        {
            
            int index = Random.Range(0, Orbs.Length);
            Debug.Log("index:"+index);
            pos = Random.insideUnitSphere * Radius;
            pos.y = OrbHeight;
            Debug.Log(pos);
            Instantiate(Orbs[index], pos, vbtn.transform.rotation);
        }
    }


}
