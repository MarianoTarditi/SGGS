using CoreLayer.Enumerators;
using CoreLayer.Models;
using Microsoft.AspNetCore.Http;

namespace ServiceLayer.Helpers.Generic.Image
{
    // Interfaz que define los métodos para cargar y eliminar imágenes.
    public interface IImageHelper
    {
        // Método para cargar una imagen. Recibe el archivo de imagen, el tipo de imagen y un nombre de carpeta opcional.
        Task<ImageUploadModel> ImageUpload(IFormFile imageFile, ImageType imageType, string? folderName);

        // Método para eliminar una imagen, recibe el nombre de la imagen a eliminar.
        string DeleteImage(string imageName);
    }

}
