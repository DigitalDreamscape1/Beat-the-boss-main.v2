using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightv2 : MonoBehaviour
{
    public Light _light;

    public float MinTime;
    public float MaxTime;
    public float Timer;

    public AudioSource AS;
    public AudioClip LightAudio;
    // Start is called before the first frame update
    void Start()
    {
        Timer = Random.Range(MinTime, MaxTime);
    }

    // Update is called once per frame
    void Update()
    {
        Flickerlight();

    }

    void Flickerlight()
    {
        if (Timer > 0)
            Timer -= Time.deltaTime;
        
        if(Timer <= 0)
        {
            _light.enabled = !_light.enabled;
            Timer = Random.Range(MinTime, MaxTime);
            AS.PlayOneShot(LightAudio);
        }
    }
}
