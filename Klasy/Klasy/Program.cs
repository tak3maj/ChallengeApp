﻿using Klasy;
User user1 = new User("Adam", "32423ffddf");
User user2 = new User("Monika", "32423ffddf");
User user3 = new User("Zuzia", "32423ffddf");
User user4 = new User("Damian", "32423ffddf");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);



