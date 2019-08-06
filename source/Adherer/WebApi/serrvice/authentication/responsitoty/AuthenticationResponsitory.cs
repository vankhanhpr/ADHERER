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
using WebApi.model.request;
using WebApi.serrvice.admin.model;
using WebApi.serrvice.authentication.model;
using WebApi.serrvice.user.interfaces;

namespace WebApi.serrvice.authentication.responsitoty
{
    public class AuthenticationResponsitory : IAuthentication
    {
        private readonly IConfiguration m_config;
        private IUserResponsitory m_userResponsitory;
        public static IDictionary<int, TokenRequest> m_tokens = new Dictionary<int, TokenRequest>();
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
                var token = BuildToken(user);
                data.data = new { token = token, user = user };
                data.message = "Đăng nhập thành công!";
                TokenRequest tokenrq = new TokenRequest();
                tokenrq.token = token;
                tokenrq.roleid = user.roleid;
                tokenrq.usid = user.usid;
                savaToken(user.usid,tokenrq);
            }
            else
            {
                data.success = false;
                data.message = "Mã Đảng viên hoặc mật khẩu không chính xác!";
            }
            return data;
        }
        public void savaToken(int usid,TokenRequest token)
        {
            //foreach (KeyValuePair<int, TokenRequest> item in m_tokens)
            //{
            //    if (item.Key == usid)
            //    {
                   
            //    }
            //}
            m_tokens.Remove(usid);
            m_tokens.Add(usid, token);
        }
        public void logout(int madv)
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
                new Claim(JwtRegisteredClaimNames.Typ, user.titleid.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,user.roleid.ToString())//check quyen
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(m_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(m_config["Jwt:Issuer"],
                m_config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(3), //expire time là 30 ngayf
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool checkToken(TokenRequest tokenrq)
        {
            foreach (KeyValuePair<int, TokenRequest> item in m_tokens)
            {
                if(item.Key== tokenrq.usid && item.Value.token== tokenrq.token && item.Value.roleid==tokenrq.roleid)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
