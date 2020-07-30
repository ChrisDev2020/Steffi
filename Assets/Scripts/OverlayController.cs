using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayController : MonoBehaviour
{

    public GameObject[] PNGs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            HideOverlays();
        }

        if (Input.GetKeyDown("0"))
        {
            HideOverlays();
        }

        if (Input.GetKeyDown("1"))
        {
            HideOverlays();
            ShowOverlayWithID(1);
        }

        if (Input.GetKeyDown("2"))
        {
            HideOverlays();
            ShowOverlayWithID(2);
        }

        if (Input.GetKeyDown("3"))
        {
            HideOverlays();
            ShowOverlayWithID(3);
        }
        if (Input.GetKeyDown("4"))
        {
            HideOverlays();
            ShowOverlayWithID(4);
        }
    }

    void ShowOverlayWithID(int id)
    {
            PNGs[id-1].SetActive(true);
    }


    void HideOverlays()
    {
        foreach (GameObject ol in PNGs )
        {
            ol.SetActive(false);
        }
    }


}
