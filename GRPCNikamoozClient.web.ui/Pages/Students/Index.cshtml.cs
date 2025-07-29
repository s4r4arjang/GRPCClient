using GRPCNikamoozClient.Domain.Model;
using GRPCNikamoozClient.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GRPCNikamoozClient.web.ui.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly IStudentService _studentService;

        public IEnumerable<StudentModel> Students { get; set; }
        public IndexModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task OnGetAsync()
        {
            Students = await _studentService.GetAll();
        }
    }
}
