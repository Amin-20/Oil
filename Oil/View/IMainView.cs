using Oil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil.View
{
    public interface IMainView
    {
        EventHandler<EventArgs> SelectionChange { get; set; }
        EventHandler<EventArgs> LoadMain { get; set; }
        EventHandler<EventArgs> QuantityChange { get; set; }
        EventHandler<EventArgs> QuantumChange { get; set; }
        OilClass SelectedOil { get; }
        List<OilClass> Oils { set; }
        string PriceText { get; set; }
        string QuantityText { get; set; }
        string QuantumText { get; set; }
        string TotalAmountText { get; set; }
    }
}
