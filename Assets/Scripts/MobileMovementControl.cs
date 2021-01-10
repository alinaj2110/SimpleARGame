using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovementControl : MonoBehaviour
{
    
    private Vector2 screenCentre = new Vector2(Screen.width / 2.0f, Screen.height / 2.0f);
    public GameObject Player;
    public float speed;
    Vector2 direction;
    Vector3 Direction3D;

    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touchinput = Input.GetTouch(0);
            direction = touchinput.position - screenCentre;
            //direction = direction.Normalize;
            Direction3D = new Vector3(direction.x, 0, direction.y);
            Direction3D = Direction3D.normalized;
            Player.transform.rotation = Quaternion.LookRotation(Direction3D);
            Player.transform.position = Vector3.MoveTowards(Player.transform.position,Direction3D,speed * Time.deltaTime);               //Translate(Direction3D * Time.deltaTime * speed);


            anim.Play("WALK00_F");
        }
    }
}
