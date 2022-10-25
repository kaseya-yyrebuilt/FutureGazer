using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2Timer : MonoBehaviour
{
    public GameObject myobject;
    public bool activateme;
    // Start is called before the first frame update
    void Start()
    {
        myobject.SetActive(false);
        Invoke("SetToActive", 5);
    }

    // Update is called once per frame
    public void SetToActive()
    {
        myobject.SetActive(true);
    }
    

    //void update()
    //{
    //    if (activateme == true)
    //    {
    //        myobject.setactive(true);
    //    }
    //    else
    //    {
    //        myobject.setactive(false);
    //    }
    //}
}
