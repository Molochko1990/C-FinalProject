string input = InputStr("Введите данные: ");

string[] array = input.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
string[] arrayNew = new string[array.Count()];
int ind = 0;

for (int i=0; i<array.Length; i++)
{
    if (array[i].Length < 4) 
    {
        arrayNew[ind] = array[i];
        ind++;
    } 
}
 Console.WriteLine("Обновленный массив из строк: ");
for (int i=0; i<arrayNew.Length; i++)
{
    Console.Write(arrayNew[i] + " ");
}


string InputStr(string output)
{
    Console.Write(output);
    return Console.ReadLine();
}