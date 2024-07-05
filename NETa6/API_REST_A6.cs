using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETa6
{
    internal class API_REST_A6
    {

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;
        //using System.Collections.Generic;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        List<string> endpointsToCheck = new List<string>
        //        {

        //            "/metodos/exportar-csv-endpoint/",
        //        };

        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                foreach (var endpoint in endpointsToCheck)
        //                {
        //                    await CheckEndpoint(client, endpoint);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }

        //    static async Task CheckEndpoint(HttpClient client, string endpoint)
        //    {
        //        Console.WriteLine($"\nVerificando endpoint: {endpoint}");

        //        // Probar con GET
        //        await CheckMethod(client, HttpMethod.Get, endpoint);

        //        // Probar con POST
        //        await CheckMethod(client, HttpMethod.Post, endpoint);

        //        // Probar con OPTIONS
        //        await CheckMethod(client, HttpMethod.Options, endpoint);
        //    }

        //    static async Task CheckMethod(HttpClient client, HttpMethod method, string endpoint)
        //    {
        //        HttpRequestMessage request = new HttpRequestMessage(method, $"{BaseUrl}{endpoint}");
        //        HttpResponseMessage response = await client.SendAsync(request);

        //        Console.WriteLine($"  {method} - Código de estado: {response.StatusCode}");

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            Console.WriteLine($"  Contenido (primeros 100 caracteres): {(content.Length > 100 ? content.Substring(0, 100) + "..." : content)}");
        //        }

        //        // Mostrar headers relevantes
        //        if (response.Headers.Contains("Allow"))
        //        {
        //            Console.WriteLine($"  Allow: {string.Join(", ", response.Headers.GetValues("Allow"))}");
        //        }
        //    }
        //}

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                client.BaseAddress = new Uri(BaseUrl);
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
        //                    "Basic",
        //                    Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"))
        //                );

        //                await CheckEndpoint(client, "/metodos/exportar-csv-endpoint/");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }

        //    static async Task CheckEndpoint(HttpClient client, string endpoint)
        //    {
        //        Console.WriteLine($"\nVerificando endpoint: {endpoint}");

        //        await CheckMethod(client, HttpMethod.Get, endpoint);
        //        await CheckMethod(client, HttpMethod.Post, endpoint);
        //        await CheckMethod(client, HttpMethod.Options, endpoint);
        //    }

        //    static async Task CheckMethod(HttpClient client, HttpMethod method, string endpoint)
        //    {
        //        try
        //        {
        //            HttpRequestMessage request = new HttpRequestMessage(method, endpoint);
        //            HttpResponseMessage response = await client.SendAsync(request);

        //            Console.WriteLine($"  {method} - Código de estado: {response.StatusCode}");

        //            if (response.Content != null)
        //            {
        //                string content = await response.Content.ReadAsStringAsync();
        //                Console.WriteLine($"  Contenido (primeros 100 caracteres): {(content.Length > 100 ? content.Substring(0, 100) + "..." : content)}");
        //            }

        //            Console.WriteLine("  Headers de respuesta:");
        //            foreach (var header in response.Headers)
        //            {
        //                Console.WriteLine($"    {header.Key}: {string.Join(", ", header.Value)}");
        //            }

        //            if (response.Content != null && response.Content.Headers != null)
        //            {
        //                Console.WriteLine("  Headers de contenido:");
        //                foreach (var header in response.Content.Headers)
        //                {
        //                    Console.WriteLine($"    {header.Key}: {string.Join(", ", header.Value)}");
        //                }
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"  Error en la solicitud HTTP: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"  Error inesperado: {ex.Message}");
        //        }
        //    }
        //}











        //using System;
        //using System.Net.Http;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";

        //    static async Task Main(string[] args)
        //    {
        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                Console.WriteLine("Intentando conectar a la URL base...");
        //                HttpResponseMessage response = await client.GetAsync(BaseUrl);

        //                Console.WriteLine($"Código de estado: {response.StatusCode}");

        //                string content = await response.Content.ReadAsStringAsync();
        //                Console.WriteLine("Contenido de la respuesta:");
        //                Console.WriteLine(content);
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error de conexión: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("Presiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }
        //}

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                // Configurar la autenticación básica
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                Console.WriteLine("Intentando conectar a la URL base con credenciales...");
        //                HttpResponseMessage response = await client.GetAsync(BaseUrl);

        //                Console.WriteLine($"Código de estado: {response.StatusCode}");

        //                string content = await response.Content.ReadAsStringAsync();
        //                Console.WriteLine("Contenido de la respuesta:");
        //                Console.WriteLine(content);

        //                // Mostrar los headers de la respuesta
        //                Console.WriteLine("\nHeaders de la respuesta:");
        //                foreach (var header in response.Headers)
        //                {
        //                    Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
        //                }
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error de conexión: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }
        //}

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";
        //    private const string CsvEndpoint = "/api/v1/exportar-csv"; // Ajusta esta ruta según sea necesario

        //    static async Task Main(string[] args)
        //    {
        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                Console.WriteLine("Intentando obtener datos CSV...");
        //                HttpResponseMessage response = await client.GetAsync($"{BaseUrl}{CsvEndpoint}");

        //                Console.WriteLine($"Código de estado: {response.StatusCode}");

        //                if (response.IsSuccessStatusCode)
        //                {
        //                    string csvContent = await response.Content.ReadAsStringAsync();
        //                    Console.WriteLine("Contenido CSV:");
        //                    Console.WriteLine(csvContent);

        //                    // Opcionalmente, puedes procesar el CSV aquí para mostrarlo de forma más estructurada
        //                }
        //                else
        //                {
        //                    Console.WriteLine("No se pudo obtener el CSV. Detalles de la respuesta:");
        //                    Console.WriteLine(await response.Content.ReadAsStringAsync());
        //                }

        //                // Mostrar los headers de la respuesta
        //                Console.WriteLine("\nHeaders de la respuesta:");
        //                foreach (var header in response.Headers)
        //                {
        //                    Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
        //                }
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error de conexión: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }
        //}

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        string[] possibleEndpoints = {
        //            "/api/v1/exportar-csv",
        //            "/api/exportar-csv",
        //            "/exportar-csv",
        //            "/csv-export",
        //            "/export/csv"
        //        };

        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                foreach (var endpoint in possibleEndpoints)
        //                {
        //                    Console.WriteLine($"Intentando obtener datos CSV desde {endpoint}...");
        //                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}{endpoint}");

        //                    Console.WriteLine($"Código de estado: {response.StatusCode}");

        //                    string content = await response.Content.ReadAsStringAsync();
        //                    Console.WriteLine("Contenido de la respuesta:");
        //                    Console.WriteLine(content);

        //                    Console.WriteLine("\nHeaders de la respuesta:");
        //                    foreach (var header in response.Headers)
        //                    {
        //                        Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
        //                    }

        //                    Console.WriteLine("\n----------------------------\n");
        //                }
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error de conexión: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }
        //}

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        string[] possibleEndpoints = {
        //            "/api/export-csv",
        //            "/api/v1/export-csv",
        //            "/export/csv",
        //            "/api/csv",
        //            "/data/export"
        //        };

        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                foreach (var endpoint in possibleEndpoints)
        //                {
        //                    Console.WriteLine($"Intentando obtener datos CSV desde {endpoint}...");
        //                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}{endpoint}");

        //                    Console.WriteLine($"Código de estado: {response.StatusCode}");

        //                    string content = await response.Content.ReadAsStringAsync();
        //                    Console.WriteLine("Contenido de la respuesta:");
        //                    Console.WriteLine(content.Length > 100 ? content.Substring(0, 100) + "..." : content);

        //                    Console.WriteLine("\n----------------------------\n");
        //                }
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error de conexión: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }
        //}

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        Console.WriteLine("Introduce la ruta a probar (por ejemplo, /api/export-csv):");
        //        string endpoint = Console.ReadLine();

        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                Console.WriteLine($"Intentando acceder a {BaseUrl}{endpoint}...");
        //                HttpResponseMessage response = await client.GetAsync($"{BaseUrl}{endpoint}");

        //                Console.WriteLine($"Código de estado: {response.StatusCode}");

        //                string content = await response.Content.ReadAsStringAsync();
        //                Console.WriteLine("Contenido de la respuesta:");
        //                Console.WriteLine(content.Length > 500 ? content.Substring(0, 500) + "..." : content);

        //                Console.WriteLine("\nHeaders de la respuesta:");
        //                foreach (var header in response.Headers)
        //                {
        //                    Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
        //                }
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error de conexión: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }
        //}



        ///////*******19****
        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                Console.WriteLine("Intentando conectar a la URL base con credenciales...");
        //                HttpResponseMessage response = await client.GetAsync(BaseUrl);

        //                Console.WriteLine($"Código de estado: {response.StatusCode}");

        //                if (response.IsSuccessStatusCode)
        //                {
        //                    Console.WriteLine("Conexión exitosa. Las credenciales parecen ser correctas.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("La conexión no fue exitosa. Las credenciales podrían ser incorrectas o no tener los permisos necesarios.");
        //                }

        //                string content = await response.Content.ReadAsStringAsync();
        //                Console.WriteLine("\nContenido de la respuesta (primeros 500 caracteres):");
        //                Console.WriteLine(content.Length > 500 ? content.Substring(0, 500) + "..." : content);

        //                Console.WriteLine("\nHeaders de la respuesta:");
        //                foreach (var header in response.Headers)
        //                {
        //                    Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
        //                }
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error de conexión: {e.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }
        //}

        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        string[] endpointsToCheck = { "/api", "/api/v1", "/services", "/swagger.json" };

        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                string authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

        //                foreach (var endpoint in endpointsToCheck)
        //                {
        //                    await CheckEndpoint(client, endpoint);
        //                }

        //                // Intentar solicitud OPTIONS
        //                await CheckOptionsRequest(client);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }

        //    static async Task CheckEndpoint(HttpClient client, string endpoint)
        //    {
        //        Console.WriteLine($"\nVerificando endpoint: {endpoint}");
        //        HttpResponseMessage response = await client.GetAsync($"{BaseUrl}{endpoint}");
        //        await PrintResponse(response);
        //    }

        //    static async Task CheckOptionsRequest(HttpClient client)
        //    {
        //        Console.WriteLine("\nRealizando solicitud OPTIONS al BaseUrl");
        //        HttpRequestMessage optionsRequest = new HttpRequestMessage(HttpMethod.Options, BaseUrl);
        //        HttpResponseMessage response = await client.SendAsync(optionsRequest);
        //        await PrintResponse(response);
        //    }

        //    static async Task PrintResponse(HttpResponseMessage response)
        //    {
        //        Console.WriteLine($"Código de estado: {response.StatusCode}");

        //        string content = await response.Content.ReadAsStringAsync();
        //        Console.WriteLine("Contenido de la respuesta (primeros 500 caracteres):");
        //        Console.WriteLine(content.Length > 500 ? content.Substring(0, 500) + "..." : content);

        //        Console.WriteLine("Headers de la respuesta:");
        //        foreach (var header in response.Headers)
        //        {
        //            Console.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
        //        }
        //    }
        //}


        //using System;
        //using System.Net.Http;
        //using System.Net.Http.Headers;
        //using System.Text;
        //using System.Threading.Tasks;
        //using Newtonsoft.Json;

        //class Program
        //{
        //    private const string BaseUrl = "";
        //    private const string Username = "";
        //    private const string Password = "";

        //    static async Task Main(string[] args)
        //    {
        //        Console.WriteLine("Ingrese la fecha de inicio ():");
        //        string startDate = Console.ReadLine();

        //        Console.WriteLine("Ingrese la fecha de fin (YYYY-MM-DD):");
        //        string endDate = Console.ReadLine();

        //        try
        //        {
        //            using (HttpClient client = new HttpClient())
        //            {
        //                client.BaseAddress = new Uri(BaseUrl);
        //                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
        //                    "Basic",
        //                    Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}/{startDate}/{endDate}"))
        //                );

        //                Intentar diferentes rutas potenciales
        //                string[] potentialEndpoints = {
        //                    "/api/export",
        //                    "/api/data",
        //                    "/api/csv-export",
        //                    "/metodos/exportar-csv",
        //                    "/export-csv"
        //                };

        //                foreach (var endpoint in potentialEndpoints)
        //                {
        //                    await TryExtractData(client, endpoint, startDate, endDate);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        //        }

        //        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        //        Console.ReadKey();
        //    }

        //    static async Task TryExtractData(HttpClient client, string endpoint, string startDate, string endDate)
        //    {
        //        Console.WriteLine($"\nIntentando extraer datos de {endpoint}");

        //        var requestBody = new
        //        {
        //            startDate = startDate,
        //            endDate = endDate
        //        };

        //        var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

        //        try
        //        {
        //            HttpResponseMessage response = await client.PostAsync(endpoint, content);

        //            Console.WriteLine($"Código de estado: {response.StatusCode}");

        //            string responseContent = await response.Content.ReadAsStringAsync();
        //            Console.WriteLine($"Contenido de la respuesta (primeros 500 caracteres):");
        //            Console.WriteLine(responseContent.Length > 500 ? responseContent.Substring(0, 500) + "..." : responseContent);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                Aquí puedes agregar lógica para procesar o guardar los datos si la respuesta es exitosa
        //                Console.WriteLine("Extracción exitosa. Procesando datos...");
        //                ProcessData(responseContent);
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine($"Error en la solicitud HTTP: {e.Message}");
        //        }
        //    }
        //}
    }
}
