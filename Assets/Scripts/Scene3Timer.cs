using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene3Timer : MonoBehaviour
{
    public GameObject myobject;
    public GameObject videoPlayer;
    public bool activateme;
    // Start is called before the first frame update
    void Start()
    {
        myobject.SetActive(false);
        videoPlayer.SetActive(false);
        Invoke("SetToActive", 5);
    }

    // Update is called once per frame
    public void PlayVideo()
    {
        videoPlayer.SetActive(true);
    }
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
