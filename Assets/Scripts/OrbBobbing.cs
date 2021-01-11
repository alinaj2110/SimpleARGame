using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBobbing : MonoBehaviour
{
    public float timekeep;
    float timer=0f;
    public float speed;
    int up;
    // Start is called before the first frame update
    void Start()
    {
        up = Random.Range(-1, 1);
        if (up == 0)
            up = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timekeep)
        {
            
            timer = 0f;
            up = -up;
        }
        transform.Translate(new Vector3(0,up,0)* Time.deltaTime * speed);
    }
}
