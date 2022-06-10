using CarLoan.App.Models;
using CarLoan.App.API_Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ISLoans.Web.API_Router
{
    public class CarLoanDocumentService
    {
        const string ApiConfig = "https://applicationwebapi20220609150436.azurewebsites.net/";

        public static async Task<bool> InsertDocument(Quote model)
        {
            return await HttpHelper.InsertAsync(new Uri($"{ApiConfig}api/CarLoan/Create"), model);
        }

        public static async Task<bool> UpdateQuote(Quote model)
        {
            return await HttpHelper.PutAsync(new Uri($"{ApiConfig}api/CarLoan/Update"), model);
        }

        public static async Task<Quote> GetQuotesByID(int QuoteID)
        {
            return await HttpHelper.GetAsync<Quote>(new Uri($"{ApiConfig}api/CarLoan/GetQuotesByID?QuoteID={QuoteID}"));
        }

        public static async Task<List<Quote>> GetQuotesByEmail(string Email)
        {
            return await HttpHelper.GetAsync<List<Quote>>(new Uri($"{ApiConfig}api/CarLoan/GetQuotesByEmail?Email={Email}"));
        }

        public static async Task<List<Quote>> GetAllQuotes()
        {
            return await HttpHelper.GetAsync<List<Quote>>(new Uri($"{ApiConfig}api/CarLoan/GetAllQuotes"));
        }

        public static async Task<bool> DeleteQuote(Quote model)
        {
            return await HttpHelper.PutAsync(new Uri($"{ApiConfig}api/CarLoan/Delete"), model);
        }
    }
}
