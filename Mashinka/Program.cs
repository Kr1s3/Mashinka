// See https://aka.ms/new-console-template for more information
using Mashinka;

Vector3 vector = new Vector3(1, 2, 3);
Car Hundai = new Car("Hundai", vector);
Hundai.KeyIn();
Hundai.Start();

Hundai.Move(new Vector3(0, 6, 5));
Console.WriteLine(Hundai.GetInfo());
Hundai.Move(new Vector3(0, 6, 5));
Console.WriteLine(Hundai.GetInfo());
Hundai.Move(new Vector3(0, 6, 5));
Console.WriteLine(Hundai.GetInfo());
Hundai.Move(new Vector3(0, 6, 5));
Console.WriteLine(Hundai.GetInfo());
Hundai.KeyOut();
Hundai.Off();
