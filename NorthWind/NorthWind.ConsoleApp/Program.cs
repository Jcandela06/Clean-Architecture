HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthServices();


using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Aplication Started."); 

IProductService service = AppHost.Services.GetRequiredService<IProductService>() ;
service.Add("Demo", "Azucar Refinada");


/*
 * AppLogger y Los Writers: Responsabilidad Unica
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias. Los modulos
 * de alto nivel son independientes de los detalles de implementación.
 * 
 */