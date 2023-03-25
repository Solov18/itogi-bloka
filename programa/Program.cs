
int size = 10;
string[] arrayOne = new string[size];
FillRandArr(arrayOne);

void FillRandArr(string[] arr)
{
    Random rand = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,8);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += AllSymbols[rand.Next(0,AllSymbols.Length)];
        }        
    }
}