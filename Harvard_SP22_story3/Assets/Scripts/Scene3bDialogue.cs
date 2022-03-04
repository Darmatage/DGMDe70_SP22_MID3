using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       // public Text Char3name;
       // public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		 public GameObject smilingmouse;
		 public GameObject mouseback;
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
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		nextButton.SetActive(true);
		ArtChar1.SetActive(false);
		smilingmouse.SetActive(false);
		mouseback.SetActive(false);
		ButtonScene3a.SetActive(false);
        ButtonScene3b.SetActive(false);
		
        DialogueDisplay.SetActive(false);
		ArtBG1.SetActive(true);
        
        
		
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
                Char1speech.text = "THAT cake smells delectable";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                smilingmouse.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "My smelling powers are unbeatable.";
				//nextButton.SetActive(false);
              // allowSpace = false;
				//Choice1a.SetActive(true); // function Choice1aFunct()
               // Choice1b.SetActive(true); // function Choice1bFunct()
                //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4){
			   // ArtChar1.SetActive(true);
			    smilingmouse.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "We could take a small bite and THEN make the latte?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==5){
                smilingmouse.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "Now…now…my supernose is onto something…";
		}
		else if (primeInt == 6){
			   // ArtChar1.SetActive(true);
			    smilingmouse.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "What is it now?";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
               allowSpace = false;
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
       
       
	   else if (primeInt == 101){
               ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "I know what's better than strawberry shortcake...";
               Char2name.text = "";
               Char2speech.text = "";
       }
      else if (primeInt == 102){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally and YOU";
               Char2speech.text = "CHEEEEESE!";
	  }
	  else if (primeInt == 103){
               smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "But Sally?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 104){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Now what?";
	  }
	  else if (primeInt == 105){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "Why would there ever be cheese under the table?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 106){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "I don’t know…the chefs drop good food all the time.";
	  }
	  else if (primeInt == 107){
               ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "It does smell fresh…could be a recent drop?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
      else if (primeInt == 108){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Now you’re making some sense!";
			   //ButtonScene3a.SetActive(true);
	          // ButtonScene3b.SetActive(true);
              // nextButton.SetActive(false);
              // allowSpace = false;
              // DialogueDisplay.SetActive(false);
       }
	else if (primeInt == 109){
               ArtChar1.SetActive(false);
			   smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "What about this sweet-smelling cake right here, and the LATTE we want to make?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	   else if (primeInt == 110){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "You get the cheese and I'll get the cake!";
	   }
	   else if (primeInt == 111){
               smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "How about we just get cake and make coffee?";
               Char2name.text = "";
               Char2speech.text = "";
			   ButtonScene3a.SetActive(true);
	           ButtonScene3b.SetActive(true);
               nextButton.SetActive(false);
               allowSpace = false;
              DialogueDisplay.SetActive(false);
			   
	   }
     // else if (primeInt == 200){
              // smilingmouse.SetActive(true);
			  // Char1name.text = "";
              // Char1speech.text = "";
              // Char2name.text = "Sally";
              // Char2speech.text = "Is your nose growing superpowers? IT IS cheese!";
	  
	  else if (primeInt == 201){
               smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "But Sally?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 202){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Now what?";
	  }
	  else if (primeInt == 203){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "Why would there ever be cheese under the table?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 204){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "I don’t know…the chefs drop good food all the time.";
	  }
	  else if (primeInt == 205){
               ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "It does smell fresh…could be a recent drop?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
      else if (primeInt == 206){
		  smilingmouse.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Now you’re making some sense!";
			  
       }
	else if (primeInt == 207){
               ArtChar1.SetActive(false);
			   smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "What about this sweet-smelling cake right here, and the LATTE we want to make?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	   else if (primeInt == 208){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "You get the cheese and I'll get the cake!";
	   }
	   else if (primeInt == 209){
               smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "How about we just get cake and make coffee?";
               Char2name.text = "";
               Char2speech.text = "";
			   ButtonScene3a.SetActive(true);
	           ButtonScene3b.SetActive(true);
               nextButton.SetActive(false);
               allowSpace = false;
              DialogueDisplay.SetActive(false);
	   }
			   
	   }
     

//FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
       public void Choice1aFunct(){
               smilingmouse.SetActive(true);
			   ArtChar1.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "SALLY";
               Char2speech.text = "Oh no! It's something even better!";
               primeInt = 100;
               Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }
       public void Choice1bFunct(){
               smilingmouse.SetActive(true);
			   ArtChar1.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "SALLY";
               Char2speech.text = "Is your nose growing superpowers? IT really IS cheese!";
               primeInt = 200;
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