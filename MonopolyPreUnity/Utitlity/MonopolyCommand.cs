﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyPreUnity.Utitlity
{
    public enum MonopolyCommand
    {
        TurnMakeMove,
        TurnManageProperty,
        TurnMakeDeal,

        PropertyChoose,
        PropertyMortgage,
        PropertyUnmortgage,
        PropertyBuyHouse,
        PropertySellHouse,

        TileLandedPropertyBuy,
        TileLandedPropertyAuction,

        TradeChoosePlayer,
        TradeCreateDeal,
        TradeValidate
    }

    public enum MonopolyRequest
    {
        TurnActionChoice,

        PropertyManagePropertyChoice,
        PropertyManageActionChoice,

        MoveJailChoice,

        TileLandedPropertyChoice,
        AuctionBidChoice,

        TradePlayerChoice,
        TradeDealChoice,
        TradeValidationChoice
    }
}
