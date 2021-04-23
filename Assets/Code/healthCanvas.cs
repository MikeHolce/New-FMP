using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthCanvas : MonoBehaviour
{

    public Image Hone;
    public Image Htwo;
    public Image Hthree;
    public Image Hfour;
    public Image Hfive;
    public Image Died;

    public Sprite heart;
    public Sprite nothing;
    public Sprite died;

    // Start is called before the first frame update
    void Start()
    {
        Died.sprite = nothing;
    }

    // Update is called once per frame
    void Update()
    {

        if(Character.playerHealth == 5)
        {
            Hone.sprite = heart;
            Htwo.sprite = heart;
            Hthree.sprite = heart;
            Hfour.sprite = heart;
            Hfive.sprite = heart;
        }

        if (Character.playerHealth == 4)
        {
            Hone.sprite = heart;
            Htwo.sprite = heart;
            Hthree.sprite = heart;
            Hfour.sprite = heart;
            Hfive.sprite = nothing;
        }

        if (Character.playerHealth == 3)
        {
            Hone.sprite = heart;
            Htwo.sprite = heart;
            Hthree.sprite = heart;
            Hfour.sprite = nothing;
            Hfive.sprite = nothing;
        }

        if (Character.playerHealth == 2)
        {
            Hone.sprite = heart;
            Htwo.sprite = heart;
            Hthree.sprite = nothing;
            Hfour.sprite = nothing;
            Hfive.sprite = nothing;
        }

        if (Character.playerHealth == 1)
        {
            Hone.sprite = heart;
            Htwo.sprite = nothing;
            Hthree.sprite = nothing;
            Hfour.sprite = nothing;
            Hfive.sprite = nothing;
        }

        if (Character.playerHealth <= 0)
        {
            Hone.sprite = nothing;
            Htwo.sprite = nothing;
            Hthree.sprite = nothing;
            Hfour.sprite = nothing;
            Hfive.sprite = nothing;
            Died.sprite = died;
        }
    }
}
