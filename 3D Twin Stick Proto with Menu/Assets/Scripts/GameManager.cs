using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Create an instance of the game manager:
    static GameManager instance;

    //Get function to return an a reference of the game manager:
    public static GameManager GetGameManager()
    {
        return instance;
    }

    SlowMoManager slowMoMangaer;


    // Awake is called befoee anything else:
    void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else if (instance == null)
        {
            instance = this;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        
    }

    //Start is called before the first frame of update:
    void Start()
    {
        slowMoMangaer = new SlowMoManager();
    }

    // Update is called once per frame
    void Update()
    {
        slowMoMangaer.SlowTime(0.05f);
    }
}
