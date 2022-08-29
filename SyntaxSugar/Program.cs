using System;
//int answer = 4; // exolicit typing
//string response; //explicit typing

//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + “greater than or equal to nine”;
//}

var answer = 4;
var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than ir equak to nine";

Console.WriteLine(response);
