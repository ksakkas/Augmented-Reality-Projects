using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttons : MonoBehaviour
{
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8;
    VirtualButtonBehaviour[] vrb;

    void Start()
    {
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
        obj4.SetActive(false);
        obj5.SetActive(false);
        obj6.SetActive(false);
        obj7.SetActive(false);
        obj8.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);
        }
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "vb1")
        {
            obj1.SetActive(true);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(false);
            obj6.SetActive(false);
            obj7.SetActive(false);
            obj8.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb2")
        {
            obj1.SetActive(false);
            obj2.SetActive(true);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(false);
            obj6.SetActive(false);
            obj7.SetActive(false);
            obj8.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb3")
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(true);
            obj4.SetActive(false);
            obj5.SetActive(false);
            obj6.SetActive(false);
            obj7.SetActive(false);
            obj8.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb4")
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(true);
            obj5.SetActive(false);
            obj6.SetActive(false);
            obj7.SetActive(false);
            obj8.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb5")
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(true);
            obj6.SetActive(false);
            obj7.SetActive(false);
            obj8.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb6")
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(false);
            obj6.SetActive(true);
            obj7.SetActive(false);
            obj8.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb7")
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(false);
            obj6.SetActive(false);
            obj7.SetActive(true);
            obj8.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb8")
        {
            obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            obj5.SetActive(false);
            obj6.SetActive(false);
            obj7.SetActive(false);
            obj8.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not Supported");
        }
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    } 

}
