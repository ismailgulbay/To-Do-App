using System;
using ToDo.Datas;

namespace ToDo.Operations;

public class AddingOperation{
    

    public static void Adding(){
        var newCard = new Cards();

        Console.WriteLine("ADDING CARD");
        Console.WriteLine("*******************************************");
        Console.Write("Enter title                                : ");
        newCard.Title = Console.ReadLine();

        Console.Write("Enter content                              : ");
        newCard.Content = Console.ReadLine();

        Console.Write("Choose size -> XS(1),S(2),M(3),L(4),XL(5)  : ");
        Sizes size = (Sizes)Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("DENEME");
        newCard.Size = Convert.ToString(size);

        Console.Write("Enter person ID                            : ");
        string? personId = Console.ReadLine();
        var person = Database._PersonList.FirstOrDefault(x => x.ID == personId);

        if(person != null){
            newCard.Person = person.Name;
            newCard.BoardType = "ToDo";
            Database._CardList.Add(newCard);
        }
        else Console.WriteLine("User with this ID not found.");
        
    }

    enum Sizes
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}