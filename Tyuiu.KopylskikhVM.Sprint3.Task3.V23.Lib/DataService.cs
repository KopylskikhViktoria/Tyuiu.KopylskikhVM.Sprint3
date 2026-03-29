using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KopylskikhVM.Sprint3.Task3.V23.Lib
{
    public class DataService : ISprint3Task3V23
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string res = "";

            foreach (char item in value)
            {
                if (item == replaceable)
                {
                    res += replacement;
                }
                else
                {
                    res += item;
                }
            }

            return res;
        }
    }
}