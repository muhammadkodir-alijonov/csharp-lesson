﻿using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;

namespace CarShop.Api.Common.Configurations;
public static class JwtConfiguration
{
    public static void ConfigureAuth(this WebApplicationBuilder builder)
    {
        var _config = builder.Configuration.GetSection("Jwt");
        object value = builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
          .AddJwtBearer(options =>
          {
              options.TokenValidationParameters = new TokenValidationParameters()
              {
                  ValidateIssuer = true,
                  ValidIssuer = _config["Issuer"],
                  ValidateAudience = false,
                  ValidateLifetime = true,
                  ValidateIssuerSigningKey = true,
                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]!))
              };
          });
    }
}
