string[] value = { "15", "hello", "600", "4", "control Work", "by", "Isachenkova" };
void Examination(string[] values)
{
    int count = 0;
    int j = 0;
    for (int i = 0; i < values.Length; i++)
    {
        string number = values[i];
        if (number.Length <= 3)
        {
            count++;
        }

    }
    string[] valuesTwo = new string[count];
    
    for (int i = 0; i < values.Length; i++)
    {
        
        string number = values[i];
        if (number.Length <= 3)
        {
            valuesTwo[j] = number;
            Console.Write($"{valuesTwo[j]} ");
            j++;
        }

    }

}
Examination(value);