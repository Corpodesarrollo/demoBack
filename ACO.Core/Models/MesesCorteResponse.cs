namespace ACO.Core.Models;

public class MesesCorteResponse
{

    public MesesCorteResponse(string idMes, string nombreMes)
    {
        IdMes = idMes;
        NombreMes = nombreMes;
    }

    public string IdMes { get; set; }
    public string NombreMes { get; set; }
}
