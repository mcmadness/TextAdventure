using UnityEngine;
using System.Collections;
using UnityEngine.UI ;


public class textAdventure : MonoBehaviour {

	string currentRoom = "Your Bedroom" ;
	bool didChores = false ;
	bool canDoChores = false ;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "You are currently in: " + currentRoom ;

		if (currentRoom == "Your Bedroom") {

			if (canDoChores == false) {
				textBuffer += "\n\nYou open your eyes only to realize the day has finally come."; 
				textBuffer += "\nIt's the first morning of summer break and only one thing is on your mind:";
				textBuffer += "\nOverwatch.";
				textBuffer += "\nThe only question now is...how do you persuade your parents to let you get it.\n";
			} else if (canDoChores == true) {
				textBuffer += "\n\nPress [O] to make your bed, take out your trash,\nand wash your laundry before returning to the living room.";
				if (Input.GetKeyDown (KeyCode.O)) {
					currentRoom = "the Living Room";
					didChores = true;
				}

			}

			textBuffer += "\nPress [S] to go back to sleep";
			textBuffer += "\nPress [M] to talk to your mom in the living room";

			if (Input.GetKeyDown (KeyCode.S)) {
				currentRoom = "Hibernation";
			} else if (Input.GetKeyDown (KeyCode.M)) {
				currentRoom = "the Living Room";
			}


		} else if (currentRoom == "Hibernation") {
			textBuffer += "\n\nYou awake again. While dreams are fun, Overwatch is fun...er. More fun.";
			textBuffer += "\nNo more time for games. But... still kinda time for games.";
			textBuffer += "\n\nPress [M] to talk to your mom in the living room";

			if (Input.GetKeyDown (KeyCode.M)) {
				currentRoom = "the Living Room";
			}
			
		} else if (currentRoom == "the Living Room") {
			
			textBuffer += "\n\nThis part is key. You've got to choose juuuust the right phrasing \nto make it seem like you deserve the game while trying not to remind dear ol' mom \nof the days worth of chores and and flute practice you've been skipping out on.";
			textBuffer += "\nWhat should you say?";
			textBuffer += "\n\n[A] Hey mum? Could I please get this new game Overwatch?";
			textBuffer += "\n[B] Hey mom! Did you know that kids who play the most newly released games on the market \nare shown to improve their grades at school by a minimum of 20%?\nI mean I'm already pulling all A's of course but still!...always room for an A+...!";
			textBuffer += "\n[C] Cry. Just cry.";

			if (Input.GetKeyDown (KeyCode.A) && (didChores == false)) {
				currentRoom = "Anxious Anticipation";
			} else if (Input.GetKeyDown (KeyCode.B)) {
				currentRoom = "a Rough Spot";
			} else if (Input.GetKeyDown (KeyCode.C)) {
				currentRoom = "a Rough Spot";
			} else if (Input.GetKeyDown (KeyCode.A) && (didChores == true)) {
				currentRoom = "the Front Doorway";
			}


		} else if (currentRoom == "Anxious Anticipation") {
			
			if (didChores == false) {
				textBuffer += "\n\nLooks like she's considering it but you haven't quite got her convinced.\nYou've gotta get into her good graces somehow...";
				textBuffer += "\n\nPress [D] to talk to dad.";
				textBuffer += "\nPress [X] to go to your bedroom.";
				if (Input.GetKeyDown (KeyCode.D)) {
					currentRoom = "Dad's Office";
				} else if (Input.GetKeyDown (KeyCode.X)) {
					currentRoom = "Your Bedroom";
					canDoChores = true;
				}
		

		
			}
		} else if (currentRoom == "a Rough Spot") {
			textBuffer += "\n\nNo dice. She's not buying it. Better try something else.";
			textBuffer += "\n\nPress [M] to ask your mom again.";
			if (Input.GetKeyDown (KeyCode.M)) {
				currentRoom = "the Living Room";

			}
		} else if (currentRoom == "the Front Doorway") {
			textBuffer += "\n\nPermission granted! Chores are always the answer. But just as you're walking out\nthe door headed to your local Best Buy you suddenly remember:\nyou need some cash. Bad.";
			textBuffer += "\n\nPress [P] to check your piggy bank.";
			textBuffer += "\nPress [D] to talk to dad.";
				
			if (Input.GetKeyDown (KeyCode.D)) {
				currentRoom = "Dad's Office";
			} else if (Input.GetKeyDown (KeyCode.P)) {
				currentRoom = "Despair";
			}



		} else if (currentRoom == "Dad's Office") {
			textBuffer += "\n\nThe man. The myth. The legend. Dad.";
			if (didChores == false) {
				textBuffer += "\nBut even he can't help you now. He's giving you one of those\ngo-ask-your-mother type of responses.";
				textBuffer += "\n\nPress [M] to talk to your mom in the living room.";
				if (Input.GetKeyDown (KeyCode.M)) {
					currentRoom = "the Living Room";
				}

			} else if (didChores == true) {
				textBuffer += "\nIt hardly seems like you get two words out about your predicament\nbefore he gives you that knowing smile and the meager funds to make\nyour digital dreams come true.";
				textBuffer += "\n\nPress [Space] to go buy Overwatch.";
				if (Input.GetKeyDown (KeyCode.Space)) {
					currentRoom = "Heaven";

				}
			}


		} else if (currentRoom == "Despair") {
			textBuffer += "\n\nNo sight is more brutal...than an empty piggy bank.";
			textBuffer += "\n\nPress [A] to remind yourself that life isn't all bad.";
			if (Input.GetKeyDown (KeyCode.A)) {
				currentRoom = "the Front Doorway";
			}
		}



		else if (currentRoom == "Heaven") {
			textBuffer += "\n\nCongratulations! You bought Overwatch!";
		}
			


		GetComponent<Text> ().text = textBuffer;
	}
}
