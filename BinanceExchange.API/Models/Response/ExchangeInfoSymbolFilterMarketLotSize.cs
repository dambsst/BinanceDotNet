﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using BinanceExchange.API.Converter;
using BinanceExchange.API.Models.Response.Interfaces;

namespace BinanceExchange.API.Models.Response
{
    [DataContract]
    public class ExchangeInfoSymbolFilterMarketLotSize : ExchangeInfoSymbolFilterLotSize
    {
    }
}
