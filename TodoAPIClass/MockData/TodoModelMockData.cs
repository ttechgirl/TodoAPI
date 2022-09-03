using System.Collections.Generic;
using TodoAPIClass;



namespace TodoAPIClass.MockData
{
    public class TodoModelMockData
    {
     public static IEnumerable<Todo> Todo() //Todo is a variable which can be called any name
     {
            var todos = new List<Todo>()
            {
                new Todo
                {
                    Id= 1,
                    Name="Nail Design",
                    IsCompleted=false,
                    Description="Customers will be able to choose any design and length of their choice",

                },
                new Todo
                { 
                     Id= 2,
                    Name="Nail Shapes",
                    IsCompleted=false,
                    Description="Customers will be able to choose any nail shape of their choice",

                },
                 new Todo
                 {
                     Id= 3,
                    Name="Nail colors",
                    IsCompleted=false,
                    Description="Customers will be able to select any color of their choice",
                 },

                  new Todo
                  {
                      Id= 4,
                    Name="Presson Nail Order",
                    IsCompleted=false,
                    Description="Customers will be able to order for presson nails",

                  },

                   new Todo
                   {
                       Id= 5,
                     Name="Bookings",
                     IsCompleted=false,
                     Description="Clients will be able to book for a session ",

                   },

            };
          return todos;
     
     }

       
        
    }
}
