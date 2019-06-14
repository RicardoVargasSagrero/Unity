using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //This variable will define all the screens in the game 
    enum Screen {MainMenu,Password,Win};
    Screen currentScreen = Screen.MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello new user");
        
    }
    void ShowMainMenu(string greeting)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Where would you like tot hack in?");
        Terminal.WriteLine("Press 1 to hack into the Library\nPress 2 to hack into the local police");
        Terminal.WriteLine("Press 3 to hack into the NASA ");
         
    }
    //This funtion prints the users input into the console of the game, it'll be call automatically when ever the user hit
    //the return or enter key 
    void OnUserInput(string input)
    {
        if(currentScreen == Screen.MainMenu)
        {
            switch (input)
            {
                case "menu":
                    ShowMainMenu("Welcome back ");
                    break;
                case "1":
                    StartGame(0);
                    break;
                case "2":
                    StartGame(1);
                    break;
                case "3":
                    StartGame(2);
                    break;
                default:
                    ShowMainMenu("Please enter a valid number");
                    break;
            }
        }else if (currentScreen == Screen.Password) {
            /*Trying to guess the password*/
            PasswordGuessing(input);
        }
       
        
    }
    void StartGame(int level)
    {
        currentScreen = Screen.Password;
        string[] levels = {"Library","Local Police Deparment","National Aeronautics and Space Administratio"};
        Terminal.ClearScreen();
        Terminal.WriteLine("You have enter to the\n" + levels[level]);
    }
    bool PasswordGuessing(string guess)
    {
        Terminal.WriteLine("Enter the password: ");
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
