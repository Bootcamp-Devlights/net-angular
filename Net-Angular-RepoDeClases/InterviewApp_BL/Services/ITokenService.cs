using InterviewApp_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp_BL.Services
{
    public interface ITokenService
    {
        string CreateToken(Usuario user);
    }
}
