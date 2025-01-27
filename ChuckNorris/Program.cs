using System.Net.Http;


class Program(){

  static async void getJoke(){
  using (HttpClient chuckNorris = new HttpClient()){
      chuckNorris.BaseAddress = new Uri("https://api.chucknorris.io/jokes/random?category={category}");
       try{
      HttpResponseMessage response = await chuckNorris.GetAsync("jokes/random");
      response.EnsureSuccessStatusCode();
      string responseBody = await response.Content.ReadAsStringAsync();
      Console.WriteLine(responseBody);
      } catch (HttpRequestException e){
        Console.WriteLine(e.Message);
      }
       
    };
}
  static void Main(){
    getJoke();
   
  }
}
