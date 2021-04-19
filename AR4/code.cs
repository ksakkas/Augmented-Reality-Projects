using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System.IO;
using UnityEngine.Video;

public class code : MonoBehaviour
{
    public GameObject Button, Buttoncube, cube, pause, play, Rumba, video;
    public float prevSpeed;

    // Start is called before the first frame update
    void Start()
    {

        Button = GameObject.Find("Button");
        Buttoncube = GameObject.Find("Buttoncube");
        cube = GameObject.Find("Cube");
        //audio = GameObject.Find("Audio");
        pause = GameObject.Find("Pause");
        play = GameObject.Find("Play");
        Rumba = GameObject.Find("Rumba");
        video = GameObject.Find("Video");


        Buttoncube.SetActive(true);
        Button.SetActive(false);
        //audio.SetActive(false);
        pause.SetActive(true);
        play.SetActive(false);
        Rumba.SetActive(false);
        video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Buttontow")
                {
                    Button.SetActive(true);
                    Buttoncube.SetActive(false);
                    //audio.SetActive(true);
                    Rumba.SetActive(true);
                    video.SetActive(true);
                }

                if (hit.collider.tag == "Pause")
                {
                    //AudioSource audios = FindObjectOfType<AudioSource>();
                    //audios.Pause();
                    pause.SetActive(false);
                    play.SetActive(true);

                    VideoPlayer video = FindObjectOfType<VideoPlayer>();
                    video.Pause();

                    Animator an = FindObjectOfType<Animator>();

                    // an.SetBool("IsIdle", true);
                    prevSpeed = an.speed;
                    an.speed = 0;


                }

                if (hit.collider.tag == "Play")
                {
                    //AudioSource audios = FindObjectOfType<AudioSource>();
                    //audios.Play();
                    play.SetActive(false);
                    pause.SetActive(true);

                    VideoPlayer video = FindObjectOfType<VideoPlayer>();
                    video.Play();

                    Animator an = FindObjectOfType<Animator>();
                    // an.SetBool("IsIdle", true);
                    an.speed = prevSpeed;
                }

                if (hit.collider.tag == "Buttonone")
                {
                    Button.SetActive(false);
                    Buttoncube.SetActive(true);
                    //audio.SetActive(false);
                    Rumba.SetActive(false);

                    video.SetActive(false);

                }
            }
        }
    }
}
