using System;
using System.Net.Http;
using System.Threading.Tasks;

class conec
{
    static void Main(string[] args)
    {
        ConectorNequi conector = new ConectorNequi();
        conector.Conectar().Wait();

        Console.ReadLine();
    }
}

class ConectorNequi
{
    public async Task Conectar()
    {
        // Crea una instancia de HttpClient
        HttpClient httpClient = new HttpClient();

        // Configura el encabezado de autorización (si es necesario)
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer tu_token_de_autorizacion");

        // Realiza una solicitud GET a un endpoint de la API de Nequi
        HttpResponseMessage response = await httpClient.GetAsync("https://api.nequi.com/v1/endpoints");

        // Verifica si la solicitud fue exitosa
        if (response.IsSuccessStatusCode)
        {
            // Lee la respuesta como una cadena de texto
            string responseBody = await response.Content.ReadAsStringAsync();

            // Haz algo con la respuesta
            Console.WriteLine(responseBody);
        }
        else
        {
            Console.WriteLine("Error al realizar la solicitud: " + response.StatusCode);
        }

        // Cierra la conexión HttpClient
        httpClient.Dispose();
    }
}