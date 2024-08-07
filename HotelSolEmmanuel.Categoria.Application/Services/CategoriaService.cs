
using HotelSolEmmanuel.Categoria.Application.Base;
using HotelSolEmmanuel.Categoria.Application.DTOs;
using HotelSolEmmanuel.Categoria.Application.Interfaces;
using HotelSolEmmanuel.Categoria.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace HotelSolEmmanuel.Categoria.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository categoriaRepository;
        private readonly ILogger<CategoriaService> logger;

        public CategoriaService(ICategoriaRepository categoriaRepository, ILogger<CategoriaService> logger)
        {
            this.categoriaRepository = categoriaRepository;
            this.logger = logger;
        }

        public ServiceResult GetCategorias()
        {
            var categorias = categoriaRepository.GetAll();
            var categoriaDTOs = categorias.Select(c => new CategoriaDTO
            {
                IdCategoria = c.Id,
                Descripcion = c.Descripcion,
                Estado = c.Estado,
                FechaCreacion = c.FechaCreacion,
            }).ToList();

            return new ServiceResult
            {
                Success = true,
                Message = "Categorias cargadas exitosamente",
                Data = categoriaDTOs
            };
        }

        public ServiceResult GetCategorias(int id)
        {
            var categoria = categoriaRepository.GetEntityBy(id);
            if(categoria == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Categoria no encontrada"
                };
            }

            var categoriaDTO = new CategoriaDTO
            {
                IdCategoria = categoria.Id,
                Descripcion = categoria.Descripcion,
                Estado = categoria.Estado,
                FechaCreacion = categoria.FechaCreacion,
            };

            return new ServiceResult
            {
                Success = true,
                Message = "Categoria cargada satisfactoriamente",
                Data = categoriaDTO
            };
        }

        public ServiceResult SaveCategorias(CategoriaSaveModel categoriaSaveModel)
        {
            var categoria = new Domain.Entities.Categoria
            {
                IdCategoria = categoriaSaveModel.IdCategoria,
                Descripcion = categoriaSaveModel.Descripcion,
                Estado = categoriaSaveModel.Estado,
                FechaCreacion = categoriaSaveModel.FechaCreacion
            };

            categoriaRepository.Save(categoria);
            return new ServiceResult
            {
                Success = true,
                Message = "Categoria guardada satisfactoriamente"
            };
        }

        public ServiceResult UpdateCategorias(CategoriaUpdateModel categoriaUpdateModel)
        {
            var categoria = categoriaRepository.GetEntityBy(categoriaUpdateModel.IdCategoria);
            if(categoria == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Categoria no encontrada"
                };
            }
            categoria.IdCategoria = categoriaUpdateModel.IdCategoria;
            categoria.Descripcion = categoriaUpdateModel.Descripcion;
            categoria.Estado = categoriaUpdateModel.Estado;
            categoria.FechaCreacion = categoriaUpdateModel.FechaCreacion;

            categoriaRepository.Update(categoria);
            return new ServiceResult
            {
                Success = true,
                Message = "Categoria actualizada satisfactoriamente"
            };
        }

        public ServiceResult DeleteCategorias(CategoriaDeleteModel categoriaDeleteModel)
        {
            var categoria = categoriaRepository.GetEntityBy(categoriaDeleteModel.IdCategoria);
            if( categoria == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Categoria no encontrada"
                };
            }

            categoriaRepository.Remove(categoria);
            return new ServiceResult
            {
                Success = true,
                Message = "Categoria eliminada satisfactoriamente"
            };
        }
    }
}
