using System;
using ToDo.Datas;

namespace ToDo.Operations;


public class ListingOperation{


    public static void Listing(){
        
        var toDo = Database._CardList.Where(x => x.BoardType == "ToDo").ToList();
        var inProgress = Database._CardList.Where(x => x.BoardType == "InProgress").ToList();
        var done = Database._CardList.Where(x => x.BoardType == "Done").ToList();
        
        Show("TODO Line", toDo);
        Show("In Progress Line", inProgress);
        Show("Done Line", done);
    }

    public static void Show(string title, IEnumerable<Cards> status){
        Console.WriteLine("\t");
        Console.WriteLine(title);
        Console.WriteLine("************************");
        var items = 0;
        foreach(Cards item in status){
            
            items ++;
            Console.WriteLine("Title       : " + item.Title);
            Console.WriteLine("Content     : " + item.Content);
            Console.WriteLine("Person      : " + item.Person);
            Console.WriteLine("Size        : " + item.Size);
            if(status.Count() != items) Console.WriteLine("------------------------" + "\t");

        }
        if(items == 0) Console.WriteLine("~ EMPTY ~");

    }


}