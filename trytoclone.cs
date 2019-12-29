using System;
using System.Collections.Generic;
using System.Data;

namespace trytoclone
{
    /// <summary>
    ///  i hate my life brother  i just try to clone the math class in systhem.math i can't understand how to use sqer root soo i will study more math <3 we need more !!! 
    /// </summary>
    class math
    {
        /// <summary>
        ///  check if the number have an intger root number 25 have 5 or 3 don't have it !!   
        /// </summary>
        public static bool hroot(int sum) =>  (sum == power(sqrt(sum), 2)) ? true : false ; 
        /// <summary>
        ///  get you sqer root of a intger as an intger 
        /// </summary>
        static float sqrt(int num)
        {
            //// the hack i am stupid i need more shit like this   ! ! ! !  
            int res = 0;
            int bit = 1 << 14;
            while (bit > num) bit >>= 2;
            while (bit != 0)
            {
                if (num >= res + bit)
                {
                    num -= res + bit;
                    res = (res >> 1) + bit;
                }
                else
                    res >>= 1;
                bit >>= 2;
            }
            return res;
        }
        public static  float e = 2718281828459045 * power(10,-15);
        public static float pi = 3141592653589793 * power(10 ,-15 ) ; 
        public static int   min  (int  a , int b  ) => a < b ? a : b;
        public static float min  (float a, float b) => a < b ? a : b;       
        public static int   max  (int a, int b) => a < b ? b : a;
        public static float max  (float a, float b) => a < b ? b : a ;
        /*
        i will understand this shit bitch !! this is all right man keep going   !!!  
        how to use a grafe bitch think about that shit && how to import that shit in a file .???
        public static float pow (float a = 4 , float b = 0.5f  )
        {               
            if (b ==(int)b)
            {
                if (b < 0) return 1 / pow(a, -b);
                if (b == 0) return 1;
                return a * pow(a, b - 1);
            }
            float i = pow(a,(int)b);
            b = b - (int)b; 
                   
        }*/
        /// <summary>
        /// Evaluate is  simple methode that take a string and Evaluate his reasult as an artimaique operation 
        /// my own thinking soo don't laff at me !!  
        /// </summary>
        public static float Evaluate(string line)
        {
            string temp = null;
            bool C = false;
            float nb = 0;
            int p = 0;
            List<char> op = new List<char>();
            List<float> number = new List<float>();
            char[] b = { '.', ',', '^', '/', '*', '-', '+' };
            line = line ?? "0"; 
            for (int k = 0; k < line.Length; k++)
            {

                if (line[k] > 47 && line[k] < 58)
                {
                    if (!C) nb = nb * 10 + (line[k] - 48);
                    else temp += line[k].ToString();
                }
                else if (line[k] == 40) { C = true; p++; }
                else if (line[k] == 41)
                {
                    p--;
                    if (p == 0)
                    {
                        C = false;
                        number.Add(Evaluate(temp));
                        temp = null;
                        p = -1;
                    }
                    else temp += line[k].ToString();
                }
                else if ((line[k] > 41 && line[k] < 48) || line[k] == 94)
                {
                    if (!C)
                    {
                        op.Add(line[k]);
                        if (p != -1)
                        {
                            number.Add(nb);
                            nb = 0;
                        }
                        else p = 0;
                    }
                    else temp += line[k].ToString();
                }
                else if (line[k] == ' ') continue;

            }
            number.Add(nb); 
            for (int j = 0; j < b.Length; j++) {
                int i;
                while (true)  {
                    for (i = 0; i < op.Count; i++) if (op[i] == b[j]) break;
                    if (i >= op.Count || number.Count == 1) break;
                    switch (op[i])
                    {
                        case '^': number[i] = power(number[i], (int)number[i + 1]); break;
                        case '/': number[i] = number[i] / number[i + 1]; break;
                        case '*': number[i] = number[i] * number[i + 1]; break;
                        case '-': number[i] = number[i] - number[i + 1]; break;
                        case '+': number[i] = number[i] + number[i + 1]; break;
                        case '.': number[i] = number[i] + point(number[i + 1]); break;
                        case ',': goto case '.';
                    }
                    op.RemoveAt(i); number.RemoveAt(i + 1);
                }
            }
            return sum(number.ToArray()); // i didn't deal whit 404 stuff so we do this in the real there is just number[0] ; 
        }

        public static float power(float a, int b) => (b < 0) ? 1 / power(a, -b) : (b == 0) ? 1 : a * power(a, b - 1);

        public static float point(float a) => a * power(10, -((int)a).ToString().Length);

        public static float sum(params float[] arg)
        {
            for (int i = 1; i < arg.Length; i++) arg[0] += arg[i];
            return arg[0];
        }

        public static int multiplucation(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            if (b < 0) return -multiplucation(a, -b);
            return a + multiplucation(a, b - 1);
        }
        /// <summary>
        ///  this is just like Evaluate() put the easy way of doing this soo (: 
        /// </summary>
        
