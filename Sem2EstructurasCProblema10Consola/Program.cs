// See https://aka.ms/new-console-template for more information
/*
 Un restaurante ofrece un descuento del 10% para consumosde hasta S/ 100.00 y un descuento de 20%
para consumos mayores de S/ 100.00,para ambos casos se aplica unimpuesto del 18%.
Determinar el monto del descuento,el impuesto, el sub total yel importe a pagar.

 */


Console.WriteLine("ingrese el monto");
double consumo =double.Parse(Console.ReadLine());
double descuento = 0;

if (consumo <=100.0) {
    descuento = 0.10 * consumo;

}
else {
    descuento = 0.20 * consumo;
}

double totalneto = consumo - descuento;
double igv = 0.18 * totalneto;
double total = totalneto + igv;

Console.WriteLine("total descuento: "+totalneto+"\n y el igv es "+igv+ "\n esto es el total a pagar "+total);

