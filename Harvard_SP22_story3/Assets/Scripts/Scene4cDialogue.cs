using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4cDialogue : MonoBehaviour
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
            Char1speech.text = "Let’s see what is here...";
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
            Char2speech.text = "Did you see that cheese?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "You seeing what I’m seeing. ";
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
            Char2speech.text = "You know I like cheese!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Stating the obvious…";
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
            Char2speech.text = "I had enough of smelly cheese. ";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "I mean if it's a nice piece of gorgonzola, I can live with it. ";
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
            Char2speech.text = "STINKY, STINKY. ";
        }

        else if (primeInt == 10)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "I know you like the mild and sweet kind. ";
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
            Char2speech.text = "Exactly! That is right in front of us. ";
        }

        else if (primeInt == 12)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "I’m not sure… What if it is bad?";
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
            Char2speech.text = "Oh, come on. The smell is fresh and sweet. Plus the last swiss cheese we had was a year ago. Don’t you have cravings?";
        }

        else if (primeInt == 14)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Ah, I admit it was delicious. ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "Sally";
            Char1speech.text = " What are we waiting for?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 16)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "But we haven’t explored the pantry.  ";
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
            Char2speech.text = "Stop being silly! The pantry won’t have cheese.";
        }

        else if (primeInt == 18)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "But the pantry… ";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 19)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "We can get Swiss cheese right now! And go to the pantry right after.";

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
            Char1speech.text = "Hmmm…something doesn’t seem right.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "What do you mean?";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "You";
            Char1speech.text = "Usually cheese has other crumbs around it.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Who cares? Cheese is cheese.";
        }

        else if (primeInt == 104)
        {
            Char1name.text = "You";
            Char1speech.text = " Ah, if it makes you happy…";
            Char2name.text = "";
            Char2speech.text = "";
        
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        //Debug.Log("prime int " + primeInt);
        
       //ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 200)
        {
            Char1name.text = "You";
            Char1speech.text = "I’m excited about the pantry!";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Ah, we could have gotten that cheese. ";
        }

        else if (primeInt == 202)
        {
            Char1name.text = "You";
            Char1speech.text = "The pantry will have so much more to choose from ";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "But humans don't puch cheese in the pantry.";
        }

        else if (primeInt == 204)
        {
            Char1name.text = "You";
            Char1speech.text = "I will make it up to you, I promise! ";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Grrr, fine. ";
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
        SceneManager.LoadScene("EndScene2");
    }
    public void SceneChange2()
    {
        //SceneManager.LoadScene("Scene3a");
    }

}