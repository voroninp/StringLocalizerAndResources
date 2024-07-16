using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using StringLocalizerAndResources.Resources;

var services = new ServiceCollection();
services.AddLocalization(cfg => cfg.ResourcesPath = "").AddLogging();

var sp = services.BuildServiceProvider();
var typedLocilizer = sp.GetRequiredService<IStringLocalizer<Foo>>();
Console.WriteLine(typedLocilizer["Key"]);

var locilizer = sp.GetRequiredService<IStringLocalizerFactory>().Create("res", Assembly.GetExecutingAssembly().FullName!);
Console.WriteLine(locilizer["Key"]);