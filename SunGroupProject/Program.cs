using SunGroupProject;
using SunGroupProject.Classes;
using SunGroupProject.Structs;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

#region PersonsList
//List<Person> personsList = new List<Person>();

//DateTime date = new DateTime(2000, 10, 30);

//for (int i = 1; i <= 10; i++)
//{
//    date = date.AddDays(1);
//    Person person = new Person();
//    person.Name = $"Person {i}";
//    person.DOB = date.AddDays(1);
//    person.Address = $"Address {i}";
//    person.City = $"City {i}";
//    person.PhoneNumber = $"Phone {i}";
//    person.IdNumber = $"Id {i}";

//    if(i%2 == 0)
//    {
//        person.gender = Gender.Female;
//    }
//    else
//    {
//        person.gender = Gender.Male;
//    }


//    personsList.Add(person);
//}


//foreach (Person CurPerson in personsList)
//{
//    Console.WriteLine($"Your name : {CurPerson.Name}, You are a : {CurPerson.gender}");
//}
#endregion

#region Struct
//Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
//Console.WriteLine($"Coffee1 strength : {coffee1.strength}, Bean : {coffee1.bean}, Origin : {coffee1.origin}");





//Console.WriteLine($"Person 1 Name : {person1.Name}, Person 2 Name : {person2.Name}");
//person1.Name = "New Name";
//Console.WriteLine($"Person 1 Name : {person1.Name}, Person 2 Name : {person2.Name}");

//Coffee coffee2 = coffee1;
//Console.WriteLine($"Coffee1 strength : {coffee1.strength}, Bean : {coffee1.bean}, Origin : {coffee1.origin}, Coffee2 strength : {coffee2.strength}, Bean : {coffee2.bean}, Origin : {coffee2.origin}");

//coffee2.strength = 5;
//coffee2.bean = "Black";
//coffee2.origin = "Brazil";
//Console.WriteLine($"Coffee1 strength : {coffee1.strength}, Bean : {coffee1.bean}, Origin : {coffee1.origin}, Coffee2 strength : {coffee2.strength}, Bean : {coffee2.bean}, Origin : {coffee2.origin}");
#endregion

#region Indexer
//Menu menu = new Menu();

//beverage MyBeverage = menu[5];

//Console.WriteLine($"ID : {MyBeverage.ID}, Name : {MyBeverage.Name}");

//foreach (beverage b in menu.beveragesList)
//{
//    Console.WriteLine($"ID : {b.ID}, Name : {b.Name}");
//}
#endregion


#region Stack&Queue
//Stack<int> liststack = new Stack<int>();

//for (int i = 1; i<= 10; i++)
//{
//    liststack.Push(i);
//}

//for (int i = 0;i < liststack.Count; i++)
//{
//    //Console.WriteLine(liststack.Pop());
//    Console.WriteLine(liststack.ElementAt(i));
//}
//Queue<int> intQueue = new Queue<int>();

//for (int i = 1; i <= 10; i++)
//{
//    intQueue.Enqueue(i);
//}
//for (int i = 0; i < intQueue.Count; i++)
//{
//    Console.WriteLine(intQueue.Dequeue());
//    //Console.WriteLine(intQueue.ElementAt(i));
//}

#endregion

#region ArrayList
//ArrayList arrayList = new ArrayList();
//Person person = new Person();
//Coffee coffee1 = new Coffee(4, "Arabica", "Columbia") ;
//arrayList.Add(1);
//arrayList.Add("Ahmed");
//arrayList.Add(true);
//arrayList.Add(person);
//arrayList.Add(coffee1);
//foreach (var i in arrayList)
//{
//    if(i.GetType() == typeof(Person))
//    {
//        Person person2 = (Person)i;
//        Console.WriteLine(person2.Name);

//    }else if(i is Coffee)
//    {
//        Coffee coffee3 = (Coffee)i;
//        Console.WriteLine(coffee3.bean);
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }

//}
#endregion

