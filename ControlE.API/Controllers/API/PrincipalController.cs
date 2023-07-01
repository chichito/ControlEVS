using CapaDatos;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ControlE.API.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {
        public PrincipalController()
        {
            
        }
        public async DataSet GetLogin(string username, string password) {
            string sError;
            clsGeneral clsG = new clsGeneral("Database=ControlE;Data Source=10.134.7.25;User Id=root;Password=p.123456;");
            return clsG.Login("control1", "1234", out sError);
        }
    }
}
