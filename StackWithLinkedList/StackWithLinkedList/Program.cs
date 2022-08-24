using StackWithLinkedList;

var list = new Stack();

list.Push(2);
list.Pop();
list.Pop();
list.Push(4);
list.Push(5);
list.Push(6);

list.Print();
list.Pop();
list.Pop();
list.Pop();
list.Pop();

list.Push(5);
list.Push(6);
list.Push(6);
list.Print();