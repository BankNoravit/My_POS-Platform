using System;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace POS.Common
{
    public interface IJWTCommon
    {
        // Write Token
        string WriteToken(PARAM_JWT_ACCESS_TOKEN param);
        string WriteRefreshToken();

        // Get Token Body
        List<KeyValuePair<string, string>> ReadTokenBody(string token);
        string ReadTokenBodyByKey(string token, string key);
        T ReadTokenBodyByKey<T>(string token, string key);
    }

    public partial class JWTCommon : IJWTCommon
    {
        #region [Private Members]
        private readonly string _securityAlgorithms;
        #endregion [Private Members]

        #region [Constructor]
        public JWTCommon()
        {
            this._securityAlgorithms = SecurityAlgorithms.HmacSha384;
        }
        #endregion [Constructor]

        #region [Write Token]
        public string WriteToken(PARAM_JWT_ACCESS_TOKEN param)
        {
            try
            {
                List<Claim> claims = new List<Claim>();
                if (!param.BODY.Any(f => f.Key == ClaimTypes.Name))
                {
                    claims.Add(new Claim(ClaimTypes.Name, param.USERNAME));
                }
                else
                {
                    claims.Add(new Claim(param.USERNAME.GetType().Name, param.USERNAME));
                }

                param.BODY.ForEach(e =>
                {
                    claims.Add(new Claim(e.Key, e.Value));
                });

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(param.SECRET_KEY));
                var creds = new SigningCredentials(key, this._securityAlgorithms);

                var token = new JwtSecurityToken(
                    issuer: param.ISSUER,
                    audience: param.AUDIENCE,
                    claims: claims,
                    notBefore: param.START_DATE,
                    expires: param.EXPIRE_DATE,
                    signingCredentials: creds);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string WriteRefreshToken()
        {
            var randomNumber = new byte[32];
            var datetimeByte = BitConverter.GetBytes(DateTime.Now.Ticks);
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                var randomWithDatetime = randomNumber.Concat(datetimeByte).ToArray();
                return Base64UrlEncoder.Encode(Convert.ToBase64String(randomWithDatetime));
            }
        }
        #endregion [Write Token]

        #region [Get Token Body]
        public List<KeyValuePair<string, string>> ReadTokenBody(string token)
        {
            try
            {
                var jwtHandler = new JwtSecurityTokenHandler();
                if (jwtHandler.CanReadToken(token))
                {
                    var tokenObj = jwtHandler.ReadJwtToken(token);
                    return tokenObj.Claims.Select(s => new KeyValuePair<string, string>(key: s.Type, value: s.Value)).ToList();
                }
                else
                {
                    throw new Exception("Invalid Token.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReadTokenBodyByKey(string token, string key)
        {
            try
            {
                var body = this.ReadTokenBody(token: token);
                if (body != null && body.Count() > 0)
                {
                    var selectedBody = body.Where(f => f.Key.ToUpper() == key.ToUpper());
                    if (selectedBody != null && selectedBody.Count() > 0)
                    {
                        return selectedBody.FirstOrDefault().Value;
                    }
                    else
                    {
                        throw new Exception("Invalid Token Body Key.");
                    }
                }
                else
                {
                    throw new Exception("Empty Token Body.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T ReadTokenBodyByKey<T>(string token, string key)
        {
            try
            {
                var tokenBodyValue = this.ReadTokenBodyByKey(token: token, key: key);
                try
                {
                    return (T)Convert.ChangeType(tokenBodyValue, typeof(T));
                }
                catch
                {
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion [Get Token Body]
    }
}
