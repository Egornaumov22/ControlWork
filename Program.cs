Console.Write("Сколько элементов? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] input =new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("введите "+(i+1)+" элемент");
    string part = Convert.ToString(Console.ReadLine());
    input[i]= part;
}

string[] output=new string[size];
int n =0;
int m =3;

for (int j = 0; j < size; j++)
{
    if(input[j]<=m)
    {
        output[n]=input[j];
        n++;
    }
}
Console.WriteLine();




