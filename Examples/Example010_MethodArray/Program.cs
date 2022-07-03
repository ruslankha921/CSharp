int[] array = { 1, 21, 31, 43, 53, 69, 73, 88 };

int n = array.Length;
int find = 21;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}