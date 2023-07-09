using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TouchJump : MonoBehaviour
{
    public Jump jumpReference;

    public void Click()
    {
        jumpReference.Click();
    }
}