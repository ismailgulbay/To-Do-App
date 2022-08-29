using System;


namespace ToDo.Datas;

public class Board{

    public List<Board>? ToDo{get; set;}

    public List<Board>? InProgress{get; set;}

    public List<Board>? Done{get; set;}
}