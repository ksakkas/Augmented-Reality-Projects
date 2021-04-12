using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System.IO;
using UnityEngine.Video;

public class clicks : MonoBehaviour
{
    public GameObject pause, play,Rumba;

    // Start is called before the first frame update
    void Start()
    {

        pause = GameObject.Find("Pause");
        play = GameObject.Find("Play");
        Rumba = GameObject.Find("Rumba");


        pause.SetActive(true);
        play.SetActive(false);
        Rumba.SetActive(true);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "Pause")
                {
                    pause.SetActive(false);
                    play.SetActive(true);
                    Rumba.gameObject.GetComponent<Animator>().enabled = false;

                }

                if (hit.collider.tag == "Play")
                {
                    pause.SetActive(true);
                    play.SetActive(false);
                    Rumba.gameObject.GetComponent<Animator>().enabled = true;




                }

         
            }    
        }
    }
}
