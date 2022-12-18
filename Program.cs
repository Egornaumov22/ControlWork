Console.Write("Сколько элементов? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] input =new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("введите "+(i+1)+" элемент");
    string part = Convert.ToString(Console.ReadLine());
    input[i]= part;
}




