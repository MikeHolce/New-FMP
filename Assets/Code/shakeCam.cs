using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class shakeCam : MonoBehaviour
{
    public Transform Camera;
    public float duration;
    public float intensity;

    static public bool gotHit;
    public bool shook;
    public bool shaking;

    void Start()
    {

    }

    void Update()
    {

        if (gotHit == true && shook == true)
        {
            Debug.Log("both is true");
            shaking = true;
        }

        if (gotHit == true)
        {
            Debug.Log("gothit");
            shook = true;
            duration = 1;
            intensity = 0.3f;
        }
        if (gotHit == false)
        {
            Debug.Log("false");
            shook = false;
            shaking = false;
        }

        if (shaking == true)
        {
            Debug.Log("shaking");
            Camera.DOComplete();
            Camera.DOShakePosition(duration, intensity);
            gotHit = false;
        }

    }

    /**
    public void Shake()
    {
        Camera.DOComplete();
        Camera.DOShakePosition(duration, intensity);
    }
    **/
}
