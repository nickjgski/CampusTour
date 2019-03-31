using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHandler : MonoBehaviour
{
    public Canvas can;
    private Renderer rend;
    public Material mat1;
    public Material mat2;
    // Start is called before the first frame update
    void Start()
    {
        HideCanvas();
        rend = gameObject.GetComponent<Renderer>();
    }
    public void ToggleCanvas()
    {
        if(can.gameObject.activeSelf == true)
        {
            HideCanvas();
            rend.material = mat1;

        }
        else
        {
            ShowCanvas();
            rend.material = mat2;
        }
        
    }

    void HideCanvas()
    {
        can.gameObject.SetActive(false);
    }

    void ShowCanvas()
    {
        can.gameObject.SetActive(true);
    }

}
