using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Aplication Started."); 

ProductService service = new ProductService(Writer);
service.Add("Demo", "Azucar Refinada");


/*
 * AppLogger y Los Writers: Responsabilidad Unica
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias. Los modulos
 * de alto nivel son independientes de los detalles de implementación.
 * 
 */