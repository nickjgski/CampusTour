using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventListener : MonoBehaviour
{
    private Renderer _renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();
    
    }

    public void OnEnter()
    {
        _renderer.material.color = Color.red;
    }

    public void OnExit()
    {
        _renderer.material.color = Color.white;
    }

    public void onGrab()
    {

    }
}
