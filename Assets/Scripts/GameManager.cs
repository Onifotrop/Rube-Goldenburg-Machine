using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Cam1;
    public GameObject Ball;

    public GameObject Cam2;
    public GameObject Hands;

    public GameObject Cam3;
    public GameObject carCar;

    public GameObject Cam4;
    public Vector3 pose1;
    
    public Camera Cam5;
    public Vector3 pose2;

    public Camera Cam6;
    public GameObject Toasteyy;
    public GameObject spaceBar;
    public GameObject Enjoy;
    public float timerT;
    public float camSpeed;
    public bool started = false;

    public AudioSource BGM;
    
    public float delayF;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //setting the cams
        Cam1.transform.position = Ball.transform.position;
        Cam2.transform.position = Hands.transform.position;
        Cam3.transform.position = carCar.transform.position;
        Cam6.transform.position = Toasteyy.transform.position;
        //spacebar pressing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceBar.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            started = true;
            BGM.PlayDelayed(delayF);
        }

        if (Cam5.enabled == true)
        {
            Cam5.transform.Translate(-camSpeed,0,0);
            
        }

        if (started)
        {
            timerT += Time.deltaTime; 
            Debug.Log(timerT);
            
        }
        

    }
    

}
