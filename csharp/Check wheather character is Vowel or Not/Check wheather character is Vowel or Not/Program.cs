Console.WriteLine("Enter any Character");
char c=Convert.ToChar(Console.ReadLine());

if(c == 'a' || c== 'e' || c== 'i' || c== 'o' || c== 'u')
{
    Console.WriteLine(c + " is a vowel");
}
else
{
    Console.WriteLine(c + " is Not a vowel");
}