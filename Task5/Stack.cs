// public class Stack<T>
// {
//     List<T> _list = new List<T>();
//     public void Push(T item)
//     {
//         _list.Add(item);
//     }
//     public T Pop()
//     {
//         try
//         {
//         var l1 = _list.Last();
//         _list.Remove(l1);
//         return l1;
//         }
//         catch (System.Exception)
//         {
//             System.Console.WriteLine("List xoliyay");
//             throw;
//         }   
//     }
//     public T Peek()
//     {
//         try
//         {
//             return _list.Last();
//         }
//         catch (System.Exception)
//         {
//             System.Console.WriteLine("List xoliyay");
//             throw;
//         }
//     }
// }

