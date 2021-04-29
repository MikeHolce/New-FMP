using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraShake : MonoBehaviour
{
    public Transform Camera;
    public float duration;
    public float intensity;

    static public bool shakeDatThang;

    void Update()
    {
        if (shakeDatThang == true)
        {
            Shake();
        }
    }

    public void Shake()
    {
        Camera.DOComplete();
        Camera.DOShakePosition(duration, intensity);
    }
}
