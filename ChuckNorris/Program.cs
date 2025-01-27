using System.Net.Http;
using System.Text.Json;

class Program(){

  static async Task Main(){
    JsonSerializerOptions options = new JsonSerializerOptions{WriteIndented = true};

  using (HttpClient chuckNorris = new HttpClient()){
      chuckNorris.BaseAddress = new Uri("https://api.chucknorris.io/");
       try{
      HttpResponseMessage response = await chuckNorris.GetAsync("jokes/random");
      response.EnsureSuccessStatusCode();
      string responseBody = await response.Content.ReadAsStringAsync();
      string JsonString = JsonSerializer.Serialize(responseBody, options);
      Console.WriteLine(JsonString);
      } catch (HttpRequestException e){
        Console.WriteLine(e.Message);
      }
       
    };
}
}
