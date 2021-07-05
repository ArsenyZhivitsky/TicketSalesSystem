using DataAccess.EFCore.Interfaces;

namespace Service.SessionService
{
    public class SessionService : ISessionService
    {
        //private readonly IUnitOfWork _unitOfWork;

        //public SessionService(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork; 
        //}
        //public string GetFilmName(int filmId)
        //{
        //    var filmName = _unitOfWork.Films.GetById(filmId).Name;
        //    return filmName;
        //}
        public string GetFilmName(int filmId)
        {
            throw new System.NotImplementedException();
        }
    }
}
