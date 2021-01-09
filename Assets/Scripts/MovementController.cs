using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class MovementController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] vbtn;
    public GameObject Playermodel;
    public float speed;
    
    void Start()
    {
       
        vbtn[0].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onpressedforward);
        vbtn[1].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onpressedbackward);
        vbtn[2].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onpressedleft);
        vbtn[3].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onpressedright);
    }

    public void onpressedforward(VirtualButtonBehaviour vb)
    {
        if(vb.Pressed)
            Debug.Log("pressed");
        Playermodel.transform.Translate( Vector3.forward * Time.deltaTime * speed); 
    }
    public void onpressedbackward(VirtualButtonBehaviour vb)
    {
        if (vb.Pressed)
            Debug.Log("pressed");
        Playermodel.transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
    public void onpressedleft(VirtualButtonBehaviour vb)
    {
        if (vb.Pressed)
            Debug.Log("pressed");
        Playermodel.transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    public void onpressedright(VirtualButtonBehaviour vb)
    {
        if (vb.Pressed)
            Debug.Log("pressed");
        Playermodel.transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

}
