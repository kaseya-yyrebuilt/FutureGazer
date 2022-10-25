using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Scene2Trigger : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public GameObject Q1;
    void Start()
    {
        VideoPlayer.loopPointReached += LoadScene;
    }
    void LoadScene(VideoPlayer vp)
    {
        Q1.SetActive(true);
    }


}
