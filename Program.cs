using System;
using ToDo.Operations;


bool start = true;

while(start){
    Console.WriteLine("Please select the action you want to do");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) List the board");
    Console.WriteLine("(2) Add card to board");
    Console.WriteLine("(3) Delete card from board");
    Console.WriteLine("(4) Replace the card");

    int selection = Convert.ToInt16(Console.ReadLine());
    switch(selection){
        case 1:
            //TODO List board
            ListingOperation.Listing();
            break;
        case 2:
            //TODO Add card
            AddingOperation.Adding();
            break;
        case 3:
            //TODO Delete card
            DeletingOperation.Delete();
            break;
        case 4:
            //TODO Replace card
            break;
    }
    Console.WriteLine("Do you want to take another action? (y/n)");
    start = Console.ReadLine() == "y" ? true : false;
}
    