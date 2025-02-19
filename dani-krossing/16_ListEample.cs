using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    // List is based on a class (not a data type). It exist in System.Collections.Generic
    List<string> _numbers = new List<string>();

    void Start()
    {
        _numbers.Add("Learn");
        _numbers.Add("Unity");
        _numbers.Add("Game");
        _numbers.Add("Engine");

        _numbers.Remove("Learn");

        _numbers.Insert(1, "Unreal ");

        Debug.Log(_numbers[1]);

    }

    void Update()
    {


    }
}
