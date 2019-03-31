using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHandler : MonoBehaviour
{
    public Canvas can;
    private Renderer rend;
    private Material mat1;
    public Material mat2;
    // Start is called before the first frame update
    void Start()
    {
        HideCanvas();
        rend = gameObject.GetComponent<Renderer>();
        mat1 = rend.material;
    }

    public void ToggleCanvas()
    {
        if(can.gameObject.activeInHierarchy)
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
