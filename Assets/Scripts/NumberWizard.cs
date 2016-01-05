using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	int max = 1000;
	int min = 1;
	int guess = 500;
	
	// Use this for initialization
	void Start () {
		
		StartGame();
	}
	
	void StartGame () {
		
		print ("=========================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me...");
		
		print ("The highest number you can pick is " + max);
		max = max + 1; 
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow if higher, down if lower, return/enter if equal");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
//			print ("Up arrow pressed...");
			min = guess;
			NextGuess();
		} 
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
//			print ("Down arrow pressed...");
			max = guess;
			NextGuess();
		} 
		else if (Input.GetKeyDown(KeyCode.Return)){
			print ("I win!");
			max = 1000;
			min = 1;
			guess = 500;
			StartGame();
		} 
//		else {
//			print ("Invalid keypress. Try again.");
//		}
	}	
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up arrow if higher, down if lower, return/enter if equal");
	}
}
