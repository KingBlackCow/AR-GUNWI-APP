
using System.Collections.Generic;
using UnityEngine;

public class ViewerManager : MonoBehaviour
{
    private static ViewerManager instance = null;
    public static ViewerManager Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof(ViewerManager)) as ViewerManager;
            return instance;
        }
    }
     
    public List<GameObject> views;
    public GameObject startUI;
    public List<GameObject> VideoObject;
    public AudioClip click;
    public AudioSource myAudio;
    public int real_index = 0;
    public int video_index = 0;

    private void Start()
    {
        ResetViews();
    }

    void ResetViews()
    {
        foreach (GameObject go in views)
            go.SetActive(false);

        startUI.SetActive(true);
        //views[0].SetActive(true);
    }

    public void StartView()
    {
        views[0].SetActive(false);
        VideoObject[0].SetActive(true);
        real_index = 1;
        video_index = 0;
        Invoke("VideoReturn", 8f);
    }

    public void LoadNextView(int index)
    {
        for (int i = 0; i < views.Count; i++)
            views[i].SetActive(i == index);
    }

    public void clickSound()
    {
        myAudio.clip = click;
        myAudio.Play();
    }

    public void LoadVideo(int index)
    {
        views[index-1].SetActive(false);    
        real_index = index;
        if (index == 12)
        {
            VideoObject[3].SetActive(true);
            video_index = 3;
            Invoke("VideoReturn", 40f);
        }
        else if (index == 3)
        {
            VideoObject[2].SetActive(true);
            video_index = 2;
            Invoke("VideoReturn", 17f);
        }
        else if (index == 2)
        {
            VideoObject[1].SetActive(true);
            video_index = 1;
            Invoke("VideoReturn", 11f);
        }

        //Invoke("VideoReturn", 15f);
        //VideoObject.GetComponent<VideoControll>().PlayVideo(index);
    }

    public void VideoReturn()
    {
        VideoObject[video_index].SetActive(false);
        views[real_index].SetActive(true);
    }
}
