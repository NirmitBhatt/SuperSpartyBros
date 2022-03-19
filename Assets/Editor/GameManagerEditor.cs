using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; //this is needed since the script references the Unity editor

[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor //extend the Editor class
{
    public override void OnInspectorGUI()
    {
        //show the default inspector stuff for this component
        DrawDefaultInspector();

        //get a reference to the GameManager script on this target gameObject
        GameManager myGM = (GameManager)target;

        //add a custom button to the Inspector component
        if(GUILayout.Button("Reset Player State"))
        {
            //if button pressed then call function in script
            PlayerPrefManager.ResetPlayerState(myGM.startLives, false);
        }

        if(GUILayout.Button("Reset Highscore"))
        {
            PlayerPrefManager.SetHighscore(0);
        }

        if(GUILayout.Button("Output Player State"))
        {
            PlayerPrefManager.ShowPlayerPrefs();
        }
    }
   
}
