using Oil.Data;
using Oil.Model;
using Oil.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil.Presenters
{
    public class MainPresenters
    {
        public List<OilClass> Oils = new List<OilClass>()
        {
            new OilClass()
            {
                Name="AI92",
                Price=1
            },
            new OilClass()
            {
                Name="AI95",
                Price=2
            },
            new OilClass()
            {
                Name="AI98",
                Price=2.3
            },
            new OilClass()
            {
                Name="Diesel",
                Price=0.8
            }
        };

        private readonly IMainView _view;
        private readonly OilContext _db;

        public MainPresenters(IMainView view)
        {
            _view = view;
            _db = new OilContext();
            LoadAllData();
            _view.SelectionChange += ViewSelectionChange;
            _view.LoadMain += ViewLoadMain;
            _view.QuantityChange += ViewQuantityChange;
            _view.QuantumChange += ViewQuantumChange;

        }

        private void ViewQuantumChange(object sender, EventArgs e)
        {
            if (_view.QuantumText != String.Empty)
            {
                _view.TotalAmountText = decimal.Parse(_view.QuantumText).ToString();
            }
            else
            {
                _view.TotalAmountText = "0.00";
            }
        }

        private void ViewQuantityChange(object sender, EventArgs e)
        {
            if (_view.QuantityText != String.Empty)
            {
                _view.TotalAmountText = (decimal.Parse(_view.QuantityText) * decimal.Parse(_view.PriceText)).ToString();
            }
            else
            {
                _view.TotalAmountText = "0.00";
            }
        }

        private void ViewLoadMain(object sender, EventArgs e)
        {
            var myoils = _db.Oils.ToList();
            _view.Oils = myoils;
        }

        private void ViewSelectionChange(object sender, EventArgs e)
        {
            var oil = _view.SelectedOil;
            _view.PriceText = oil.Price.ToString();
        }

        private void LoadAllData()
        {
            if (!_db.Oils.Any())
            {
                _db.Oils.AddRange(Oils);
                _db.SaveChanges();
            }
        }
    }
}
