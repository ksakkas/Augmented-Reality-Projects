using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Διαχείριση Μενού 

public class menu : MonoBehaviour
{
    public void scene_students()
    {
        SceneManager.LoadScene("STUDENTS");
    }

    public void scene_professors()
    {
        SceneManager.LoadScene("PROFESSORS");
    }

    public void scene_secr()
    {
        SceneManager.LoadScene("SECRETARIAT");
    }

    public void exit()
    {
        Application.Quit();
        Debug.Log("Exit ok!!!");
    }

    public void prev()
    {
        SceneManager.LoadScene("START");
    }

    public void t1()
    {
        Application.OpenURL("http://myweb.dit.uoi.gr/ksakkas/dit.uoi.gr.k/ar_students.php");
    }

    public void t2()
    {
        Application.OpenURL("http://myweb.dit.uoi.gr/ksakkas/dit.uoi.gr.k/ar_professors.php");
    }

    public void t3()
    {
        Application.OpenURL("http://myweb.dit.uoi.gr/ksakkas/dit.uoi.gr.k/ar_secretariat.php");
    }
}
