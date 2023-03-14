using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE_Default : BoardEffect
{
    public BE_Default(){
    
    name = "Default";
    description = "No effect";

    length = -1;
    }

    public override void Effect()
    {
       return;
        //empty (no effect)
    }
}