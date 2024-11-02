using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ass10 : MonoBehaviour
{
 

    //? Define the Multiply function 
     private int Multiply(int number1, int number2) {
        return number1 * number2;
        }

    // Start is called before the first frame update
    void Start()
    {
       int multiplicationTableFor5 = 5;
        for(int number=1; number<=10;number++){
           int result = Multiply(multiplicationTableFor5,number);
           Debug.Log($"{multiplicationTableFor5} * {number} = {result}");
        
       }
        
    }
  
   
}
