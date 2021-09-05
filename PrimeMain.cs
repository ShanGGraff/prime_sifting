using System;
using System.Collections.Generic;

public class Prime{

  public static void Main()
  {
    Console.WriteLine("Please enter a number from 1 to 100");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    List<int> originalList = new List<int>();
    
    for (int number = 2; number <= inputNumber; number++)
    {
      originalList.Add(number); 
    }

    var primeNumbers = new List<int>(originalList);
    int prime = 0;
    foreach (int num in originalList) 
    {
      prime = num;
      foreach (int numX in originalList)
      {
        if (numX % prime == 0 && numX != prime)
        {
          Console.WriteLine("REMOVING " + numX);
          primeNumbers.Remove(numX);
        }
      }
    }

    foreach (int num in primeNumbers)
    {
      Console.WriteLine(num);
    }
  }
}


// const userNum = 11;

// let userArray = []

// for (let i = 2; i <= userNum; i++){
// 	userArray.push(i);
// }

// let prime = 0;
// userArray.forEach(function(number) { 
// 	prime = number;
//   console.log(`EVALUATING ${prime}`)
//   userArray.forEach(function(xnumber) { 
//   	if (xnumber % prime === 0 && xnumber !== prime) {
//       const index = userArray.indexOf(xnumber);
//       userArray.splice(index, 1);
//     }
//   })
// })

// console.log(userArray);

