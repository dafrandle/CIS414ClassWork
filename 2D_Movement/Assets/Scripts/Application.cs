// Dustin Frandle

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour {

	public Model model;
	public View view;
	public Controller controller;

	void Start () { }
}

public class ApplicationElement : MonoBehaviour { 
	public Application application { get {return GameObject.FindObjectOfType<Application>();}}
}
/*
as this is the top level script - I will leave some notes here:

This project originates from this tutorial:
https://www.youtube.com/watch?v=dwcT-Dch0bA


hierarchy:
Application -+
             |
	     +- Model
             |
	     +- View -+
             |        |
             |        +- PlayerModel
             |        |
             |        +- PlayerView
             |        |
             |        +- PlayerController
             |          			
	     +- Controller
			 
You can see the original code in these files:
CharacterController2D.cs
PlayerMovement.cs

All variables in both files were moved into PlayerModel.cs
PlayerMovement.cs's functions were moved into PlayerController.cs because they handled the users control of the player
CharacterController2D.cs's functions were moved into PlayerView.cs because they handled moving the player's sprite


I have left the code broadly unchanged accept for a few things:

1st: 
	All of the various data things were made public so they could be accessed by other classes

	I didn't make properties because I'm lazy accept on k_GroundedRadius and k_CeilingRadius because they are const 
	and must be accessed through a property from other classes

2nd: 
	The Awake function in CharacterController2D.cs was removed because with MVC it is now redundant - I can get the 
	player's Rigidbody2D from the application
	
3rd:
	PlayerMovement.cs has a variable to hold a reference to CharacterController2D.cs so it can call move.
	This is also redundant - I can access it from the application as well.
*/
