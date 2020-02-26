using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AngularCrudWebApi.Controllers
{
    public class CountryController: ApiController  
{  
    // GET api/country  
    public IEnumerable <SelectListItem> Get()  
    {  
        List <SelectListItem > countries = new List<SelectListItem >  
        {  
            new SelectListItem  
            {  
                Text = "India", Value = "IN"  
            },  
            new SelectListItem  
            {  
                Text = "United States", Value = "US"  
            },  
            new SelectListItem  
            {  
                Text = "United Kingdom", Value = "UK"  
            },  
            new SelectListItem  
            {  
                Text = "Australlia", Value = "CA"  
            }  
        };  
        return countries;  
    }  
    // GET api/country/5  
    public IEnumerable <SelectListItem> Get(string id)  
    {  
        List <SelectListItem> states = new List<SelectListItem> ();  
        switch (id)  
        {  
            case "IN":
                    states.Add(new SelectListItem  
                    {  
                        Text = "Maharashtra", Value = "MH"  
                    });  
                    states.Add(new SelectListItem  
                    {  
                        Text = "Madhya Pradesh", Value = "MP"  
                    });  

                    states.Add(new SelectListItem  
                    {  
                        Text = "Delhi", Value = "DL"  
                    });  
                    states.Add(new SelectListItem  
                    {  
                        Text = "Kanpur", Value = "KN"  
                    });  
                    break;  
                    case "US":  
                        states.Add(new SelectListItem  
                        {  
                            Text = "California", Value = "CA"  
                        });  
                        states.Add(new SelectListItem  
                        {  
                            Text = "Newyork", Value = "NY"  
                        });  
                        break;  
                    case "UK":  
                        states.Add(new SelectListItem  
                        {  
                            Text = "London", Value = "LN"  
                        });  
                        states.Add(new SelectListItem  
                        {  
                            Text = "Paris", Value = "PR"  
                        });  
                        break;  
                   case "CA":  
                        states.Add(new SelectListItem  
                        {  
                            Text = "Sydney", Value = "SD"  
                        });  
                        states.Add(new SelectListItem  
                        {  
                            Text = "Melbourne", Value = "MB"  
                        });  
                        break;  
                }  
                return states;  
            }  
        }  
}
