using System;


namespace ToDo.Datas;




public class Database{

    private static List<Person> _PersonList;

    private static List<Cards> _CardList;

    static Database(){
        _PersonList = new List<Person>{
            new Person(){ID = "1", Name = "İsmail"},
            new Person(){ID = "2", Name = "Meric"},
            new Person(){ID = "3", Name = "Alp"}
        };

        _CardList = new List<Cards>{
            new Cards(){Title = "Register Screen", Content = "Adding register screen to web.", Person = "İsmail", Size = "XS" , BoardType = "InProgress"},
            new Cards(){Title = "Mobile App", Content = "Create mobile app for Android.", Person = "Meric", Size = "M", BoardType = "ToDo"},
            new Cards(){Title = "Test Platform", Content = "Create test platform wor web.", Person = "Alp", Size = "L", BoardType = "Done" }

        };

    }  








}