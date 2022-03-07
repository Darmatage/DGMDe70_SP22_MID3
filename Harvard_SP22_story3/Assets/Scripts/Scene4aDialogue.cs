using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    //public GameObject Choice1b;
    public GameObject NextScene1Button;
    //public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        DialogueDisplay.SetActive(false);
        Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);

        ArtBG1.SetActive(true);
        nextButton.SetActive(true);

    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    //Story Units:
    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {

            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "This is disgusting!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Thanks for the pantry idea.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Ah, I thought it was the right place. ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Silly mouse.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Wait. I think we need almond milk!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Ya just thought of it?";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "And some sweetener for my fair mouse. ";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
            NextScene1Button.SetActive(true);
        }

    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
   public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 8;
        Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;

      
    }
   /* public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        
    }
   */
    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene4b");
    }
    /*public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3a");
    }*/

}