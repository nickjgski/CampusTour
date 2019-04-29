using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip narrationClip;
    public ulong delay;
    public AudioSource narrationSource;

    // Start is called before the first frame update
    void Start()
    {
        narrationSource.clip = narrationClip;
    }

    // Update is called once per frame
    void Update()
    {
        narrationSource.PlayDelayed(delay);
    }
}
