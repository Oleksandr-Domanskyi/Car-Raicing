// See https://aka.ms/new-console-template for more information
using Car_Raicing;


Autobas autobas = new Autobas();
SportCar sportCar = new SportCar();
LightCar lightcar = new LightCar();
int i = 0;
while (i <= 2)
{
    autobas.RegisterWinner(HandlerWinner);
    lightcar.RegisterWinner(HandlerWinner);
    sportCar.RegisterWinner(HandlerWinner);

    autobas.Driving();
    lightcar.Driving();
    sportCar.Driving();

    i++;
}
static void HandlerWinner()
{
    Car.Win();
}


