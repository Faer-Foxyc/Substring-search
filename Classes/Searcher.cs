using System;

namespace Substring_search.Classes
{
    internal class Searcher
    {
        string enteredString { get; set; }
        string subString { get; set; }
        string allRignts { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="_eneteredString">строка в которой выполняется поиск</param>
        /// <param name="_substring">строка которую нужно найти</param>
        public Searcher(string _enteredString, string _subString)
        {
            try
            {
                if (enteredString != null || subString != null)
                {
                    throw new ArgumentNullException("Строки не могут быть null");
                }
                this.enteredString = _enteredString;
                this.subString = _subString;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Конструктор класса без параметров
        /// </summary>
        public Searcher() { }

        /// <summary>
        /// Проверить тип данных входной строки
        /// </summary>
        /// <param name="_userInput">входная строка</param>
        /// <returns></returns>
        public bool CheckString(string _userInput)
        {
            int intValue;
            double doubleValue;
            bool isString = true;

            if (int.TryParse(_userInput, out intValue))
            {
                isString = false;
                return isString;
            }
            else if (double.TryParse(_userInput, out doubleValue))
            {
                isString = false;
                return isString;
            }
            return isString;
        }

        /// <summary>
        /// найти подстоку
        /// </summary>
        /// <returns></returns>
        public bool ReturnAString()
        {
            if (string.IsNullOrWhiteSpace(enteredString) || string.IsNullOrEmpty(subString))
            {
                return false;
            }
            else
            {
                int index = enteredString.IndexOf(subString);
                if (index == -1)
                {
                    return false;
                }
                return true;
            }
        }
        /// <summary>
        /// вывод сообщения о защите прав)
        /// </summary>
        /// <returns></returns>
        public string Rignts()
        {
            allRignts = "\nВсе права защищены, автором даной програмы является Foxy 17/05/2023";
            return allRignts;
        }
    }
}
