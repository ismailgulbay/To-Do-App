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
        newCard.Size = Convert.ToString(size);

        Console.Write("Choose person                              : ");
        Console.ReadLine();
        //TODO
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