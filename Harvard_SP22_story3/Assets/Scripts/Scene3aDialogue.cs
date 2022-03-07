using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour
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
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
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
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);

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
            Char1speech.text = "The pantry I’m waiting for! ";
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
            Char2speech.text = "I can smell the coffee, but I don’t see it.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Sally, when did you get blind?";
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
            Char2speech.text = "Oh shush. I just woke up, Give me a break!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Ah no, your stinky little place needs a window. ";
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
            Char2speech.text = "The window will get fixed soon.";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "You’ve been saying that for weeks.  ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Stay focused! We are finding coffee.  ";
        }

        else if (primeInt == 10)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Where is it?";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 11)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = " It’s somewhere. ";
        }

        else if (primeInt == 12)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Not helpful! ";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 13)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "The smell is from the shelves. ";
        }

        else if (primeInt == 14)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Hm. Let’s go up and see!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "Sally";
            Char1speech.text = "Oh, I got it! It’s on the top shelf.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 16)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Sniffs like roasted coffee beans.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 17)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Wait… found it! ";
        }

        else if (primeInt == 18)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Should we head back and make coffee, OR should we head to the fridge for milk?”";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }


        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "You";
            Char1speech.text = "Will you hurry up?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Whom are you speaking with?";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "You";
            Char1speech.text = "Do you see anyone else here?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = " I’m fetching the coffee grinder.";
        }

        else if (primeInt == 104)
        {
            Char1name.text = "You";
            Char1speech.text = " That’s a good idea. ";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = " You see. I am a clever mouse. ";

        }

        else if (primeInt == 106)
        {
            Char1name.text = "You";
            Char1speech.text = " Ah,fine. You are the smartest mouse in the whole wide world!";
            Char2name.text = "";
            Char2speech.text = "";

        }

        else if (primeInt == 107)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I thought you wanted to make me coffee.";
        }

        else if (primeInt == 108)
        {
            Char1name.text = "You";
            Char1speech.text = "Hm, seems like you are more into it than I am.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
        //ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 200)
        {
            Char1name.text = "You";
            Char1speech.text = "Do you like the cold?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = " I’ve been to Antarctica before.";
        }

        else if (primeInt == 202)
        {
            Char1name.text = "You";
            Char1speech.text = "Yeah, right. ";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I will show you pictures when we get back.";
        }

        else if (primeInt == 204)
        {
            Char1name.text = "You";
            Char1speech.text = "I don’t see you on the cover of the Mice Times.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = " I’m a quiet achiever. ";

        }

        else if (primeInt == 206)
        {
            Char1name.text = "You";
            Char1speech.text = "Well, then the fridge would be a piece of cake.";
            Char2name.text = "";
            Char2speech.text = "";
       
        nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;

        //Debug.Log("Choice1aFunct got called!");
    }
    public void Choice1bFunct()
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
        //Debug.Log("Choice1bFunct got called!");
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene4a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene4b");
    }

}