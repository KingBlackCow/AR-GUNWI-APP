using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControll : MonoBehaviour
{
    public List<UnityEngine.Video.VideoClip> clips;
    public UnityEngine.Video.VideoPlayer videoPlayer;
    public int real = 0;
    void Start()
    {
        videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
    }

    public void PlayVideo(int index)
    {
        real = index;
        Invoke("GO", 10);
        //StartCoroutine("WaitVideoTime");
        //ViewerManager.Instance.VideoReturn(index);
    }

    IEnumerator WaitVideoTime(int index)
    {

        videoPlayer.clip = clips[0];
        videoPlayer.Play();

        yield return new WaitForSeconds(10.0f);

        videoPlayer.Stop();
    }
}
