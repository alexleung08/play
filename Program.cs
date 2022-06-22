
bool isContinue = true;
string user = "User1";
int[] data = { 3, 5, 7 };
int index = 0;
int num = 0;

while (isContinue)
{
    #region validation
    Console.Write(@"{0}, which line? (1-3)", user);
    int.TryParse(Console.ReadLine(), out index);

    if (index < 1 || index > 3)
    {
        Console.WriteLine("please input line number in 1-3, try again.");
        continue;
    }

    if (data[index - 1]==0)
    {
        Console.WriteLine("this line haven't poker,try other line.");
        continue;
    }

    Console.Write(@"{0}, input decrease number? (1-7)", user);
    int.TryParse(Console.ReadLine(), out num);
    if (num < 1 || num > 7)
    {
        Console.WriteLine("please input number in 1-7, try again.");
        continue;
    }

    if (data[index - 1] < num)
    {
        Console.WriteLine(@"current number is less than input number,try again.");
        continue;
    }
    #endregion

    data[index - 1] = data[index - 1] - num;

    int result = 0;
    foreach (int item in data)
    {
        result = result + item;
    }

    if (result > 1)
    {
        user = user == "User1" ? "User2" : "User1";
        continue;
    }

    if (result == 1)
    {
        user = user == "User1" ? "User2" : "User1";
        Console.Write("{0} unsuccess!", user);
        return;
    }

    if (result == 0)
    {
        Console.Write("{0} unsuccess!", user);
        return;
    }
}