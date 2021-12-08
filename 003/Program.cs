//  3. =======По заданному номеру дня недели вывести его название=======

string Func(int x)
{
    string [] array = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    return array[x - 1]; 
}
Console.WriteLine(Func(4));
