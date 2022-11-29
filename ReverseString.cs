namespace Stringer {

public class ReverseString {
        public void Reverse(string word) {

        string Str;
        string rev; 
        Str = "Programming";
        rev = "";
        int a;
        System.Console.WriteLine($"Value  of string is {Str}");
        a = Str.Length - 1;
        while (a >= 0) {
            rev += Str[a];
            a--;
        }
        System.Console.WriteLine($"Value of string is {rev}");
    }
}
}