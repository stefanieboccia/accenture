using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Pages
{

public class IndexModel : PageModel
    {
        public enum Moedas
        {
            [Description("BTC-BRL")]
            Bitcoin = 1,
            [Description("ETH-BRL")]
            Ethereum = 2,
            [Description("Monero")]
            Monero = 3,
            [Description("ZCash")]
            ZCash = 4,
            [Description("BitCoin Cash")]
            BitCoinCash = 5
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Get the value selected in the combo list
            string FirstCurrency = "";
            string SecondCurrency = "";

            // Get the currency accepted by API
            FirstCurrency = VerifyCurrency(FirstCurrency);
            SecondCurrency = VerifyCurrency(SecondCurrency);

            // Call the API, that returns the value of the two selected currencies
            //https://economia.awesomeapi.com.br/json/all/FirstCurrency"+ , + SecondCurrency"
        }

        public string VerifyCurrency(string Currency)
        {
            switch (Currency)
            {
                case "BitCoin":
                    Currency = "BTC-BRL";
                    break;

                case "Ethereum/Classic Ethereum":
                    Currency = "ETH-BRL";
                    break;

                case "Monero":
                    Currency = "Monero";
                    break;

                case "ZCash":
                    Currency = "ZCash";
                    break;

                case "BitCoin Cash":
                    Currency = "BitCoin Cash";
                    break;
            }

            return Currency;
        }
    }
}
