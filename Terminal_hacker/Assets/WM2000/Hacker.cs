using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour { 
    
    string[] level1password = {"a", "b"};
    string[] level2password = {"c", "d"};
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
       bool isValid = (input == "1" || input == "2");
       if (isValid)
       {
           level = int.Parse(input);
           StartGame();
       }
       else
       {
            
            Terminal.WriteLine("Please enter a valid choice!");   
       }
   }

   void StartGame()
   {
       currentScreen = Screen.Password;
       Terminal.ClearScreen();
       switch (level)
       {
           case 1:
               password = level1password[1];
               break;
           
           case  2:
               password = level2password[0];
               break;
           
           default:
               Debug.Log("Please enter a valid password");
               break;
       }
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
