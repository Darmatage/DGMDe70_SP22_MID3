using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
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
		  public GameObject sallyDissatisfied;
		 public GameObject mouseback;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		 public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject ButtonScene3a;
        public GameObject ButtonScene3b;
        public GameObject nextButton;
       public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		 Choice2a.SetActive(false);
        Choice2b.SetActive(false);
		nextButton.SetActive(true);
		ArtChar1.SetActive(false);
		smilingmouse.SetActive(false);
		sallyDissatisfied.SetActive(false);
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
		
		
     //   if (primeInt == 1){
                // AudioSource.Play();
      //  }
        //else if (primeInt == 2){
			   // ArtChar1.SetActive(true);
             //   DialogueDisplay.SetActive(true);
             //   Char1name.text = "YOU";
              //  Char1speech.text = "THAT cake smells delectable";
              //  Char2name.text = "";
              //  Char2speech.text = "";
      //  }
        if (primeInt ==2){
                ArtChar1.SetActive(true);
				DialogueDisplay.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "I see they got some whole milk this morning..";
				//nextButton.SetActive(false);
              // allowSpace = false;
				//Choice1a.SetActive(true); // function Choice1aFunct()
               // Choice1b.SetActive(true); // function Choice1bFunct()
                //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 3){
			   // ArtChar1.SetActive(true);
			    ArtChar1.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "You know we both can’t have that stuff!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==4){
                smilingmouse.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "But fresh produce is always better!";
		}
		else if (primeInt == 5){
			   // ArtChar1.SetActive(true);
			    smilingmouse.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Wait…what is that at the back of the fridge?";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
               allowSpace = false;
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
       
       
	   else if (primeInt == 101){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Camel milk?";
       }
      else if (primeInt == 102){
               ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "No...no...beside it...";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	 // else if (primeInt == 103){
              // sallyDissatisfied.SetActive(true);
			  // Char1name.text = "";
              // Char1speech.text = "";
              // Char2name.text = "";
              // Char2speech.text = "";
	  //}
	  else if (primeInt == 104){
               sallyDissatisfied.SetActive(true);
			   //ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Oh I see almond milk. But it is probably old, and way back in the fridge.";
			   nextButton.SetActive(false);
               allowSpace = false;
				Choice2a.SetActive(true); // function Choice1aFunct()
                Choice2b.SetActive(true); // function Choice1bFunct()
	  }
	  else if (primeInt == 51){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Goat milk?";
			   primeInt=101;
       }
	  
	  /*else if (primeInt == 201){
		  sallyDissatisfied.SetActive(false);
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
               ArtChar1.SetActive(false);
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
	   }*/
		else if (primeInt == 301){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Awesome! Regular milk here we come…";
	   }	
	   else if (primeInt == 302){
               ArtChar1.SetActive(false);
			   smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "No Sally!";
               Char2name.text = "";
               Char2speech.text = "";
	   }
     else if (primeInt == 303){
               sallyDissatisfied.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Now WHAT!?";
	 }
	  else if (primeInt == 304){
               ArtChar1.SetActive(false);
			   sallyDissatisfied.SetActive(false);
			   smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "I’d rather take the almond milk. AND we need our sweetener.";
               Char2name.text = "";
               Char2speech.text = "";
	   }
	   else if (primeInt == 305){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Awesome! ‘Strawberry Shortcake’ here we come…";
	 }
	 else if (primeInt == 306){
               ArtChar1.SetActive(false);
			   smilingmouse.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "NOOO Sally! The Chef just baked cake and will spot us if we get close.";
               Char2name.text = "";
               Char2speech.text = "";
	   }
	   else if (primeInt == 307){
               sallyDissatisfied.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Breaking NEWS!…The sweetener is in the Chef's pocket anyway!!";
	 }
	 else if (primeInt == 308){
               ArtChar1.SetActive(false);
			   smilingmouse.SetActive(false);
			   sallyDissatisfied.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "You shall witness my sneaky pick-pocketing!";
               Char2name.text = "";
               Char2speech.text = "";
	   }
	   else if (primeInt == 309){
               sallyDissatisfied.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "FINE! I’ll go grab the milk and take a quick sip…I am thirsty!";
	 }
	 else if (primeInt == 310){
               ArtChar1.SetActive(false);
			   smilingmouse.SetActive(false);
			   sallyDissatisfied.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "ALMOND milk, please!";
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
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "No...beside that.";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 100;
               Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }
	    public void Choice2aFunct(){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "Maybe grab what's closer? Almond milk IS way far back and it's getting cold in here.";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 300;
               Choice2a.SetActive(false);
               Choice2b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }

       public void Choice1bFunct(){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "No, beside it...";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 50;
              Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }
	   public void Choice2bFunct(){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "True...it is further than regular milk. And it is getting cold in here.";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 300;
              Choice2a.SetActive(false);
               Choice2b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }

        public void SceneChange1(){
			    SceneManager.LoadScene("SceneEnd1");
				nextButton.SetActive(false);
				allowSpace=false;
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5a");
				nextButton.SetActive(false);
				allowSpace=false;
}
}