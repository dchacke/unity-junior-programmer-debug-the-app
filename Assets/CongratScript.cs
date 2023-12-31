using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh displayedText;
    public ParticleSystem sparksParticles;
    
    private List<string> textToDisplay = new List<string>();
    
    private float rotatingSpeed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        textToDisplay.Add("Congratulations");
        textToDisplay.Add("All Errors Fixed");

        displayedText.text = textToDisplay[0];
        
        sparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)((Time.time / rotatingSpeed) % textToDisplay.Count);
        displayedText.text = textToDisplay[index];
    }
}
