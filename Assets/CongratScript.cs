using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh displayedText;
    public ParticleSystem sparksParticles;
    
    private List<string> textToDisplay = new List<string>();
    
    private float rotatingSpeed = 1.0f;
    private float timeToNextText;

    private int currentText;
    
    // Start is called before the first frame update
    void Start()
    {
        timeToNextText = 0.0f;
        currentText = 0;

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        displayedText.text = textToDisplay[0];
        
        sparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timeToNextText += Time.deltaTime;

        if (timeToNextText > rotatingSpeed)
        {
            timeToNextText = 0.0f;
            
            currentText++;

            if (currentText >= textToDisplay.Count)
            {
                currentText = 0;
            }

            displayedText.text = textToDisplay[currentText];
        }
    }
}
