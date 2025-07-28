using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCNikamoozClient.Domain.Model
{
    public record class StudentUpdateModel
    {
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Description { get; init; }
    }
}
