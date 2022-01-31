using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public float musicVol;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CheckMusicVol(float inputVol)
    {
        Debug.Log("the music vol is=" + inputVol);
        musicVol = inputVol;
    }


}
