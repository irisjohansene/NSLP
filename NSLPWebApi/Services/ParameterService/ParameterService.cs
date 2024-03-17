using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Respositories;
using System.Reflection.Metadata;

namespace NSLPWebApi.Services.ParameterService
{
    public class ParameterService : IParameterService
    {
        ParameterRepository _repo;
        AppDbContext _db;

        public ParameterService(ParameterRepository repo, AppDbContext db)
        {
            _repo = repo;
            _db = db;
        }

        public async Task<Models.Parameter> GetParameterByTypeAsync(string type)
        {
            var par = await _repo.GetAsync(x => x.ParameterType == type);
            return par;
        }
        public async Task UpdateParameterValueAsync(Models.Parameter param)
        {

            //using (var dbContext = new AppDbContext())
            //{
                var par = await _repo.GetAsync(x => x.ParameterType == param.ParameterType);
                par.ParameterValue = param.ParameterValue;
                _db.Entry(par).Property(x => x.ParameterValue).IsModified = true;
                //_db.Entry(par).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _db.SaveChangesAsync();
            //}
               
        }
    }
}