#region dictionary
//SortedList sl = new SortedList();
//sl.Add("ID", 5);
//sl.Add("Name", "New Horaizons");
///*Console.WriteLine($"Name : {sl["Name"]}")*/;

//foreach (var s in sl.Keys)
//{
//    Console.WriteLine(s);
//}
//Dictionary<string, string> dict = new Dictionary<string, string>();
//dict.Add("ID", "1");
//dict.Add("Name", "Ahmed");
//foreach (var s in dict)
//{
//    Console.WriteLine($"Key : {s.Key}, Vlaue : {s.Value}");
//}
#endregion

#region ExtintionMethods
//string str = "159";

//Console.WriteLine(str.UpperStr());

//int i = 0;
//if(i.IsNumber(str, out i))
//{
//    Console.WriteLine(i.ToString());
//}
//else
//{

//Console.WriteLine("Value Not Valid"); }

//DateTime dt = DateTime.Now;

//string str2 = dt.formatdate();

//Console.WriteLine(str2);

//string text = "gsdgsd";
//char[] chars = text.ToCharArray();
//bool ConNum = false;
//foreach(char c in chars)
//{
//    int ii;

//    if (int.TryParse(c.ToString(), out ii))
//    {
//        ConNum = true;
//        break;
//    }

//}
//if (ConNum == false)
//    Console.WriteLine("Tesxt Not contains Numbers");
//else
//    Console.WriteLine("Tesxt contains Numbers");
#endregion


#region Luc11/08/2024

#region DelegateText
//string str = "Test Delegates";
//CallText(str, UpperCase);
//CallText(str, LowerCase);
//CallText(str, SubText);
//CallText(str, Replace);

//CallText(str, delegate (string MyText) { Console.WriteLine(MyText.ToUpper()); });

////Lambda 

//CallText(str, (text) => Console.WriteLine(text.ToLower()));

//CallUpperText(() => Console.WriteLine("No Parameters Delegete"));

//void CallText(string text, ShowText dlg) => dlg(text);

//void CallUpperText(ShowUpperText dlg) => dlg();

//void UpperCase(string text)
//{
//    text = text.ToUpper();
//    Console.WriteLine(text);
//}
//void LowerCase(string text)
//{
//    text = text.ToLower();
//    Console.WriteLine(text);
//}
//void SubText(string text)
//{
//    text = text.Substring(2, 5);
//    Console.WriteLine(text);
//}
//void Replace(string text)
//{
//    text = text.Replace("Test", "Exam");
//    Console.WriteLine(text);
//}

#endregion


#region DelegateOrder

List<Order> _orderList = new List<Order>();
for(int i = 1; i <= 50; i++)
{
    Random rnd = new Random();
    Order order = new Order();
    order.ProductName = $"Product {i}";
    order.Price = rnd.Next(50, 1000);
    order.Quantity = rnd.Next(1, 30);
    _orderList.Add(order);
}

foreach(Order order in _orderList)
{
    order.OrderEvent += ShowOrderFromEvent;
    order.OrderEvent += ShowOrderTotalFromEvent;
    order.OrderEvent -= ShowOrderTotalFromEvent;
    order.OrderMethod(order);
    Console.WriteLine($"Order From Loop / Product Name : {order.ProductName}, Price : {order.Price}, Quantity : {order.Quantity}, Total : {order.ShowTotalMethd(order.Price, order.Quantity, OrderTotal)}");
}

void ShowOrderFromEvent(Order order)
{
    Console.WriteLine($"Order From Event / Product : {order.ProductName}, Price : {order.Price}, Quantity : {order.Quantity}");
}
void ShowOrderTotalFromEvent(Order order)
{
    Console.WriteLine($"Order Total From Event / {order.ShowTotalMethd(order.Price, order.Quantity, OrderTotal)}");
}

double OrderTotal(double prodPrice, double prodQnt)
{
    return prodPrice * prodQnt;
}
#endregion
#endregion

Console.ReadLine();

delegate void ShowText(string text);
delegate void ShowUpperText();
