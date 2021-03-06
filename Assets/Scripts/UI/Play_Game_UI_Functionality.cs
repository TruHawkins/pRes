//This script was written by Tony Alessio | Last edited by Tony Alessio | Modified on Sep 14, 2017
/*
SCRIPT DESCRIPTION
	The functionality of this script is to get the UI representation of the button linked with
the function call for that specific button. This script can be placed on any object in the 
scene, but one has been provided named "Play_Menu_Functionality."
	Once attached to an object, click that object and you will then be able to attach the UI 
elements to their respective fields:
- Story Button -> [Story (Button)]
- Speed Run Mode Button -> [SpeedRun (Button)]
- Extras Button -> [Extras (Button)]
- Back Button -> [BACK (Button)]
	Once the editor knows which button is associated with its UI element, the player will be 
able to click the button to activate the function call. Most function calls simply change the 
current scene to the scene displayed on the UI button.
*/

//Libraries
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Play_Game_UI_Functionality : MonoBehaviour {
	//Member Variables
	/* This section will allow UI elements to be dragged and dropped in the inspector to assign UI elements to functions */
	[Tooltip("Drag and drop the 'Story' UI element into this field")]
	public Button storyButton;              //This will be used by the inspector to dictate which button is the "Story" button
		public Button StoryButton{ get{ return storyButton;} }

	[Tooltip("Drag and drop the 'Speed Run Mode' UI element into this field")]
	public Button speedRunModeButton;       //This will be used by the inspector to dictate which button is the "Speed Run Mode" button
	[Tooltip("Drag and drop the 'Extras' UI element into this field")]
	public Button extrasButton;             //This will be used by the inspector to dictate which button is the "Extras" button

    [Tooltip("Drag and drop the 'BACK' UI element into this field")]
    public Button backButton;				//This will be used by the inspector to dictate which button is the "Back" button



    void Start () {
		Button StoryButton = storyButton.GetComponent<Button>();				//Assigns the UI element to its script counterpart
		Button SpeedRunModeButton = speedRunModeButton.GetComponent<Button>();	//Assigns the UI element to its script counterpart
		Button ExtrasButton = extrasButton.GetComponent<Button>();				//Assigns the UI element to its script counterpart

        Button BackButton = backButton.GetComponent<Button>();					//Assigns the UI element to its script counterpart

        StoryButton.onClick.AddListener(StoryOnClick);							//Story Script
		SpeedRunModeButton.onClick.AddListener(SpeedRunModeOnClick);			//Speed Run Mode Script
		ExtrasButton.onClick.AddListener(ExtrasOnClick);						//Extras Script

        BackButton.onClick.AddListener(BackOnClick);							//Back to previous menu Script
    }

	/* This function will allow the player to click on the Story button and move to the "story_mode" scene */
	void StoryOnClick()
	{
		Main_Menu_Functionality.Singleton_Main_Menu_Functionality.play_menu_obj.SetActive(false);			//Sets Play_Menu to become invisible
		Main_Menu_Functionality.Singleton_Main_Menu_Functionality.level_select_menu_obj.SetActive(true);	//Sets level_select_menu to become visible
		Main_Menu_Functionality.Singleton_Main_Menu_Functionality.Level1Button.Select();					//Sets the Level1 button as the active cursor

		/* This is where we will need to set a variable to dictate that it is Story Mode, as opposed to Speed Run Mode */
	}

	/* This function will allow the player to click on the Speed Run Mode button and move to the "speed_run_mode" scene */
	void SpeedRunModeOnClick()
	{
		//DO NOTHING YET
	}

	/* This function will allow the player to click on the Extra button and move to the "extra_mode" scene */
	void ExtrasOnClick()
	{
		//DO NOTHING YET
	}



	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//	Back - Back Button Functionality (BEGIN)
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /* This function will allow the player to click on the BACK button and move to the "play_menu" scene */
    void BackOnClick()
    {
		Main_Menu_Functionality.Singleton_Main_Menu_Functionality.play_menu_obj.SetActive(false);			//Sets Play_Menu to become invisible
		Main_Menu_Functionality.Singleton_Main_Menu_Functionality.save_select_menu_obj.SetActive(true);		//Sets Save_Select_Menu to become visible
		Main_Menu_Functionality.Singleton_Main_Menu_Functionality.Save1Button.Select();						//Sets the Save1 button as the active cursor
    }
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//	Back - Back Button Functionality (END)
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



}
