using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExampleShippingItem
{
    interface IDigitalProductModel:IProductModel
    {
        int TotalDownloadsLeft { get; }

    }
}
