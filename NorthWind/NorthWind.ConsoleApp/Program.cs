HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddSingleton<IUserActionWriter, ConsoleWriter>();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<IUserActionWriter, FileWriter>();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();

using IHost AppHost = Builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Aplication Started."); 

ProductService service = AppHost.Services.GetRequiredService<ProductService>() ;
service.Add("Demo", "Azucar Refinada");


/*
 * AppLogger y Los Writers: Responsabilidad Unica
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias. Los modulos
 * de alto nivel son independientes de los detalles de implementación.
 * 
 */