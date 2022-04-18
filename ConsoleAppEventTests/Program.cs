
using ConsoleAppEventTests;

var buttonMaster = new ButtonMaster();

//oluşturduğumuz evente abone oluyoruz
buttonMaster.ButtonPressed += (sender, eventArgs) =>
{
    
    Console.WriteLine($"Button was pressed as {eventArgs.KeyCode}");
};

Start:

//Klavyede bastığı tuşu alıyoruz
var keyCode = Console.ReadKey(true).KeyChar;
buttonMaster.OnButtonPressed(keyCode);

goto Start;