        static double Eval(string expression)
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)(loDataTable.Rows[0]["Eval"]);
        }

    }
     /// <summary>
    ///  i need to deal whit some text and find a patern
    /// </summary>
    class patr ///  patern shit bitch 
    {
        /// <summary>
        ///  find a word then replace it whit another in a textbox in the same position 
        /// </summary>
        public static string Findandreplace(string text , string findme , string replaceme )
        {
            int temp = firstmatch(text,findme);
            string t1, t2;        
            while (temp>=0)
            {
                t1 = t2 = null; 
                for (int i = 0; i < temp; i++) t1 += text[i];
                for (int i = temp + findme.Length; i < text.Length; i++) t2 += text[i];
                text = t1 + replaceme + t2;
                temp = firstmatch(text, findme); 
            }
            return text; 
        }
        /// <summary>
        ///  find a word then replace it whit another in a text 
        /// </summary>
        public static string FindReplace(string text , string findme , string replaceme )
        {          
            List<string> temp = fstring.split(text);
            for (int item = 0; item<temp.Count;  item++) if (temp[item] == findme) temp[item] = replaceme; 
            return fstring.buildtxt(temp); 
        }
       
        /// <summary>
        ///  find how many match  of a patern 
        /// </summary>
        public static int match(string txt, string pat )
        {
            int match = 0;  /// simple match for mohe 
            string temp;
            for (int i = 0; i < txt.Length; ++i)
            {
                temp = null;
                if (txt[i] == pat[0])
                {
                    for (int j = 0; j < pat.Length && i + j < txt.Length; j++) temp = temp + txt[i + j];
                    if (temp == pat) { match++; i = i + pat.Length - 1; }
                }
            }
            return match;
        }
        /// <summary>
        ///  find if there is a patr in the text  and give it frist position 
        /// </summary>
        public static int firstmatch(string txt, string pat)
        {          
            string temp;
            for (int i = 0; i < txt.Length; ++i)
            {
                temp = null;
                if (txt[i] == pat[0])
                {
                    for (int j = 0; j < pat.Length && i + j < txt.Length; j++) temp = temp + txt[i + j];
                    if (temp == pat) return  i; 
                }
            }
            return -1; 
        }

        /// <summary>
        ///  find if there is a patern in the text 
        /// </summary>
        public static string fmatch(string txt)  // may be we are done for today !! 
        {
            string temp; 
            for(int i= 0; i< txt.Length; i++)
            {
                temp = null; 
                if (1 < match(txt , txt[i].ToString()))
                {
                    temp = txt[i].ToString(); 
                    for(int j= i+1; j  < txt.Length; j++ )
                    {
                        if (1 < match(txt, temp + txt[j].ToString()))
                        {
                            temp += txt[j].ToString(); 
                        }
                        /// roling stuff case you are dump as bich !!!!!!! like in rozalin homi !! 
                    }
                    if (1 < match(txt, temp))  /// this part need some update beacause we are loking for anthour patern in this patern for you need this could take  alot of time so try to understand this shit 
                    {
                        int m; 
                        for ( m = 0; m < temp.Length && txt[m] != txt[m + 1]; m++) ;
                        if (m < temp.Length) return temp[0].ToString(); 
                        else  return temp; 
                    } 
                }                
            }
            return "0"; 
        }
    }
    /// <summary>
    ///  i try to deal whit a srting in my own way have fan :)
    /// </summary>
    public static class fstring
    {
        /// <summary>
        ///tack a list and build a string whit space 
        /// </summary>
        public static string buildtxt(List<string> t, char i = ' ')
        {
            string temp = t[0];
            for (int l = 1; l < t.Count; l++) temp += i.ToString() + t[l];
            return temp;
        }
        public static List<string> split(string txt, char m = ' ')
        {
            List<string> hi = new List<string>();
            string temp = null;
            int i = 0;
            for (int o = 0; o < txt.Length; o++)
            {
                if (txt[o] == m)
                {
                    for (; i < o; i++) temp += txt[i];
                    if (temp != null && temp != m.ToString()) hi.Add(temp);
                    temp = null;
                    i++;
                }

            }
            for (; i < txt.Length; i++) temp += txt[i];
            if (temp != null && temp != m.ToString()) hi.Add(temp);
            return hi;
        }
        public static string[] Split(string txtt = null, char m = ' ')
        {
            string[] hi = new string[txtt[txtt.Length - 1] != m ? patr.match(txtt, " ") : patr.match(txtt, " ") - 1];
            string temp = null;
            int i = 0, index = 0;
            for (int o = 0; o < txtt.Length; o++)
            {
                if (txtt[o] == m)
                {
                    for (; i < o; i++) temp += txtt[i];
                    if (temp != null) hi[index++] = temp;
                    temp = null;
                    i++;
                }
            }
            for (; i < txtt.Length; i++) temp += txtt[i];
            if (temp != null) hi[index] = temp;
            return hi;
        }
    }
    /// <summary>
    ///  the random class put in my own way thank you (: 
    /// </summary>
    class rnd  
    {       
        static int p;
        public rnd() =>  p = DateTime.Now.Millisecond;
        
        public static int next(int a = 0  , int b = 0 )   
        {         
            int match = 0;
            p++; 
            hi: 
            int i = DateTime.Now.Millisecond;
            int  temp = DateTime.Now.Day + 31 + DateTime.Now.Hour + 24 + DateTime.Now.Second + 60 ;
            if (i == 0) i = 2;
            for (int j= 0; j < i*4; j++)
                    temp = temp * i + p  ;               
            match =(temp)<0 ? (-temp): (temp)   ;
            if (b != 0 || a != 0)
            {
                match %= b;
                if (match<a)
                    goto hi; 
            }
            return match;
        }      
        public int nextbyte() => 0 ;     // i need to understand  what this could do     
    } 
}
