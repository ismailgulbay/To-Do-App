using System;


namespace ToDo.Datas;

public class Database{

    public static List<Person> _PersonList;

    public static List<Cards> _CardList;

    static Database(){
        _PersonList = new List<Person>{
            new Person(){ID = "1", Name = "İsmail"},
            new Person(){ID = "2", Name = "Meric"},
            new Person(){ID = "3", Name = "Alp"}
        };

        _CardList = new List<Cards>{
            new Cards(){Title = "Register Screen", Content = "Adding register screen to web.", Person = "İsmail", Size = "XS" , BoardType = "InProgress"},
            new Cards(){Title = "Mobile App", Content = "Create mobile app for Android.", Person = "Meric", Size = "M", BoardType = "ToDo"},
            new Cards(){Title = "Mobile Web", Content = "Create mobile web.", Person = "Gulbay", Size = "S", BoardType = "ToDo"},
            new Cards(){Title = "Test Platform", Content = "Create test platform wor web.", Person = "Alp", Size = "XL", BoardType = "Done" }

        };

    }  








}