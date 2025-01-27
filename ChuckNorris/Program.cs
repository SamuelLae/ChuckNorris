﻿using System.Net.Http;


class Program(){

  static async Task Main(){
  using (HttpClient chuckNorris = new HttpClient()){
      chuckNorris.BaseAddress = new Uri("https://api.chucknorris.io/");
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
}
