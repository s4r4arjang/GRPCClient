using GRPCNikamoozClient.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCNikamoozClient.Domain.Repositories
{
    public interface IStudentRepository
    {
        IAsyncEnumerable<int> Create(IEnumerable<StudentCreateModel> students);
        Task Delete(int id);
        Task Update(StudentUpdateModel student);
        Task<StudentModel> GetById(int id);
        IAsyncEnumerable<StudentModel> GetAll();
    }
}
