using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{

    [SerializeField] GameObject PauseMenu;

    public void Pause()
    {
        PauseMenu.SetActive(true);
    }


    public void Resume()
    {
        PauseMenu.SetActive(false);
    }


}
