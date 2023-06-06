double nr, vl, vl2;
string answer;
void dialog(string txt,int spd)
{
    for (int i=0; i < txt.Length; i++)
    {
        Console.Write(txt[i]);
        Thread.Sleep(spd);
    }
}
void mathing(int switching)
{
    switch(switching)
    {
        case 1:
        for (int i = 1; i < vl2+1; i++)
        {
        Console.WriteLine($"{vl} + {i} = {vl+i}");        
        }
        break;
        case 2:
        for (int i = 1; i < vl2+1; i++)
        {
        Console.WriteLine($"{vl} - {i} = {vl-i}");        
        }
        break;
        case 3:
        for (int i = 1; i < vl2+1; i++)
        {
        Console.WriteLine($"{vl} x {i} = {vl*i}");        
        }
        break;
        case 4:
        for (int i = 1; i < vl2+1; i++)
        {
        Console.WriteLine($"{vl} / {i} = {vl/i}");        
        }
        break;
        default:
        break;
    }
}
double question(string text, int speed)
{
Console.ForegroundColor = ConsoleColor.White;
dialog(text,speed);
Console.ForegroundColor = ConsoleColor.Green;
answer = Console.ReadLine()!;
if (double.TryParse(answer, out nr))
{
    nr = Convert.ToDouble(answer);
}
else if (double.TryParse(answer, out nr) == false)
{
    nr = 1;
}
return nr;
}
vl = question("Escolha um numero para a Tabuada: ",25);
vl2 = question("Escolha um numero de quantidade: ",25);
Console.ForegroundColor = ConsoleColor.Yellow;
dialog("Opções: Soma / Subtração / Multiplicação / Divisão\n",12);
Console.ForegroundColor = ConsoleColor.White;
dialog("Nota: escreva a operação em extenso.\n",6);
Console.ForegroundColor = ConsoleColor.Blue;
dialog("Operação: ",25);
Console.ForegroundColor = ConsoleColor.Cyan;
answer = Console.ReadLine()!;
if (answer.Trim() != "")
{
    if (answer.Length >= 2 && answer.Trim().Substring(0,2).ToLower() == "so")
    {
        mathing(1);
    }
    else if (answer.Length >= 2 && answer.Trim().Substring(0,2).ToLower() == "su")
    {
        mathing(2);
    }
    else if (answer.Trim().Substring(0,1).ToLower() == "m")
    {
        mathing(3);
    }
    else if (answer.Trim().Substring(0,1).ToLower() == "d")
    {
        mathing(4);
    }
}
Console.ResetColor();