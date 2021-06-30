using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Interfaces are not a class and they don't have their own instances. 
A class INHERITS from another class, A class implements a method (INTERFACES);
Main benefit: Commonly used functions can be used by different classes;

Good explanation and usage about interfaces : https://www.youtube.com/watch?v=MZOrGXk4XFI (8th min.) 
*/

public interface IKillable
{
    void Kill();
}

//This is a generic interface where T is a placeholder
//for a data type that will be provided by the 
//implementing class.
public interface IDamageable<T>  
{
    void Damage(T damageTaken);
}