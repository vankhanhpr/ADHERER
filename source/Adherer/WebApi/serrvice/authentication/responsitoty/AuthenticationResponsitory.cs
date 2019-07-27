using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApi.model;
using WebApi.serrvice.admin.model;
using WebApi.serrvice.authentication.model;
using WebApi.serrvice.user.interfaces;

namespace WebApi.serrvice.authentication.responsitoty
{
    public class AuthenticationResponsitory : IAuthentication
    {
        private readonly IConfiguration m_config;
        private IUserResponsitory m_userResponsitory;
        public static IDictionary<string, string> m_tokens = new Dictionary<string, string>();
        public AuthenticationResponsitory(IConfiguration config, IUserResponsitory userResponsitory)
        {
            m_config = config;
            m_userResponsitory = userResponsitory;
        }

        public bool checkPass(string pass, string passClient)
        {
            throw new NotImplementedException();
        }

        public DataRespond login(Auth auth)
        {
            Users user = m_userResponsitory.getUserByMaDv(auth.madv);
            DataRespond data = new DataRespond();
            if (user==null)
            {
                data.success = false;
                data.message = "Mã Đảng viên hoặc mật khẩu không chính xác!";
                return data;
            }
            if(auth.madv==user.madv&& auth.password== user.password)
            {
                data.success = true;
                data.data = new { token = BuildToken(user), user = user };
                data.message = "Đăng nhập thành công!";
            }
            else
            {
                data.success = false;
                data.message = "Mã Đảng viên hoặc mật khẩu không chính xác!";
            }
            return data;
        }
        public void savaToken(string madv,string token)
        {
            m_tokens.Add(madv, token);
        }
        public void logout(string madv)
        {
            m_tokens.Remove(madv);
        }

        public void refreshToken()
        {
            throw new NotImplementedException();
        }

        public bool validateToken(string token, string tokenClien)
        {
            throw new NotImplementedException();
        }


        private string BuildToken(Users user)
        {
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, user.madv),
                new Claim(JwtRegisteredClaimNames.Email, user.password),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(m_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(m_config["Jwt:Issuer"],
                m_config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(1), //expire time là 30 phút
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
