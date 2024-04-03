using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public static SceneSwitch Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

    }

    public void SceneChanger(string sceneName)
    {
        // change scene according to scene name
        SceneManager.LoadScene(sceneName);
    }
}

