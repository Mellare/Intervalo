string valor = Console.ReadLine();

double.TryParse(valor, out double x);

if(x < 0){
    Console.WriteLine("Fora de intervalo");
}
else if(x > 100){
    Console.WriteLine("Fora de intervalo");
}
else if(x <= 25){
    Console.WriteLine("Intervalo [0,25]");
}
else if(x <= 50){
    Console.WriteLine("Intervalo (25,50]");
}
else if(x <= 75){
    Console.WriteLine("Intervalo (50,75]");
}
else if(x <= 100){
    Console.WriteLine("Intervalo (75,100]");
}
