using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class WeatherController : ApiController
    {
        
        //The data should come from database but here I am hard coding it.  
  
        public static List<Weather> reports = new List<Weather>    
        {    
            new Weather { id = 1, Country = "Pakistan", Timezone = "PKT UTC+05:00" },    
            new Weather { id = 2, Country = "Australia", Timezone = "AWST; UTC+08:00, ACST; UTC+09:30, AEST; UTC+10:00 "},    
            new Weather { id = 3, Country = "New zealand", Timezone = "NZDT UTC +13:00, CHADT UTC +13:45" },    
            new Weather { id = 4, Country = "Malaysia", Timezone = " MST UTC+08:00:" },    
            new Weather { id = 5, Country = "Iran", Timezone = "IRST  UTC+03:30" }, 
            new Weather { id = 6, Country = "India", Timezone = "IST UTC+05:30" }, 
            new Weather { id = 7, Country = "China", Timezone = "CST UTC+08:00" }, 
            new Weather { id = 8, Country = "Turkey", Timezone = "TRT  UTC+03:00" }, 
            new Weather { id = 9, Country = "Oman", Timezone = "GST UTC+04:00" }, 
            new Weather { id = 10, Country = "Saudi Arabia", Timezone = "AST UTC+03:00" }, 


        };    
    
        [HttpGet]    
        public List<Weather> Get()    
        {    
            return reports;    
        }    
    
        [HttpGet]
        public List<Weather> Get(string country)    
        {    
            return reports.Where(i => i.Country == country).ToList();  
        }    
    
   
    }
}
