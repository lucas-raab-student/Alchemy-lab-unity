
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance ) {
            Destroy(this);
          
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    static public  void LoadScene(string newsceneName)
    {
        SceneManager.LoadScene(newsceneName);
    }
    static public void Quit()
    {
        Application.Quit();
    }

    
    }

