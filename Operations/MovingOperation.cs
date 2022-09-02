using System;
using ToDo.Datas;

namespace ToDo.Operations;

public class MovingOperation{

    public static void Move(){
        bool again = true;

        while(again){
            Console.Write("Please enter the title of the card which you want to move: ");
            string? title = Console.ReadLine();

            var check = Database._CardList.FirstOrDefault(x => x.Title == title);

            if(check != null){
                Console.WriteLine("Information of card : ");
                Console.WriteLine("**************************************");
                Console.WriteLine("Title       : " + check.Title);
                Console.WriteLine("Content     : " + check.Content);
                Console.WriteLine("Person      : " + check.Person);
                Console.WriteLine("Size        : " + check.Size);
                Console.WriteLine("Line        : " + check.BoardType);

                Console.WriteLine("Select the line : ");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                string? line = Console.ReadLine();

                if (line == "1") { check.BoardType = "ToDo"; }
                else if (line == "2") { check.BoardType = "InProgress"; }
                else if (line == "3") { check.BoardType = "Done"; }
                else { check.BoardType = "Wrong choice !"; }
                again = false;
                ListingOperation.Listing();
                

                
            }
            else{
                Console.WriteLine("Card with this title not found");
                Console.WriteLine("* To end the deletion : (1) ");
                Console.WriteLine("* To try again : (2)");
                again = Convert.ToInt16(Console.ReadLine()) == 1 ? false : true;
            }

        }
    }
}
