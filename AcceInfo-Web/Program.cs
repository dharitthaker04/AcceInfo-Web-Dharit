using AcceInfo_Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage; // ✅ Add this
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using System.Globalization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Localization;


// ✅ Set static culture (e.g., "fr")
var culture = new CultureInfo("fr-FR"); // Change to "fr-FR en-US" to test English
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// ✅ Add Blazored.LocalStorage service
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddBlazoredLocalStorage();

// ✅ Optional: If you use HttpClient with BaseAddress
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });



builder.Services.AddLocalization(); // ✅ For WebAssembly

await builder.Build().RunAsync();


 
