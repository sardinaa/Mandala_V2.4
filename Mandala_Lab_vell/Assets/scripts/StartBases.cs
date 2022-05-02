using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBases : MonoBehaviour
{
    public float volume = 0.5f;
    AudioSource AudioBase;
    // Start is called before the first frame update
    void Start()
    {
        AudioBase = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartSpot1._Spot1Started == true && StartSpot2._Spot2Started == true && StartSpot3._Spot31Started == true && StartSpot4._Spot4Started == true)
        {
            
            StartCoroutine(AudioFadeOut.FadeOut(GameObject.Find("initialization").GetComponent<AudioSource>(), 0.75f));
            GameObject.Find("Spots 1").GetComponent<PatronControllerSpot1>().enabled = true;
            GameObject.Find("Spots 2").GetComponent<PatronControllerSpot2>().enabled = true;
            GameObject.Find("Spots 3").GetComponent<PatronControllerSpot3>().enabled = true;
            GameObject.Find("Spots 4").GetComponent<PatronControllerSpot4>().enabled = true;

            GameObject.Find("Ripple_Bases_Spot1").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Ripple_Bases_Spot2").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Ripple_Bases_Spot3").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Ripple_Bases_Spot4").GetComponent<ParticleSystem>().Stop();

            AudioBase.Play();
            GetComponent<StartBases>().enabled = false;
        }
        
    }
}
