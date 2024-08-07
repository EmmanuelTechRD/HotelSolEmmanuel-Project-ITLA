namespace HotelSolEmmanuel.WebUI.Links
{
    public class ConfigUrl
    {
        public string? CategoriaBaseLink { get; set; }

        public string GetCategoria => $"{CategoriaBaseLink}/api/Categoria/GetCategoria";
        public string GetCategoriabyId(int id) => $"{CategoriaBaseLink}/api/Categoria/GetCategoriabyId?id={id}";
        public string CategoriaSave => $"{CategoriaBaseLink}/api/Categoria/SaveCategoria";
        public string CategoriaUpdate(int id) => $"{CategoriaBaseLink}/api/Categoria/UpdateCategoria?id={id}";
    }
}
