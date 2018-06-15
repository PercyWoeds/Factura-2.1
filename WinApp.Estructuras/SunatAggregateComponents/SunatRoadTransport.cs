﻿using System;

namespace WinApp.Estructuras.SunatAggregateComponents
{
    [Serializable]
    public class SunatRoadTransport
    {
        public string LicensePlateId { get; set; }

        public string TransportAuthorizationCode { get; set; }

        public string BrandName { get; set; }
    }
}
