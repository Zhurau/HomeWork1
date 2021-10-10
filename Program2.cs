
namespace Task2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i = 1;
            byte b = 2;
            bool bl = false;
            float f = 3.5f;
            double d = 10.5;
            double rezD;
            string s = "str";

            int rez = i++;
            rez = --b;
            i = -b;

            rez = i * b;
            rezD = f * d;
            rez = 10 / 4; //2
            rez = 10 % 3; //1
            rezD = 10 / 4; //2.25
            rezD = f / d;

            //логические операторы
            bl = (i > b) | (f <= d) ^ (i == 1);
            bl = (s != null) && (i > 4);

            //битовые операторы 
            rez = 0x0000FFFF & i;
            rez = rez ^ i;
            rez = ((b << 2) | 0x00FF) >> 2;

            //присваивание
            rezD = rez = i / b;
            rez *= ++b;
           
            //приведение
            object o = s;
            bl = o is string; // true
            string ss = o as string;
            i = 15;
            b = (byte)i;



        }
    }
}
