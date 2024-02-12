﻿namespace StackProgram;
internal class Program {
   private static void Main (string[] args) {
   }
}

/// <summary>The class MyStack defines the implementation of stack with array as the underlying data structure</summary>
/// <typeparam name="T">Datatype of the elements in the stack</typeparam>
public class MyStack<T> {
   /// <summary>Constructor of MyStack class</summary>
   public MyStack () {
      mArray = new T[4];
      mTop = -1;
   }

   /// <summary>Capacity of the stack</summary>
   public int Capacity => mArray.Length;

   /// <summary>Count of the elements in the stack</summary>
   public int Count => mTop + 1;

   /// <summary>Push method for adding(pushing) elements into the stack</summary>
   /// <param name="a">the element to be pushed</param>
   public void Push (T a) {
      if (mTop == (Capacity - 1)) Array.Resize (ref mArray, Capacity * 2);
      mArray[++mTop] = a;
   }

   /// <summary>Pop method for deleting (popping) the last element from the stack</summary>
   /// <returns>Returns the array after popping</returns>
   /// <exception cref="InvalidOperationException"></exception>
   public T Pop () {
      if (IsEmpty) throw new InvalidOperationException ();
      var item = mArray[mTop];
      mTop--;
      return item;
   }

   /// <summary>Peek method for returning the last element of the stack</summary>
   /// <returns>Returns the last element</returns>
   /// <exception cref="InvalidOperationException"></exception>
   public T Peek () {
      if (IsEmpty) throw new InvalidOperationException ();
      return mArray[mTop];
   }

   /// <summary> sEmpty property to check whether the stack is empty</summary>
   public bool IsEmpty => mTop == -1;

   /// <summary>Display method to print the elements of the stack</summary>
   public void Display () {
      for (int i = 0; i <= mTop; i++)
         Console.Write (mArray[i] + " ");
      Console.WriteLine ();
   }

   T[] mArray;
   int mTop;
}