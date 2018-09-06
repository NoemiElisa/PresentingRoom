using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changingslides : MonoBehaviour {

    public List<Texture> slides;
    public int slideSelected;
    public RawImage raw;
    private Time timeEntered;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeSlide()
    {
        if (slides != null && slides.Count >0)
        {
            slideSelected++;
            if (slideSelected >= slides.Count)
            {
                slideSelected = 0;
            }
            raw.texture = slides[slideSelected];

        }

    }

    // count the time on enter
    public void CountingEntered()
    {
       // timeEntered = Time.captureFramerate(); 
    }

    // reset to 0 on exit


}
