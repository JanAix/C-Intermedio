// Crear repositorio genérico para Asientos
using RefactoryngGenerics.Entities;
using RefactoryngGenerics.Repository;

IRepository<Asiento> asientoRepository = new IRepository<Asiento>();

// Crear un nuevo asiento
var nuevoAsiento = new Asiento
{
    AsientoId = 1,
    BusId = 101,
    NumeroPiso = 1,
    NumeroAsiento = 10,
    FechaCreacion = DateTime.Now
};

// Agregar asiento al repositorio
asientoRepository.Agregar(nuevoAsiento);

// Mostrar todos los asientos
Console.WriteLine("Asientos en el repositorio:");
foreach (var asiento in asientoRepository.GetAll())
{
    Console.WriteLine($"ID: {asiento.AsientoId}, Bus: {asiento.BusId}, Piso: {asiento.NumeroPiso}, Asiento: {asiento.NumeroAsiento}");
}


Console.ReadLine();
    


