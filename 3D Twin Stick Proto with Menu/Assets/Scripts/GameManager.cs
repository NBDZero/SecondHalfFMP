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

    private SlowMoManager slowMoManager;

    public SlowMoManager getTimeManager()
    {
        return slowMoManager;
    }

    private float defaultSlowTimeScale;
    public bool isSlowMo;


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
        slowMoManager = new SlowMoManager();

        defaultSlowTimeScale = 0.1f;
        isSlowMo = false;
    }

    // Update is called once per frame
    void Update()
    {
        AlterTime();
    }

    void AlterTime()
    {
        if (isSlowMo)
        {
            SlowTime();
        }
        if (!isSlowMo)
        {
            ResetTime();
        }
    }
    void SlowTime()
    {
        Time.timeScale = defaultSlowTimeScale;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        Debug.Log("SlowTime");
    }

    void SlowTime( float timeScale )
    {
        Time.timeScale = timeScale;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }

    void ResetTime()
    {
        Time.timeScale = 1f;
    }
}
