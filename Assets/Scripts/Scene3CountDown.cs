using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene3CountDown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public GameObject videoPlayer;
    public GameObject Q1;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    

    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownDisplay.text = "Done!";
        videoPlayer.SetActive(false);
        Q1.SetActive(true);
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
    }
}
