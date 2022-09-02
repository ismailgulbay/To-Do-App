using System;
using ToDo.Datas;

namespace ToDo.Operations;
//  * Silmeyi sonlandırmak için : (1)
//  * Yeniden denemek için : (2)
public class DeletingOperation{

    public static void Delete(){
        bool again = true;
        
        while(again){
            Console.WriteLine("You need to select the card you want to delete.");
            Console.Write("Please enter card title : ");
            string? title = Console.ReadLine();

            var check = Database._CardList.FirstOrDefault(x => x.Title == title);
            if(check is not null){
                Database._CardList.Remove(check);

                again = false;
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