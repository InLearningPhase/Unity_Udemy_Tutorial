using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour { 
    
    int level;
    enum Screen {MainMenu, Password, Win};
    Screen currentScreen;
    string password;
    
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

   void ShowMainMenu()
   {
       currentScreen = Screen.MainMenu;
       Terminal.ClearScreen();
       Terminal.WriteLine("What would you like to hack into?");
       Terminal.WriteLine("Press 1 for local the library");
       Terminal.WriteLine("Press 2 for police the station");
       Terminal.WriteLine("Enter your selection:");
   }

   void OnUserInput(string input)
   {
       if ( input == "menu")
       {
            ShowMainMenu();
	   }
       else if (currentScreen == Screen.MainMenu)
       {
            RunMainMenu(input);
	   }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

   void RunMainMenu(string input)
   {
       if (input == "1")
       {
            level = 1;
            StartGame();
            password = "qwerty";
	   }
       else if (input == "2")
       {
            level = 2;
            StartGame();
            password = "qq";
	   }
       else
       {
            Terminal.WriteLine("Please enter a valid choice!");   
       }
   }

   void StartGame()
   {
       currentScreen = Screen.Password;
       Terminal.WriteLine("You have choosen level " + level);
       Terminal.WriteLine("Please enter your password: ");
   }

   void CheckPassword(string input)
   {
        if (input == password)
        {
            Terminal.WriteLine("Password Confirmed");
        }
        else
        {
            Terminal.WriteLine("Wrong Password");
        }
   }
}
