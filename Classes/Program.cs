using Substring_search.Classes;

/*---------------Start program-----------------*/

StartProgram();
EndProgram();

/*--------------------------------------------*/

void StartProgram()
{
    Greeting();

    while (true)
    {
        string EneteredString = ReturnAString();
        string SubString = ReturnASubString();

        Searcher searcher = new Searcher(EneteredString, SubString);
        bool answer = searcher.IsSubstringPresent();

        if (answer != false)
        {
            Console.WriteLine($"\nВ строке: {EneteredString}, присутствует подстрока: {SubString}");
        }
        else
        {
            Console.WriteLine("\nПодстрока не найдена");
        }

        Console.Write("\nХотите продолжить? Да/Нет: ");
        string _userInput = Console.ReadLine();
        if (_userInput.ToLower() == "нет")
        {
            break;
        }
    }
}
// приветствие пользователя
static void Greeting()
{
    string _userName = Environment.UserName;
    Console.WriteLine("-------------------------------------------------------------------\n");
    Console.WriteLine($"\tПриветствую тебя, пользователь {_userName}\n\tЭто простая программа для поиска подстроки в строке");
    Console.WriteLine("\n-------------------------------------------------------------------");
}

/// конец програмы
static void EndProgram()
{
    Searcher searcher = new Searcher();
    Console.WriteLine(searcher.Rignts());
    Thread.Sleep(5000);
}

// вернуть введенную подстроку
static string ReturnASubString() 
{
    string _subString = string.Empty;

    Console.Write("Введите подстроку для поиска: ");
    _subString = Console.ReadLine();

    while (true)
    {
        Searcher searcher = new Searcher();
        bool isString = searcher.CheckString(_subString);

        // проверяем на null или пустую строку
        if (string.IsNullOrEmpty(_subString))
        {
            Console.Write("\nСтрока не может быть пустой!\n\nВведите строку: ");
            _subString = Console.ReadLine();
        }
        // проверяем на null, пробелы и неявляется ли строка числом
        else if (string.IsNullOrWhiteSpace(_subString) || isString == false)
        {
            Console.WriteLine("\nВведенное значение не является строкой");
            Console.Write("\nВведите строку для поиска: ");
            _subString = Console.ReadLine();
        }
        else
        {
            break;
        }
    }
    // возвращаем результат
    return _subString;
}
/// вывести строку для 
static string ReturnAString()
{
    string _enteredString = string.Empty;

    Console.Write("\nВведите строку: ");
    _enteredString = Console.ReadLine();

    while (true)
    {
        Searcher searcher = new Searcher();
        bool isString = searcher.CheckString(_enteredString);

        if (string.IsNullOrEmpty(_enteredString))
        {
            Console.Write("\nСтрока не может быть пустой!\n\nВведите строку: ");
            _enteredString = Console.ReadLine();
        }
        else if (string.IsNullOrWhiteSpace(_enteredString) || isString == false)
        {
            Console.WriteLine("Введенное значение не является строкой");
            Console.Write("\nВведите строку: ");
            _enteredString = Console.ReadLine();
        }
        else
        {
            break;
        }
    }
    return _enteredString;
}