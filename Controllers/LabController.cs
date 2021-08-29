using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace labapi
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<object>> Get()
        {
            //reemplazar SERVERNAME, DATABASENAME, USERNAME, PASSWORD con los que tiene el SqlSever que se va usar
            using var conn = new SqlConnection("Server=SERVERNAME;Database=DATABASENAME;user id=USERNAME;password=PASSWORD;MultipleActiveResultSets=true");

            //este es un query de ejemplo
            var data = await conn.QueryAsync("select * from patients");

            return data;
        }
    }
}
