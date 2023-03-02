class program{
    static void Main(string[] args){
    Console.WriteLine("input number :");
    int password = int.Parse(Console.ReadLine());
    Console.WriteLine("input agency :");
    string agency = Console.ReadLine();
    int digit = password % 10;
    int sib = password % 100/10;
    int roy = password % 1000/100;
    int pan = password % 10000/1000;
    int mun = password % 100000/10000;
    int san = password % 1000000/10000;
    bool check = false;
    switch (agency)
{
    case "CIA":
        if (digit / 3 == 0&&
    sib != 1&&sib != 3&& sib !=5 &&
    pan < 6&& pan != 8) {
    check = true;}
    Console.WriteLine(check);
        break;
    case "FBI":
        if(san > 4 && san < 7&&
        pan / 2 == 0&& pan != 6&&
        mun / 2 != 0 ){
        check = true;}
        Console.WriteLine(check);
        break;
    case "NSA":
    if(roy / 3 == 0 && roy / 2 != 0&&
    digit == 1 ||digit == 2 ||digit == 3 ||digit == 5 ||digit == 6
   ){
     check = true;}
     Console.WriteLine(check);
     break;
    default:
        break;
}
    }  
    }