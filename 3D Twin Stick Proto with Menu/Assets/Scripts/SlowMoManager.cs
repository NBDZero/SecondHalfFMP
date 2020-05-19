using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMoManager
{
    private float defaultSlowTimeScale;

    // Start is called before the first frame update
    void Start()
    {
        defaultSlowTimeScale = .05f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SlowTime()
    {
        Time.timeScale = defaultSlowTimeScale;
    }

    public void SlowTime(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}
