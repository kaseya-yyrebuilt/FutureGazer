using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScV4Timer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    
        Invoke("TimeToDo", 135);
    }

    // Update is called once per frame
    public void TimeToDo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
