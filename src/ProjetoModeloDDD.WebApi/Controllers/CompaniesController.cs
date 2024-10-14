using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.DataTransferObjects;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private IAppServiceBase<Company, CompanyDto> appService;

        public CompaniesController(IAppServiceBase<Company, CompanyDto> appService)
        {
            this.appService = appService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var dados = await this.appService.GetAll();

            return StatusCode(200, dados);
        }
    }
}
