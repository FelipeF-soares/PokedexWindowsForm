using Pokedex.Models.PokemonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models;

public class  GetPokemonAPI
{
    private HttpClient _httpClient;
    private string _urlPath;

    public  GetPokemonAPI(string urlPath)
    {
        _httpClient = new HttpClient();
        _urlPath = urlPath;
    }

    public async Task<string> RealizaRequisicaoAsysnc(int id)
    {
            try
            {
            string url = $"{_urlPath}{id.ToString()}";
            return await _httpClient.GetStringAsync(url);
            }
            catch (Exception ex)
            {
               throw new Exception("Erro na Requisição : "+ ex.Message);
            }
    }

}
