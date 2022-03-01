using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       // public Text Char3name;
       // public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		// public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject ButtonScene3a;
        public GameObject ButtonScene3b;
        public GameObject nextButton;
       public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        
		ArtBG1.SetActive(true);
		nextButton.SetActive(true);
		ButtonScene3a.SetActive(false);
        ButtonScene3b.SetActive(false);
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
			   // ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I know the pantry has coffee…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MOUSE";
                Char2speech.text = "The kitchen looks alluring...";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar1.SetActive(false);
				Char1name.text = "YOU";
                Char1speech.text = "Let's get coffee!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MOUSE";
                Char2speech.text = "Oooooh! Is that strawberry shortcake?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(false);
				Char1name.text = "YOU";
                Char1speech.text = "Let's not get too greedy here!";
                Char2name.text = "";
               Char2speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MOUSE";
               Char2speech.text = "That cake will go so well with my coffee...";
				
        }
       else if (primeInt == 8){
              ArtChar1.SetActive(false);
			  Char1name.text = "";
              Char1speech.text = "";
                Char2name.text = "";
              Char2speech.text = "";
                 //Turn off "Next" button, turn on "scene" buttons
			nextButton.SetActive(false);
               allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
		
// ENCOUNTER AFTER CHOICE #1
      else if (primeInt == 100){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally Mouse";
               Char2speech.text = "Yeah! Let's have some cake!";
       }
      else if (primeInt == 101){
               Char1name.text = "YOU";
               Char1speech.text = "I think the pantry would be safer...";
               Char2name.text = "";
               Char2speech.text = "";
               nextButton.SetActive(false);
               allowSpace = false;
               ButtonScene3a.SetActive(true);
	           ButtonScene3b.SetActive(true);
       }

      else if (primeInt == 200){
               Char1name.text = "";
              Char1speech.text = "";
               Char2name.text = "Sally Mouse";
               Char2speech.text = "Well, I'm done hunting for scraps in the smelly alley!";
       }
	   
	         else if (primeInt == 201){
               Char1name.text = "";
              Char1speech.text = "";
               Char2name.text = "Sally Mouse";
               Char2speech.text = "I'm going in. I want cake!";
       }
	   
      else if (primeInt == 202){
               Char1name.text = "YOU";
               Char1speech.text = "Well... at least let's be safer, and go to the pantry...";
              Char2name.text = "";
               Char2speech.text = "";
               nextButton.SetActive(false);
               allowSpace = false;
              ButtonScene3a.SetActive(true);
			ButtonScene3b.SetActive(true);
        }
     }

//FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
       public void Choice1aFunct(){
               Char1name.text = "YOU";
               Char1speech.text = "I'm ready feel warm!";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 99;
               Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }
       public void Choice1bFunct(){
               Char1name.text = "YOU";
               Char1speech.text = "I really think we shoulnd scrounge in the alley.";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 199;
              Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }

        public void SceneChange1(){
			    SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }
}