using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCNikamoozClient.Domain.Model
{
    public class StudentCreateModel
    {
        public string StudentNumber { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Description { get; init; }
        public List<string> PhoneNumbers { get; init; }
    }
}
