using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        /* Call the code to "begin" your game here.
		 * For example, mine allows the player to start
		 * moving and starts the in game timer.
         */
        // GameController.instance.BeginGame();

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
    }
}
