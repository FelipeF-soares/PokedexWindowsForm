using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models.PokemonClasses;

public class LoadImagemPokemon
{
    private string _imagemUrl;
    public LoadImagemPokemon(string imagemUrl)
    {
        _imagemUrl = imagemUrl;
    }

    public Image RetornaImagem()
    {
        try
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] imagemData = webClient.DownloadData(_imagemUrl);
                using(MemoryStream imageStream = new MemoryStream(imagemData)) 
                {
                    Image image = Image.FromStream(imageStream);
                    return image;
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro na Requisição : " + ex.Message);
        }
        
    }


}
