using UnityEngine;
using UnityEngine.SceneManagement;


public class StageLoad : MonoBehaviour
{

    public GameObject ButtonPanel;
    bool check = true;


    public void OnInputClick()
    {
        check = false;
        Debug.Log("button click!");
    }

    void Update()
    {
        if(check == false)
        {       
            ButtonPanel.SetActive(false);
        }
    }
}