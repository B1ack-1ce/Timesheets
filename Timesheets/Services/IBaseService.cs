using Timesheets.Models.Dto;
using Timesheets.Models;

namespace Timesheets.Services
{
    /// <summary>
    /// Базовый интерфейс бизнес логики приложения
    /// </summary>
    /// <typeparam name="T">Входящая сущность (Request)</typeparam>
    /// <typeparam name="R">Выдаваемая сущность (Response)</typeparam>
    public interface IBaseService <T, R>
    {
        /// <summary>
        /// Получить конкретную запись
        /// </summary>
        /// <param name="id">Идентификатор (Guid) сущности</param>
        /// <returns>Возвращает запись, если существует</returns>
        Task<R> GetItemAsync(Guid id);

        /// <summary>
        /// Получить все записи
        /// </summary>
        /// <returns>Возвращает все записи</returns>
        Task<IEnumerable<R>> GetItemsAsync();

        /// <summary>
        /// Добавить новую запись
        /// </summary>
        /// <param name="item">Новая запись для добавления</param>
        /// <returns>Возвращает Guid новой записи</returns>
        Task<Guid> CreateAsync(T item);

        /// <summary>
        /// Обновить существующую запись
        /// </summary>
        /// <param name="id"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        Task UpdateAsync(Guid id, T item);

        /// <summary>
        /// Удалить существующую запись
        /// </summary>
        /// <param name="id">Guid записи</param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
    }
}
