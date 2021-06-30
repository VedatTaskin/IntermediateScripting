using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Generic testing script, 
// For example GetComponent<> is a generic method

public class GenericTesting : MonoBehaviour
{
    private void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();
        myClass.UpdateItem(5);
    }

}




//We can make a Generic Class
public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
        Debug.Log(item);
    }
}

public class GenericUsingExamples
{
    // T could represent any type, its name is arbitrary, T is also place holder; According to type of T we do something in method
    public T GenericMethod<T>(T param)
    {
        return param;
    }

    public T GenericMethod2<T, U, V>(T param)  // a Generic methods can take more than one variables, 
    {
        return param;
    }


    public T GenericMethod3<T>(T param) where T : IEnumerable // T'can be constrainted. Interface, Class, Struct, Monobehaviour
    {
        return param;
    }

}
