using GRPCNikamoozClient.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCNikamoozClient.Domain.Services
{
    public interface IStudentService
    {
        Task Create(IEnumerable<StudentCreateModel> students);
        Task Delete(int id);
        Task Update(StudentUpdateModel student);
        Task<StudentModel> GetById(int id);
        Task<List<StudentModel>> GetAll();
    }
}
