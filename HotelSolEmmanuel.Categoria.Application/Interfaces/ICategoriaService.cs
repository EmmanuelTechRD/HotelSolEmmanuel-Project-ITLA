
using HotelSolEmmanuel.Categoria.Application.Base;
using HotelSolEmmanuel.Categoria.Application.DTOs;

namespace HotelSolEmmanuel.Categoria.Application.Interfaces
{
    public interface ICategoriaService
    {
        ServiceResult GetCategorias();
        ServiceResult GetCategorias(int CategoriaId);
        ServiceResult SaveCategorias(CategoriaSaveModel categoriaSaveModel);
        ServiceResult UpdateCategorias(CategoriaUpdateModel categoriaUpdateModel);
        ServiceResult DeleteCategorias(CategoriaDeleteModel categoriaDeleteModel);

    }
}
