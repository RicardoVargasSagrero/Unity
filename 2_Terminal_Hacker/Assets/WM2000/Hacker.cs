using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome user");
        Terminal.WriteLine("Where would you like tot hack in?");
        Terminal.WriteLine("Press 1 to hack into the Library\nPress 2 to hack into the local police");
        Terminal.WriteLine("Press 3 to hack into the NASA ");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
